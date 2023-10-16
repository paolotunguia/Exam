using MySql.Data.MySqlClient;
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
using System.Windows.Threading;
using System.Runtime.InteropServices;
using System.Windows.Interop;

namespace Time_Logging_Application
{
    public partial class UserWindow : Window
    {
        private UserClass userClass;
        private string loggedInUserID;
        private string loggedInCompleteName;


        public UserWindow(string userID, string completeName)
        {
            InitializeComponent();

            userClass = new UserClass();
            loggedInUserID = userID;
            loggedInCompleteName = completeName;
            LoadUserData();
        }

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pnlControlBar_MouseLeftButton(object sender, MouseButtonEventArgs e)
        {
            WindowInteropHelper helper = new WindowInteropHelper(this);
            SendMessage(helper.Handle, 161, 2, 0);
        }

        private void pnlControlBar_MouseEnter(object sender, MouseEventArgs e)
        {
            this.MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;
        }

        private void LoadUserData()
        {
            string query = "SELECT UserID, UserCompleteName, timeIn, timeOut, totalHours FROM attendance";
            DataTable userList = userClass.getList(new MySqlCommand(query));
            userTable2.ItemsSource = userList.DefaultView;
        }

        private void logoutButton_Click(object sender, RoutedEventArgs e)
        {
            string employeeID = loggedInUserID;
            string completeName = loggedInCompleteName;

            bool success = userClass.TimeOut(employeeID, completeName);

            if (success)
            {
                LoginScreen otherWindow = new LoginScreen();
                otherWindow.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Timeout failed. Please try again.");
            }
        }
    }
}


