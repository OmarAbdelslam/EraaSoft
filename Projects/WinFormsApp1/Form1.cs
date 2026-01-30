using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowHelp = true;
            openFileDialog1.FileName = "Select your file";
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk_1(object sender, System.ComponentModel.CancelEventArgs e)
        {
            textBox2.Text = openFileDialog1.SafeFileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you want to save changes??","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if(result == DialogResult.Yes)
            {
                if (textBox2.TextLength < 1) return;
                string newpath = Path.ChangeExtension(textBox2.Text, textBox1.Text);
                File.Move(textBox2.Text, newpath);
            }
        }
    }
}
