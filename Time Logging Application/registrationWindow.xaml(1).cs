using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace Time_Logging_Application
{
    public partial class registrationWindow : Window
    {
        UserClass user = new UserClass();
        public registrationWindow()
        {
            InitializeComponent();
        }

        private void button_addNewUserReg_Click(object sender, RoutedEventArgs e)
        {
            string employeeID =  textBox_employeeID.Text;
            string cname = textBox_completeName.Text;
            string username = textBox_username.Text;
            string password = passwordd.Password;
            string confirmPassword = confirmpassword.Password;

            if (confirmPassword != password)
            {
                MessageBox.Show("The password and confirm password do not match. Please try again.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            else if (employeeID.Length != 5)
            {
                MessageBox.Show("EmployeeID must be equal to 5 characters.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            else if (verify())
            {
                try
                {
                    if (user.insertUser(employeeID, cname, username, password))
                    {
                        MessageBox.Show("New User Added", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                } 
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Add User", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Incomplete details", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            bool verify()
            {
                if (string.IsNullOrWhiteSpace(employeeID) || string.IsNullOrWhiteSpace(cname) || string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(confirmPassword))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
        private void button_registerBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow otherWindow = new MainWindow();
            otherWindow.Show();
            this.Close();
        }
    }
}