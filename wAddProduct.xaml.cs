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

namespace KassaApplicatie
{
    /// <summary>
    /// Interaction logic for wAddProduct.xaml
    /// </summary>
    public partial class wAddProduct : Window
    {
        DatabaseBTRDataContext db = new DatabaseBTRDataContext();
        public wAddProduct()
        {
            InitializeComponent();
            SetData();
        }

        void SetData()
        {
            // Datagrid aan data van tabel products koppelen
            dgProducts.ItemsSource = db.products.ToList();
            dgPriceHistory.ItemsSource = db.pricehistories.ToList();
            dgProductType.ItemsSource = db.producttypes.ToList();
            cbWijzig.ItemsSource = db.products.ToList();
            cbWijzig.DisplayMemberPath = "name";
            cbProducttype.ItemsSource = db.producttypes.ToList();
            cbProducttype.DisplayMemberPath = "type";
        }

        private void btnMainWindow_Click(object sender, RoutedEventArgs e)
        {
            MainWindow Menu = new MainWindow();
            Menu.Show();
            this.Close();
        }

        private void btnOpslaan_Click(object sender, RoutedEventArgs e)
        {
            {
                // Controle of er iemand is geselecteerd in de ComboBox
                if (cbWijzig.SelectedItem != null)
                {
                    // Product ophalen uit ComboBox
                    product myProd = (product)cbWijzig.SelectedItem;
                    myProd.name = txtProductName.Text;

                    producttype prodtype = (producttype)cbWijzig.SelectedItem;

                    pricehistory myPrice = (pricehistory)cbWijzig.SelectedItem;
                    myPrice.price = decimal.Parse(txtProductPrice.Text);
                    // Data van de student laten zien in een MessageBox
                    MessageBox.Show("Product: " + myProd.name + " is succesvol gewijzigd!");
                }
                else
                {
                    //Ingevoerde data ophalen
                    string sProductName = txtProductName.Text;
                    string sProductPrice = txtProductPrice.Text;
                    producttype selPT = (producttype)cbProducttype.SelectedItem;

                    //Product aanmaken en gegevens neerzetten
                    product myProduct = new product();
                    myProduct.name = sProductName;
                    myProduct.producttypeId = selPT.id;
                    pricehistory myPriceHistory = new pricehistory();
                    decimal ProductPrice = decimal.Parse(sProductPrice);
                    myPriceHistory.price = ProductPrice;

                    // Product klaarzetten om op te slaan in de database
                    db.products.InsertOnSubmit(myProduct);
                    // Voer de wijzigingen door op de database
                    db.SubmitChanges();

                    // Data opnieuw ophalen uit de database (het nieuwe product tonen)
                    SetData();

                    // User feedback en velden legen
                    txtProductName.Text = string.Empty;
                    
                    txtProductPrice.Text = string.Empty;

                    MessageBox.Show("Het nieuwe product " + myProduct.name + " is succesvol opgeslagen!");
                    txtProductName.Focus();
                }

            }
        }

        private void btnProducttypeOpslaan_Click(object sender, RoutedEventArgs e)
        {
            //Ingevoerde data ophalen
            string sNieuwProducttype = txtNieuwProducttype.Text;
            producttype prodtype = new producttype();
            prodtype.type = txtNieuwProducttype.Text;

            // Product klaarzetten om op te slaan in de database
            db.producttypes.InsertOnSubmit(prodtype);
            // Voer de wijzigingen door op de database
            db.SubmitChanges();

            // Data opnieuw ophalen uit de database (het nieuwe product tonen)
            SetData();
        }

        private void btnWijzig_Click(object sender, RoutedEventArgs e)
        {
         
            product myProduct = (product)cbWijzig.SelectedItem;
            txtProductName.Text = myProduct.name;
            cbProducttype.SelectedItem = myProduct.producttype;

            string sProductPrice = txtProductPrice.Text;
            pricehistory myPriceHistory = new pricehistory();
            txtProductPrice.Text = myPriceHistory.price.ToString();     
        }

        private void btnDeleteCustomer_Click(object sender, RoutedEventArgs e)
        {
            product p = (product)cbWijzig.SelectedItem;
            db.products.DeleteOnSubmit(p);
            db.SubmitChanges();
            SetData();
            MessageBox.Show($"De klant {p.name} is succesvol verwijderd!");
        }

        
    }
}

