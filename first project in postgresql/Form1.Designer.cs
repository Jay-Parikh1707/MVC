
namespace first_project_in_postgresql
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.keywordtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.firsttextBox = new System.Windows.Forms.TextBox();
            this.lastnametextBox = new System.Windows.Forms.TextBox();
            this.EmpNotextBox = new System.Windows.Forms.TextBox();
            this.ContactInfotextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.updatebutton = new System.Windows.Forms.Button();
            this.Deletebutton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.EmailtextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.locationcomboBox = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.keywordtextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-18, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(816, 73);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(681, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Search button";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // keywordtextBox
            // 
            this.keywordtextBox.Location = new System.Drawing.Point(316, 35);
            this.keywordtextBox.Name = "keywordtextBox";
            this.keywordtextBox.Size = new System.Drawing.Size(314, 20);
            this.keywordtextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "FIRST NAME:-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "LAST NAME:-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "EMP NO:-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "CONTACT INFO:-";
            // 
            // firsttextBox
            // 
            this.firsttextBox.AccessibleName = "firstname";
            this.firsttextBox.Location = new System.Drawing.Point(181, 102);
            this.firsttextBox.Name = "firsttextBox";
            this.firsttextBox.Size = new System.Drawing.Size(133, 20);
            this.firsttextBox.TabIndex = 5;
            this.firsttextBox.TextChanged += new System.EventHandler(this.firsttextBox_TextChanged);
            // 
            // lastnametextBox
            // 
            this.lastnametextBox.Location = new System.Drawing.Point(181, 155);
            this.lastnametextBox.Name = "lastnametextBox";
            this.lastnametextBox.Size = new System.Drawing.Size(133, 20);
            this.lastnametextBox.TabIndex = 6;
            // 
            // EmpNotextBox
            // 
            this.EmpNotextBox.Location = new System.Drawing.Point(181, 218);
            this.EmpNotextBox.Name = "EmpNotextBox";
            this.EmpNotextBox.Size = new System.Drawing.Size(133, 20);
            this.EmpNotextBox.TabIndex = 7;
            // 
            // ContactInfotextBox
            // 
            this.ContactInfotextBox.Location = new System.Drawing.Point(181, 274);
            this.ContactInfotextBox.Name = "ContactInfotextBox";
            this.ContactInfotextBox.Size = new System.Drawing.Size(133, 20);
            this.ContactInfotextBox.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.AccessibleName = "INSERTBUTTON";
            this.button2.Location = new System.Drawing.Point(58, 444);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 81);
            this.button2.TabIndex = 9;
            this.button2.Text = "INSERT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // updatebutton
            // 
            this.updatebutton.AccessibleName = "UPDATEBUTTON";
            this.updatebutton.Location = new System.Drawing.Point(181, 444);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(75, 81);
            this.updatebutton.TabIndex = 10;
            this.updatebutton.Text = "UPDATE";
            this.updatebutton.UseVisualStyleBackColor = true;
            this.updatebutton.Click += new System.EventHandler(this.updatebutton_Click);
            // 
            // Deletebutton
            // 
            this.Deletebutton.AccessibleName = "DELETE BUTTON";
            this.Deletebutton.Location = new System.Drawing.Point(298, 444);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(75, 81);
            this.Deletebutton.TabIndex = 11;
            this.Deletebutton.Text = "DELETE";
            this.Deletebutton.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "EMAIL:-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(78, 392);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "LOCATION:-";
            // 
            // EmailtextBox
            // 
            this.EmailtextBox.Location = new System.Drawing.Point(181, 332);
            this.EmailtextBox.Name = "EmailtextBox";
            this.EmailtextBox.Size = new System.Drawing.Size(133, 20);
            this.EmailtextBox.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(407, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(381, 412);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 515);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 17;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Red;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(109, 17);
            this.toolStripStatusLabel1.Text = "Number of rows( s)";
            // 
            // locationcomboBox
            // 
            this.locationcomboBox.FormattingEnabled = true;
            this.locationcomboBox.Items.AddRange(new object[] {
            "BIA",
            "GURGAON",
            "MIA ",
            "PIA",
            "SANAND",
            "SOLAN"});
            this.locationcomboBox.Location = new System.Drawing.Point(181, 389);
            this.locationcomboBox.Name = "locationcomboBox";
            this.locationcomboBox.Size = new System.Drawing.Size(133, 21);
            this.locationcomboBox.Sorted = true;
            this.locationcomboBox.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 537);
            this.Controls.Add(this.locationcomboBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.EmailtextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Deletebutton);
            this.Controls.Add(this.updatebutton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ContactInfotextBox);
            this.Controls.Add(this.EmpNotextBox);
            this.Controls.Add(this.lastnametextBox);
            this.Controls.Add(this.firsttextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox keywordtextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox firsttextBox;
        private System.Windows.Forms.TextBox lastnametextBox;
        private System.Windows.Forms.TextBox EmpNotextBox;
        private System.Windows.Forms.TextBox ContactInfotextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button updatebutton;
        private System.Windows.Forms.Button Deletebutton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox EmailtextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ComboBox locationcomboBox;
    }
}

