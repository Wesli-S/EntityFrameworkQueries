using Microsoft.EntityFrameworkCore;
using System.Text;

namespace EntityFrameworkQueries
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectAllVendors_Click(object sender, EventArgs e)
        {
            using ApContext dbContext = new();

            //You can use either of these LINQ's to create a list

            //LINQ (Language Integrated Query) method syntax
            List<Vendor> vendorList = dbContext.Vendors.ToList();

            //LINQ query syntax
            List<Vendor> vendorList2 = (from v in dbContext.Vendors
                                        select v).ToList();
        }

        private void btnAllCAVendors_Click(object sender, EventArgs e)
        {
            using ApContext dbContext = new();

            List<Vendor> vendorList = dbContext.Vendors
                                        .Where(v => v.VendorState == "CA")
                                        .OrderBy(vendorList => vendorList.VendorName)
                                        .ToList();

            List<Vendor> vendorList2 = (from v in dbContext.Vendors
                                        where v.VendorState == "CA"
                                        orderby v.VendorName
                                        select v).ToList();
        }

        private void btnSelectSpecificColumns_Click(object sender, EventArgs e)
        {
            ApContext dbContext = new();

            List<VendorLocation> results = (from v in dbContext.Vendors
                                            select new VendorLocation
                                            {
                                                VendorName = v.VendorName,
                                                VendorState = v.VendorState,
                                                VendorCity = v.VendorCity
                                            }).ToList();
            StringBuilder displayString = new StringBuilder();
            foreach (VendorLocation Vendor in results)
            {
                displayString.AppendLine($"{Vendor.VendorName} is in {Vendor.VendorCity}, {Vendor.VendorState}");
            }
            MessageBox.Show(displayString.ToString());
        }

        private void btnMiscQueries_Click(object sender, EventArgs e)
        {
            ApContext dbContext = new ApContext();

            //Check if any Vendors exist in Washington State
            bool doesExist = (from v in dbContext.Vendors
                              where v.VendorState == "WA"
                              select v).Any();


            //Get number of Invoices
            int invoiceCount = (from invoice in dbContext.Invoices
                                select invoice).Count();

            //Select a single vendor
            Vendor? singleVendor = (from v in dbContext.Vendors
                                    where v.VendorName == "IBM"
                                    select v).SingleOrDefault();
            if (singleVendor != null)
            {
                //do something with the vendor object
            }
        }

        private void btnVendorsAndInvoices_Click(object sender, EventArgs e)
        {
            ApContext dbContext = new();

            //Vendors LEFT join Invoices
            List<Vendor> allVendors = dbContext.Vendors.Include(v => v.Invoices).ToList();

            //Unfinished code: This pulls a Vendor object for each individual invoice, vendors
            //are also pulled back if they have no invoices
            /*List<Vendor> allVendors = (from v in dbContext.Vendors
                                      join inv in dbContext.Invoices
                                        on v.VendorId equals inv.VendorId into grouping
                                      from inv in grouping.DefaultIfEmpty()
                                      select v).ToList();*/

            StringBuilder results = new();
            foreach (Vendor v in allVendors)
            {
                results.Append(v.VendorName);
                foreach (Invoice inv in v.Invoices)
                {
                    results.Append(", ");
                    results.Append(inv.InvoiceNumber);
                }
                results.AppendLine();
            }
            MessageBox.Show(results.ToString());
        }
    }

    class VendorLocation
    {
        public string VendorName { get; set; } 
        public string VendorState { get; set;}
        public string VendorCity { get; set;}
    }
}
