using System;
using System.Collections.Generic;
using System.Data;
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
    /// Interaction logic for wOrder.xaml
    /// </summary>
    public partial class wOrder : Window
    {
        DatabaseBTRDataContext db = new DatabaseBTRDataContext();
        List<product> bestelling = new List<product>();
        public wOrder()
        {
            InitializeComponent();
            SetData();
        }
        void SetData()
        {
            // Datagrid aan data van tabel customers koppelen
            dgOrder.ItemsSource = db.orders.ToList();
            cbKlant.ItemsSource = db.customers.ToList();
            cbKlant.DisplayMemberPath = "lastname";
            cbProducttype.ItemsSource = db.producttypes.ToList();
            cbProducttype.DisplayMemberPath = "type";

        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            if (cbProducttype.SelectedItem != null)
            {
                producttype selPT = (producttype)cbProducttype.SelectedItem;
                dgProduct.ItemsSource = selPT.products.ToList();

            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (dgProduct.SelectedItem != null)
            {
                product myProduct = (product)dgProduct.SelectedItem;
                bestelling.Add(myProduct);
                dgOrder.ItemsSource = null;
                dgOrder.ItemsSource = bestelling;

            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            product pro = (product)dgOrder.SelectedItem;
            bestelling.Remove(pro);
        }
        static DataTable ConvertListToDataTable(List<object[]> bestelling)
        {
            DataTable table = new DataTable();

            int colums = 0;
            foreach (var array in bestelling)
            {
                if (bestelling.Count > colums)
                {
                    colums = bestelling.Count;
                }
            }

            for (int i = 0; i < colums; i++)
            {
                table.Columns.Add();
            }

            foreach (var array in bestelling)
            {
                table.Rows.Add(array);
            }

            return table;
        }

        private void btnMainWindow_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainwindow = new MainWindow();
            mainwindow.Show();
            this.Close();
        }

        private void cbKlant_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cbKlant.ItemsSource = db.customers.ToList();
            cbKlant.DisplayMemberPath = "lastname";
        }

        private void btnOrder_Click(object sender, RoutedEventArgs e)
        {
            if (cbKlant.SelectedItem != null)
            {
                customer selCustomer = (customer)cbKlant.SelectedItem;

                order myOrder = new order();
                myOrder.date = DateTime.Now;
                myOrder.customerId = selCustomer.id;

                db.orders.InsertOnSubmit(myOrder);
                db.SubmitChanges();

                List<itemsinorder> myIIOs = CreateIIOs(myOrder.id);

                db.itemsinorders.InsertAllOnSubmit(myIIOs);
                db.SubmitChanges();

                MessageBox.Show("Bestelling is succesvol geplaatst!");
            }
        }

        private List<itemsinorder> CreateIIOs(int iOrderId)
        {
            List<itemsinorder> myIIOs = new List<itemsinorder>();
            foreach (product curProduct in bestelling)
            {
                itemsinorder exIIO = myIIOs.FirstOrDefault(iio => iio.productId.Equals(curProduct.id));

                if (exIIO != null)
                {
                    exIIO.amount++;
                }
                else
                {
                    itemsinorder myIIO = new itemsinorder();
                    myIIO.productId = curProduct.id;
                    myIIO.amount = 1;
                    myIIO.orderId = iOrderId;
                    myIIOs.Add(myIIO);
                }
            }
            return myIIOs;
        }
    }
}
      