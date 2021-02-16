using System;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

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
                            loggedin = true;
                }
            }
            if (loggedin)
                MessageBox.Show("zalogowano");
            else 
                MessageBox.Show("zle dane");
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
