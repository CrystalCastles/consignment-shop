using ConsignmentShopLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsignmentShopUI
{
    public partial class ConsignmentShop : Form
    {
        private Store store = new Store();

        public ConsignmentShop()
        {
            InitializeComponent();
            SetupData();
        }

        private void SetupData()
        {
            //Vendor demoVendor = new Vendor();
            //demoVendor.FirstName = "Bill";
            //demoVendor.LastName = "Smith";
            //demoVendor.Commission = .5;
            //store.Vendors.Add(demoVendor);

            //demoVendor = new Vendor();
            //demoVendor.FirstName = "Sue";
            //demoVendor.LastName = "Jones";
            //demoVendor.Commission = .5;
            //store.Vendors.Add(demoVendor);

            store.Vendors.Add(new Vendor { FirstName = "Bill", LastName = "Smith" });
            store.Vendors.Add(new Vendor { FirstName = "Sue", LastName = "Jones" });

            store.Items.Add(new Item { Title = "Moby Dick", Description = "A book about a whale", Price = 4.50M, Owner = store.Vendors[0], });
        }

        private void ConsignmentShop_Load(object sender, EventArgs e)
        {

        }

        private void itemsListboxLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
