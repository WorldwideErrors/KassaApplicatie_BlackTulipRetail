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
    /// Interaction logic for wFactuur.xaml
    /// </summary>
    public partial class wFactuur : Window
    {
        DatabaseBTRDataContext db = new DatabaseBTRDataContext();
        List<product> pr = new List<product>();
        List<int> itemsinorder = new List<int>();
        List<order> orders = new List<order>();
        string AlleProducten = "";
        decimal TotaalBedrag = 0;
        public wFactuur()
        {
            InitializeComponent();
            SetData();
        }

        void SetData()
        {
            cbKlant.ItemsSource = db.customers.ToList();
            cbKlant.DisplayMemberPath = "lastname";
        }

        private void btnMainWindow_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainwindow = new MainWindow();
            mainwindow.Show();
            this.Close();
        }

        private void btnFactuur_Click(object sender, RoutedEventArgs e)
        {
            if (cbKlant != null)
            {
                customer klant = (customer)cbKlant.SelectedItem;

                var begindatum = dtpBeginDatum.SelectedDate;
                var einddatum = dtpEindDatum.SelectedDate;

                List<order> orders = (from o in db.orders
                                      where o.customerId == klant.id &&
                                      (o.date >= begindatum && o.date <= einddatum)
                                      select o).ToList();

                foreach (order o in orders)
                {

                    itemsinorder = (from itemsinorder in db.itemsinorders
                           where o.id == itemsinorder.orderId
                           select itemsinorder.productId).ToList();

                    int p = itemsinorder.Count();

                    var query = (from pricehistory in db.pricehistories
                                 join product in db.products on pricehistory.productId equals product.id
                                 join itemsinorder in db.itemsinorders on product.id equals itemsinorder.productId
                                 join order in db.orders on itemsinorder.id equals order.id
                                 where pricehistory.startdate <= order.date && (pricehistory.enddate >= order.date || pricehistory.enddate == null)
                                 && order.id == o.id
                                 select new
                                 {
                                     product.name,
                                     itemsinorder.amount,
                                     pricehistory.price
                                 });

                    foreach (var obj in query)
                    {
                        decimal totaal = obj.amount * obj.price;
                        decimal totaalBestelling = +totaal;

                        AlleProducten += ($"Order: {o.id} " + Environment.NewLine + "" +
                        $"Datum: {o.date}" + Environment.NewLine +
                        $"Product: {obj.name}" + Environment.NewLine +
                        $"Aantal:{obj.amount}" + Environment.NewLine +
                        $"Prijs per eenheid €{obj.price} " + Environment.NewLine +
                        $"Totaal €{totaal}"
                        + Environment.NewLine +
                        $"Totaal bestelling €{totaalBestelling}" + Environment.NewLine);

                        TotaalBedrag += totaal;
                    }
                }
                MessageBox.Show($"+=+=+=+=+=+=+=+=+= Black Tulip Retail =+=+=+=+=+=+=+=+=+" + Environment.NewLine + Environment.NewLine +

                $"Naam:                       {klant.firstname} {klant.lastname}." + Environment.NewLine +
                $"Stad:                          {klant.city}" + Environment.NewLine +
                $"Telefoonnummer:       {klant.phonenumber}" + Environment.NewLine +
                $"E-mailadres:               {klant.email}" + Environment.NewLine + Environment.NewLine +

                $"Aantal bestellingen:    {klant.orders.Count}" + Environment.NewLine +
                AlleProducten + Environment.NewLine +
                $"Totaal bedrag:            €{TotaalBedrag}" + Environment.NewLine);
            }
        }
    }
}
