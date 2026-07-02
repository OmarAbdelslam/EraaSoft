using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.BLogic;

namespace WinFormsApp1.Forms
{
    public partial class ManagementCustomers : Form
    {
        private CustomerBLogic customerBLogic;
        public ManagementCustomers()
        {
            InitializeComponent();
            customerBLogic = new CustomerBLogic();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (toolStripTextBoxById.Text != "By ID" && toolStripTextBoxById.Text != string.Empty)
            {
                dataGridView1.DataSource = customerBLogic.Retriveall($"Select * from Customers Where CustomerID = '{toolStripTextBoxById.Text}'");
                
                return;
            }

            else if (toolStripTextBoxByCity.Text != "By City")
            {
                DataTable table = customerBLogic.Retriveall($"Select * from Customers Where City = '{toolStripTextBoxByCity.Text}'");
                if (table.Rows.Count > 0)
                {
                    dataGridView1.DataSource = table;
                    return;
                }
                MessageBox.Show("There aren't any Value to Search it\n" +
                    "Fill the text Box And Try Search ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            else if (toolStripTextBoxByCom.Text != "Company Name")
            {
                dataGridView1.DataSource = customerBLogic.Retriveall($"Select * from Customers Where CompanyName = '{toolStripTextBoxByCom.Text}'");
                return;
            }

            else if (toolStripTextBoxRegion.Text != "Region")
            {
                dataGridView1.DataSource = customerBLogic.Retriveall($"Select * from Customers Where Region = '{toolStripTextBoxRegion.Text}'");
                return;
            }

            else if (toolStripTextBoxPostal.Text != "Postal Code")
            {
                dataGridView1.DataSource = customerBLogic.Retriveall($"Select * from Customers Where PostalCode = '{toolStripTextBoxPostal.Text}'");
                return;
            }

            dataGridView1.DataSource = customerBLogic.Retriveall("Select * from Customers");
        }

        private void ManagementCustomers_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Program.objForm is Form1 form1)
            {
                if (form1.Visible == false)
                    form1.Visible = true;
            }
        }
    }
}
