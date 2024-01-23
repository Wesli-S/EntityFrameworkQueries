namespace EntityFrameworkQueries
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSelectAllVendors = new Button();
            btnAllCAVendors = new Button();
            btnSelectSpecificColumns = new Button();
            btnMiscQueries = new Button();
            btnVendorsAndInvoices = new Button();
            SuspendLayout();
            // 
            // btnSelectAllVendors
            // 
            btnSelectAllVendors.Location = new Point(33, 25);
            btnSelectAllVendors.Name = "btnSelectAllVendors";
            btnSelectAllVendors.Size = new Size(145, 32);
            btnSelectAllVendors.TabIndex = 0;
            btnSelectAllVendors.Text = "Select * FROM Vendors";
            btnSelectAllVendors.UseVisualStyleBackColor = true;
            btnSelectAllVendors.Click += btnSelectAllVendors_Click;
            // 
            // btnAllCAVendors
            // 
            btnAllCAVendors.Location = new Point(33, 74);
            btnAllCAVendors.Name = "btnAllCAVendors";
            btnAllCAVendors.Size = new Size(145, 80);
            btnAllCAVendors.TabIndex = 1;
            btnAllCAVendors.Text = "Select * FROM Vendors WHERE VendorState = 'CA' ORDER BY VendorName ASC";
            btnAllCAVendors.UseVisualStyleBackColor = true;
            btnAllCAVendors.Click += btnAllCAVendors_Click;
            // 
            // btnSelectSpecificColumns
            // 
            btnSelectSpecificColumns.Location = new Point(33, 172);
            btnSelectSpecificColumns.Name = "btnSelectSpecificColumns";
            btnSelectSpecificColumns.Size = new Size(145, 71);
            btnSelectSpecificColumns.TabIndex = 2;
            btnSelectSpecificColumns.Text = "SELECT VendorName, VendorCity, VendorState FROM Vendors";
            btnSelectSpecificColumns.UseVisualStyleBackColor = true;
            btnSelectSpecificColumns.Click += btnSelectSpecificColumns_Click;
            // 
            // btnMiscQueries
            // 
            btnMiscQueries.Location = new Point(33, 258);
            btnMiscQueries.Name = "btnMiscQueries";
            btnMiscQueries.Size = new Size(145, 35);
            btnMiscQueries.TabIndex = 3;
            btnMiscQueries.Text = "Misc. Queries";
            btnMiscQueries.UseVisualStyleBackColor = true;
            btnMiscQueries.Click += btnMiscQueries_Click;
            // 
            // btnVendorsAndInvoices
            // 
            btnVendorsAndInvoices.Location = new Point(33, 311);
            btnVendorsAndInvoices.Name = "btnVendorsAndInvoices";
            btnVendorsAndInvoices.Size = new Size(145, 61);
            btnVendorsAndInvoices.TabIndex = 4;
            btnVendorsAndInvoices.Text = "Select all Vendors and their Invoices";
            btnVendorsAndInvoices.UseVisualStyleBackColor = true;
            btnVendorsAndInvoices.Click += btnVendorsAndInvoices_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(219, 419);
            Controls.Add(btnVendorsAndInvoices);
            Controls.Add(btnMiscQueries);
            Controls.Add(btnSelectSpecificColumns);
            Controls.Add(btnAllCAVendors);
            Controls.Add(btnSelectAllVendors);
            Name = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnSelectAllVendors;
        private Button btnAllCAVendors;
        private Button btnSelectSpecificColumns;
        private Button btnMiscQueries;
        private Button btnVendorsAndInvoices;
    }
}
