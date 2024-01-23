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
                          {VendorName = v.VendorName, 
                           VendorState = v.VendorState, 
                           VendorCity = v.VendorCity
                          }).ToList();
            StringBuilder displayString = new StringBuilder();
            foreach(VendorLocation Vendor in results )
            {
                displayString.AppendLine($"{Vendor.VendorName} is in {Vendor.VendorCity}, {Vendor.VendorState}");
            }
            MessageBox.Show( displayString.ToString() );
        }
    }

    class VendorLocation
    {
        public string VendorName { get; set; } 
        public string VendorState { get; set;}
        public string VendorCity { get; set;}
    }
}
