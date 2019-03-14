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
    /// Interaction logic for wAddCustomer.xaml
    /// </summary>
    public partial class wAddCustomer : Window
    {
        DatabaseBTRDataContext db = new DatabaseBTRDataContext();
        public wAddCustomer()
        {
            InitializeComponent();
            SetData();
        }
        void SetData()
        {
            // Datagrid aan data van tabel customers koppelen
            dgCustomers.ItemsSource = db.customers.ToList();
            cbWijzigKlant.ItemsSource = db.customers.ToList();
            cbWijzigKlant.DisplayMemberPath = "lastname";
        }

        private void btnOpslaan_Click(object sender, RoutedEventArgs e)
        {
            {
                if (cbWijzigKlant.SelectedItem != null)
                {
                    customer c = (customer)cbWijzigKlant.SelectedItem;

                    c.firstname = txtVoornaam.Text;
                    c.lastname = txtAchternaam.Text;
                    c.city = txtWoonplaats.Text;
                    c.phonenumber = txtTelefoon.Text;
                    c.email = txtEmail.Text;
                    MessageBox.Show("De nieuwe klant " + c.firstname + " " + c.lastname + " is succesvol gewijzigd!");
                }
                else
                {
                    //Ingevoerde data ophalen
                    string sVoornaam = txtVoornaam.Text;
                    string sAchternaam = txtAchternaam.Text;
                    string sWoonplaats = txtWoonplaats.Text;
                    string sTelefoon = txtTelefoon.Text;
                    string sEmail = txtEmail.Text;

                    //Klant aanmaken en gegevens neerzetten
                    customer myCustomer = new customer();
                    myCustomer.firstname = sVoornaam;
                    myCustomer.lastname = sAchternaam;
                    myCustomer.city = sWoonplaats;
                    myCustomer.phonenumber = sTelefoon;
                    myCustomer.email = sEmail;

                    // Student klaarzetten om op te slaan in de database
                    db.customers.InsertOnSubmit(myCustomer);
                    MessageBox.Show("De nieuwe klant " + myCustomer.firstname + " " + myCustomer.lastname + " is succesvol opgeslagen!");
                }
                // Voer de wijzigingen door op de database
                db.SubmitChanges();

                // Data opnieuw ophalen uit de database (de nieuwe student tonen)
                SetData();

                // User feedback en velden legen
                txtVoornaam.Text = string.Empty;
                txtAchternaam.Text = string.Empty;
                txtWoonplaats.Text = string.Empty;
                txtTelefoon.Text = string.Empty;
                txtEmail.Text = string.Empty;
                txtVoornaam.Focus();

            }
        }

        private void btnMainWindow_Click(object sender, RoutedEventArgs e)
        {
            MainWindow Menu = new MainWindow();
            Menu.Show();
            this.Close();
        }

        private void btnWijzigen_Click(object sender, RoutedEventArgs e)
        {
            // Controle of er iemand is geselecteerd in de ComboBox
            if (cbWijzigKlant.SelectedItem != null)
            {
                // Student ophalen uit ComboBox
                customer myCustomer = (customer)cbWijzigKlant.SelectedItem;

                // Data van de student laten zien in een MessageBox
                MessageBox.Show("Klant: " + myCustomer.firstname + " " + myCustomer.lastname);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            customer myCustomer = (customer)cbWijzigKlant.SelectedItem;
            txtVoornaam.Text = myCustomer.firstname;
            txtAchternaam.Text = myCustomer.lastname;
            txtWoonplaats.Text = myCustomer.city;
            txtTelefoon.Text = myCustomer.phonenumber;
            txtEmail.Text = myCustomer.email;
        }

        private void btnDeleteCustomer_Click(object sender, RoutedEventArgs e)
        {
            if (cbWijzigKlant.SelectedItem != null)
            {
                customer c = (customer)cbWijzigKlant.SelectedItem;
                db.customers.DeleteOnSubmit(c);
                db.SubmitChanges();
                SetData();
                MessageBox.Show($"De klant {c.firstname} {c.lastname} is succesvol verwijderd!");
            }
        }
    }
}
