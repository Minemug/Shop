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
            var password = HasloTextBox.Text;
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

  
    }
}
