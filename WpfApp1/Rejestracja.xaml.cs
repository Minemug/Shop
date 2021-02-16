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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Rejestracja.xaml
    /// </summary>
    public partial class Rejestracja : Window
    {
        public Rejestracja()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var FirstName = FirstNameTextBox.Text;
            var LastName = LastNameTextBox.Text;
            var BornYear = Int32.Parse(BornYearTextBox.Text);
            var Telephone = PhoneTextBox.Text;
            var Email = EmailTextBox.Text;
            var Pass1 = PasswordTextBox.Password.ToString();
            var Pass2 = SecondPasswTextBox.Password.ToString();
            if ((bool)CheckBox.IsChecked)
            {
                if (Pass1 == Pass2)
                {
                    //zarejestruj
                    var db = new ShopEntities();
                    var clients = db.Set<Client>();
                    clients.Add(new Client { FirstName = FirstName, LastName = LastName ,
                        BornYear = BornYear,PhoneNb = Telephone, ClientPassword = Pass1, Mail = Email});
                    db.SaveChanges();
                    MessageBox.Show("Zarejestrowano!");
                }
                else MessageBox.Show("Podane hasła nie są takie same!");
            }
            else MessageBox.Show("Musisz zaakceptować nasze warunki!");

        }

        private void ComeBackClick(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow loginWindow = new MainWindow();
            loginWindow.Show();
        }
    }
}
