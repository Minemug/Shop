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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for LoggedIn.xaml
    /// </summary>
    public partial class LoggedIn : Window
    {
        public LoggedIn()
        {
            InitializeComponent();
        }

        private void AddToBasketButton_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void ComboBox_Initialized(object sender, EventArgs e)
        {
            ComboBox.Items.Add("X");
            ComboBox.Items.Add("Y");
        }
    }
}
