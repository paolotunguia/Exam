using System;
using System.Collections.Generic;
using System.Data;
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
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Time_Logging_Application
{
    public partial class LoginScreen : Window
    {
        UserClass user = new UserClass();

        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=usersdb");

        public LoginScreen()
        {
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(inputUsername.Text) || string.IsNullOrEmpty(inputPassword1.Password))
            {
                MessageBox.Show("Please enter both Username and Password.", "Login Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                string loginUsername = inputUsername.Text;
                string loginPassword = inputPassword1.Password;

                DataTable admintable = user.getList(new MySqlCommand("SELECT * FROM `employee` WHERE `username`= '" + loginUsername + "' AND `password`= '" + loginPassword + "'"));
                DataTable userTable = user.getList(new MySqlCommand("SELECT * FROM `user` WHERE `UserUsername` = '" + loginUsername + "' AND `UserPassword` = '" + loginPassword + "'"));

                if (admintable.Rows.Count > 0)
                {
                    MainWindow main = new MainWindow();
                    this.Hide();
                    main.Show();
                }
                else if (userTable.Rows.Count > 0)
                {
                    string userID = userTable.Rows[0]["UserID"].ToString();
                    string userCompleteName = userTable.Rows[0]["UserCompleteName"].ToString();

                    bool timeInSuccess = user.TimeIn(userID, userCompleteName);

                    if (timeInSuccess)
                    {
                        UserWindow main = new UserWindow(userID, userCompleteName);
                        this.Hide();
                        main.Show();
                    }
                    else
                    {
                        MessageBox.Show("Failed to record Time In. Please try again.", "Time In Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Your username and password do not exist.", "Login Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}
