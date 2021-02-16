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
        ShopEntities db = new ShopEntities();
        
        public LoggedIn()
        {
            InitializeComponent();
        }
        
        private void AddToBasketButton_Click(object sender, RoutedEventArgs e)
        {
            var quantity = Convert.ToInt32(QuantityTextBox.Text);
            var index = ComboBox.SelectedIndex + 1;//W sqlu index zaczyna sie od 1
            int ClientID = Convert.ToInt32(Passdata.Text);
            var basket = db.Set<Basket>();
            if(quantity>0 && ComboBox.IsSelectionBoxHighlighted)
            {
                basket.Add(new Basket {ProductID = index, Quantity = quantity, ClientID = ClientID});
            }
        }

        private void ComboBox_Initialized(object sender, EventArgs e)
        {
            var products = db.Set<Products>();
            foreach (var item in products)
            {
                ComboBox.Items.Add(item.ProductName);
            }
        }

        private void DataGrid_Initialized(object sender, EventArgs e)
        {
            var basket = db.Set<Basket>();
            DataGrid.ItemsSource = basket.Local;
        }
    }
}
