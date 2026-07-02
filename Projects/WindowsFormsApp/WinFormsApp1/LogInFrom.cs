using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.BLogic;

namespace WinFormsApp1
{
    public partial class LogInFrom : Form
    {
        BindingSource bindingSource = new BindingSource();

        public LogInFrom()
        {
            InitializeComponent();
            EmployeeLogic logic = new EmployeeLogic();
            bindingSource.DataSource = logic.employees();
        }


        private void LogInFrom_Load(object sender, EventArgs e)
        {
            if (bindingSource.DataSource is DataTable dt)
            {
                if (!dt.Columns.Contains("FullName"))
                {
                    // Computed column combining FirstName and LastName for display
                    dt.Columns.Add("FullName", typeof(string), "FirstName + ' ' + LastName");
                }

                comboBox1.DataSource = bindingSource;
                comboBox1.DisplayMember = "FullName";  // shown text
                comboBox1.ValueMember = "EmployeeID";  // underlying value
                comboBox1.SelectedIndex = -1;          // no selection initially
            }
            else
            {
                // Fallback for other data sources (e.g., list of objects)
                comboBox1.DataSource = bindingSource;
                comboBox1.DisplayMember = "LastName";
                comboBox1.ValueMember = "EmployeeID";
                comboBox1.SelectedIndex = -1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //comboBox1.DisplayMember = "EmployeeID";
            
            if (int.TryParse(textBox2.Text, out int pass))
            {
                if ((int)comboBox1.SelectedValue == pass)
                {
                    this.DialogResult = DialogResult.OK;
                    Form1.CurrentUserName = comboBox1.Text;
                    if(Program.objForm is Form1 form1)
                    {
                        if (form1.Visible is false)
                            form1.Visible = true;
                    }
                    this.Close();
                }
                else
                    MessageBox.Show("The UserName Or Password Is Not True");
            }
        }
    }
}
