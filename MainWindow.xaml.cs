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

namespace KassaApplicatie
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
            wAddCustomer AddCustomer = new wAddCustomer();
            AddCustomer.Show();
            this.Close();
        }

        private void btnProductToevoegen_Click(object sender, RoutedEventArgs e)
        {
            wAddProduct AddProduct = new wAddProduct();
            AddProduct.Show();
            this.Close();
        }

        private void btnBestellingen_Click(object sender, RoutedEventArgs e)
        {
            wOrder wOrder = new wOrder();
            wOrder.Show();
            this.Close();
        }

        private void btnFactuur_Click(object sender, RoutedEventArgs e)
        {
            wFactuur wFactuur = new wFactuur();
            wFactuur.Show();
            this.Close();
        }
    }
}
