using System.Data;
using System.Diagnostics;
using WinFormsApp1.Entities;
using WinFormsApp1.Entities.DBWork;
using WinFormsApp1.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        ApplicationDBWork _ApplicationDBWork;
        public Form1()
        {
            InitializeComponent();
            _ApplicationDBWork = new ApplicationDBWork();
            // this.Enabled = false;
            //  LogInFrom logInFrom = new LogInFrom();
            //logInFrom.MdiParent = this;
            //logInFrom.Show();

        }
        public static string? CurrentUserName;

        bool checkIfTheUserIsLogginedOrNot = false;

        

        private void btnLoad_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void salesDashbordToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loginToolStripMenuItem_SelectedChanged(object sender, EventArgs e)
        {
            if (this.Enabled is true)
                loginToolStripMenuItem.Enabled = false;
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            LogInFrom logInFrom = new LogInFrom();
            logInFrom.Show();
            this.Visible = false;

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_VisibleChanged(object sender, EventArgs e)
        {
            this.Text = CurrentUserName;
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //BindingSource bindingSource = new BindingSource();
            //bindingSource.DataSource = _ApplicationDBWork.RetriveData("select * from Customers ");
            //this.dataGridView1.DataSource = bindingSource.DataSource;
            //this.Text = CurrentUserName;
            ManagementCustomers customers = new ManagementCustomers();
            
            customers.Show();
            this.Visible = false;
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (productsToolStripMenuItem.Enabled == true)
                MessageBox.Show("Products is selected");
            if (customersToolStripMenuItem.Enabled == true)
                MessageBox.Show("customers is selected");

            /*if (productsToolStripMenuItem.Selected == true)
            {
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = _ApplicationDBWork.RetriveData("select * from Products ");
                this.dataGridView1.DataSource = bindingSource.DataSource;
                this.Text = CurrentUserName;
            }
            if (customersToolStripMenuItem.Selected == true)
            {
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = _ApplicationDBWork.RetriveData("select * from Customers ");
                this.dataGridView1.DataSource = bindingSource.DataSource;
                this.Text = CurrentUserName;
            }
            if (categoriesToolStripMenuItem.Selected == true)
            {
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = _ApplicationDBWork.RetriveData("select * from categories ");
                this.dataGridView1.DataSource = bindingSource.DataSource;
                this.Text = CurrentUserName;
            }*/
        }





        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BindingSource bindingSource1 = new BindingSource();
            var data = _ApplicationDBWork.RetriveData("select * from Products ");
            bindingSource1.DataSource = data;
            this.dataGridView1.DataSource = bindingSource1.DataSource;
            this.Text = CurrentUserName;
            foreach (DataRow d in data.Rows)
                Debug.WriteLine(d.RowState);
        }

        private void categoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            BindingSource bindingSource2 = new BindingSource();
            var data = _ApplicationDBWork.RetriveData("select * from categories ");
            bindingSource2.DataSource = data;
            this.dataGridView1.DataSource = bindingSource2.DataSource;
            this.Text = CurrentUserName;
            foreach (DataRow d in data.Rows)
                Debug.WriteLine(d.RowState);
        }

        private void suppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BindingSource bindingSource3 = new BindingSource();
            bindingSource3.DataSource = _ApplicationDBWork.RetriveData("select * from suppliers ");
            this.dataGridView1.DataSource = bindingSource3.DataSource;
            this.Text = CurrentUserName;
        }

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BindingSource bindingSource4 = new BindingSource();
            bindingSource4.DataSource = _ApplicationDBWork.RetriveData("select * from employees ");
            this.dataGridView1.DataSource = bindingSource4.DataSource;
            this.Text = CurrentUserName;
        }

      

        ~Form1()
        {
            _ApplicationDBWork._sqlCommand.Dispose();
            _ApplicationDBWork.SqlDataAdapter.Dispose();
        }
    }
}
