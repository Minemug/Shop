using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.Entity;


namespace WpfApp1
{
    /// <summary>
    /// Window you get after login
    /// </summary>
    public partial class LoggedIn : Window
    {
        ShopEntities db = new ShopEntities();
        CollectionViewSource basketViewSource;
        public LoggedIn()
        {
            InitializeComponent();
            basketViewSource = ((CollectionViewSource)(FindResource("basketViewSource")));
            DataContext = this;
        }
        
        private void AddToBasketButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var quantity = Convert.ToInt32(QuantityTextBox.Text);
                var index = ComboBox.SelectedIndex + 1;//W sqlu index zaczyna sie od 1
                int ClientID = Convert.ToInt32(Passdata.Text);
                var basket = db.Set<Basket>();
                if(quantity>0)
                {
                    basket.Add(new Basket {ProductID = index, Quantity = quantity, ClientID = ClientID});
                    db.SaveChanges();
                    MessageBox.Show("Dodano produkt");
                }

            }
            catch (System.FormatException)
            {
                MessageBox.Show("Podano nieprawidłowy format wartości ilosci lub nie podano wgle");
            }
            ComboBoxDelete.Items.Clear();
            FillDeleteCombobox();
        }

        private void ComboBox_Initialized(object sender, EventArgs e)
        {
            var products = db.Set<Products>();
            foreach (var item in products)
            {
                ComboBox.Items.Add(item.ProductName);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow loginWindow = new MainWindow();
            loginWindow.Show();
            this.Close();
        }

        private void LoggedIn1_Loaded(object sender, RoutedEventArgs e)
        {
            db.Basket.Load();
            basketViewSource.Source = db.Basket.Local;
        }

        private void DeleteFromBasketButton_Click(object sender, RoutedEventArgs e)
        {

            var index = ComboBoxDelete.SelectedIndex;
            var ord = (from o in db.Basket.Local
                       where o.BasketID == indexlist[index]
                       select o).FirstOrDefault();
            try
            {
                db.Basket.Remove(ord);
            }
            catch (Exception)
            {
                MessageBox.Show("upsi");
            }
            db.SaveChanges();
            ComboBoxDelete.Items.Clear();
            FillDeleteCombobox();
        }

        int[] indexlist = new int[50];
        private void ComboBoxDelete_Loaded(object sender, RoutedEventArgs e)
        {
            FillDeleteCombobox();
        }
        private void FillDeleteCombobox()
        {
            indexlist = new int[50];
            int i = 0;
            foreach (var item in db.Basket)
            {
                if (item.ClientID == Convert.ToInt32(Passdata.Text))
                {
                    foreach (var prod in db.Products)
                    {
                        if (item.ProductID == prod.ProductID)
                        {
                            ComboBoxDelete.Items.Add($"{prod.ProductName} ilosc {item.Quantity}");
                            indexlist[i] = item.BasketID;
                            i++;
                        }
                    }
                }
            }
        }
    }
}
