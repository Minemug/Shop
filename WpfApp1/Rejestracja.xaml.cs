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
            var BornYear = Int32.TryParse(BornYearTextBox.Text, out int deafult);
            var Telephone = PhoneTextBox.Text;
            var Pass1 = PasswordTextBox.Password.ToString();
            var Pass2 = SecondPasswTextBox.Password.ToString();
            if ((bool)CheckBox.IsChecked)
            {
                if (Pass1 == Pass2)
                {
                    //zarejestruj
                }
                else MessageBox.Show("Podane hasła nie są takie same!");
            }
            else MessageBox.Show("Musisz zaakceptować nasze warunki!");

        }
    }
}
