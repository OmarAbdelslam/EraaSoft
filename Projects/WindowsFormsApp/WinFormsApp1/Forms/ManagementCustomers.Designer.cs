namespace WinFormsApp1.Forms
{
    partial class ManagementCustomers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            dataGridView1 = new DataGridView();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnSave = new Button();
            btnLoad = new Button();
            menuStrip1 = new MenuStrip();
            toolStripTextBoxById = new ToolStripTextBox();
            toolStripTextBoxByCity = new ToolStripTextBox();
            toolStripTextBoxByCom = new ToolStripTextBox();
            toolStripTextBoxPostal = new ToolStripTextBox();
            toolStripTextBoxRegion = new ToolStripTextBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(dataGridView1, 0, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 31);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.Size = new Size(1133, 523);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.MaximumSize = new Size(1200, 1200);
            dataGridView1.MinimumSize = new Size(178, 363);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1127, 437);
            dataGridView1.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.ActiveCaption;
            flowLayoutPanel1.Controls.Add(btnSave);
            flowLayoutPanel1.Controls.Add(btnLoad);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 446);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1127, 74);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(3, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(380, 66);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(389, 3);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(358, 66);
            btnLoad.TabIndex = 0;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripTextBoxById, toolStripTextBoxByCity, toolStripTextBoxByCom, toolStripTextBoxPostal, toolStripTextBoxRegion });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1133, 31);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripTextBoxById
            // 
            toolStripTextBoxById.Name = "toolStripTextBoxById";
            toolStripTextBoxById.Size = new Size(100, 27);
            toolStripTextBoxById.Text = "By ID";
            // 
            // toolStripTextBoxByCity
            // 
            toolStripTextBoxByCity.Name = "toolStripTextBoxByCity";
            toolStripTextBoxByCity.Size = new Size(100, 27);
            toolStripTextBoxByCity.Text = "By City";
            // 
            // toolStripTextBoxByCom
            // 
            toolStripTextBoxByCom.Name = "toolStripTextBoxByCom";
            toolStripTextBoxByCom.Size = new Size(100, 27);
            toolStripTextBoxByCom.Text = "Company Name";
            // 
            // toolStripTextBoxPostal
            // 
            toolStripTextBoxPostal.Name = "toolStripTextBoxPostal";
            toolStripTextBoxPostal.Size = new Size(100, 27);
            toolStripTextBoxPostal.Text = "Postal Code";
            // 
            // toolStripTextBoxRegion
            // 
            toolStripTextBoxRegion.Name = "toolStripTextBoxRegion";
            toolStripTextBoxRegion.Size = new Size(100, 27);
            toolStripTextBoxRegion.Text = "Region";
            // 
            // ManagementCustomers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1133, 554);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "ManagementCustomers";
            Text = "ManagementCustomers";
            FormClosed += ManagementCustomers_FormClosed;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        protected DataGridView dataGridView1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnSave;
        private Button btnLoad;
        private MenuStrip menuStrip1;
        private ToolStripTextBox toolStripTextBoxById;
        private ToolStripTextBox toolStripTextBoxByCity;
        private ToolStripTextBox toolStripTextBoxByCom;
        private ToolStripTextBox toolStripTextBoxPostal;
        private ToolStripTextBox toolStripTextBoxRegion;
    }
}