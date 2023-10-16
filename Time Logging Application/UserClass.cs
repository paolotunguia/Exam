using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Controls.Primitives;

namespace Time_Logging_Application
{
    internal class UserClass
    {
        DBconnect connect = new DBconnect();

        public bool insertUser(string employeeID, string completeName, string username, string password)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `user`(`UserID`, `UserCompleteName`, `UserUsername`, `UserPassword`) VALUES(@eID, @cm, @un, @pw)", connect.getConnection);

            command.Parameters.Add("@eID", MySqlDbType.VarChar).Value = employeeID;
            command.Parameters.Add("@cm", MySqlDbType.VarChar).Value = completeName;
            command.Parameters.Add("@un", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pw", MySqlDbType.VarChar).Value = password;

            connect.openConnect();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.closeConnect();
                return true;
            }
            else
            {
                connect.closeConnect();
                return false;
            }
        }
        public DataTable getUserList()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `attendance`", connect.getConnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getList(MySqlCommand command)
        {
            command.Connection = connect.getConnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool TimeIn(string employeeID, string completeName)
        {
            MySqlCommand checkCommand = new MySqlCommand("SELECT * FROM `attendance` WHERE `UserID` = @eID", connect.getConnection);
            checkCommand.Parameters.Add("@eID", MySqlDbType.VarChar).Value = employeeID;

            connect.openConnect();
            MySqlDataReader reader = checkCommand.ExecuteReader();

            if (reader.Read())
            {
                reader.Close();

                MySqlCommand updateCommand = new MySqlCommand("UPDATE `attendance` SET `TimeIn` = NOW() WHERE `UserID` = @eID", connect.getConnection);
                updateCommand.Parameters.Add("@eID", MySqlDbType.VarChar).Value = employeeID;

                if (updateCommand.ExecuteNonQuery() == 1)
                {
                    connect.closeConnect();
                    return true;
                }
                else
                {
                    connect.closeConnect();
                    return false;
                }
            }
            else
            {
                reader.Close();

                MySqlCommand insertCommand = new MySqlCommand("INSERT INTO `attendance`(`UserID`, `UserCompleteName`, `TimeIn`) VALUES (@eID, @cm, NOW())", connect.getConnection);
                insertCommand.Parameters.Add("@eID", MySqlDbType.VarChar).Value = employeeID;
                insertCommand.Parameters.Add("@cm", MySqlDbType.VarChar).Value = completeName;

                if (insertCommand.ExecuteNonQuery() == 1)
                {
                    connect.closeConnect();
                    return true;
                }
                else
                {
                    connect.closeConnect();
                    return false;
                }
            }
        }

        public bool TimeOut(string employeeID, string completeName)
        {
            try
            {
                MySqlCommand checkCommand = new MySqlCommand("SELECT * FROM `attendance` WHERE `UserID` = @eID", connect.getConnection);
                checkCommand.Parameters.Add("@eID", MySqlDbType.VarChar).Value = employeeID;

                connect.openConnect();
                MySqlDataReader reader = checkCommand.ExecuteReader();

                if (reader.Read())
                {
                    reader.Close();

                    MySqlCommand selectTimeInCommand = new MySqlCommand("SELECT `TimeIn` FROM `attendance` WHERE `UserID` = @eID", connect.getConnection);
                    selectTimeInCommand.Parameters.Add("@eID", MySqlDbType.VarChar).Value = employeeID;
                    DateTime timeIn = Convert.ToDateTime(selectTimeInCommand.ExecuteScalar());
                    DateTime timeOut = DateTime.Now;
                    TimeSpan totalHours = timeOut - timeIn;

                    MySqlCommand updateCommand = new MySqlCommand("UPDATE `attendance` SET `TimeOut` = NOW(), `TotalHours` = @totalHours WHERE `UserID` = @eID", connect.getConnection);
                    updateCommand.Parameters.Add("@eID", MySqlDbType.VarChar).Value = employeeID;
                    updateCommand.Parameters.Add("@totalHours", MySqlDbType.VarChar).Value = totalHours.TotalHours.ToString("0.00");

                    if (updateCommand.ExecuteNonQuery() == 1)
                    {
                        connect.closeConnect();
                        return true;
                    }
                    else
                    {
                        connect.closeConnect();
                        throw new Exception("Failed to update attendance record.");
                    }
                }
                else
                {
                    reader.Close();
                    connect.closeConnect();
                    throw new Exception("No existing attendance record found for the user.");
                }
            }
            catch (Exception ex)
            {              
                Console.WriteLine("TimeOut failed: " + ex.Message);
                return false;
            }
        }
    }
}