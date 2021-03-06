﻿using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.Entity;

namespace WpfApp1
{
    /// <summary>
    /// Login window
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public int loggerID;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var mail = MailTextBox.Text;
            var password = PasswordBox.Password.ToString();
            var db = new ShopEntities();
            IQueryable<Client> ClientsTable = db.Client;
            bool loggedin = false;
            foreach (var item in ClientsTable)
            {
                if(mail == item.Mail)
                {
                    if (password == item.ClientPassword)
                    {
                        loggedin = true;
                        loggerID = item.ClientID;
                    }
                    else MessageBox.Show("Wpisałeś niepoprawne hasło");
                }
            }
            if (loggedin)
            {
                LoggedIn loggedInWindow = new LoggedIn();
                loggedInWindow.Passdata.Text = loggerID.ToString();
                loggedInWindow.Show();
                this.Close();
            }
                
        }

        private void RejestracjaLabel_MouseEnter(object sender, MouseEventArgs e)
        {
            RejestracjaLabel.Foreground = Brushes.LimeGreen;
        }

        private void RejestracjaLabel_MouseLeave(object sender, MouseEventArgs e)
        {

            RejestracjaLabel.Foreground = Brushes.LightGray;
        }

        private void RejestracjaLabel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Hide();
            Rejestracja secondWindow = new Rejestracja();
            secondWindow.Show();
        }
    }
}
