using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;


namespace first_project_in_postgresql
{
    public partial class Form1 : Form
    {
        private String id = " ";
        private int intRow = 0;
        public Form1()
        {
            InitializeComponent();
            resetMe();
        }

        private void resetMe()
        {
            this.id = string.Empty;
            firsttextBox.Text = "";
            lastnametextBox.Text = "";
            EmpNotextBox.Text = "";
            ContactInfotextBox.Text = "";
            EmailtextBox.Text = "";
            if (locationcomboBox.Items.Count > 0)
            {
                locationcomboBox.SelectedIndex = 0;
            }
            updatebutton.Text = "Update()";
            Deletebutton.Text = "Delete()";
            keywordtextBox.Clear();

            if (keywordtextBox.CanSelect)
            {
                keywordtextBox.Select();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadData("");
        }

        private void loadData(string keyword)
        {
            employee.sql = "SELECT firstname,lastname, CONCAT(firstname,'',lastname)as fullname ,emp_no,contact_info,email,location from emp_details";

            string strkeyword = string.Format("%{0}%", keyword);
            employee.cmd = new NpgsqlCommand(employee.sql, employee.con);
            employee.cmd.Parameters.Clear();
            employee.cmd.Parameters.AddWithValue("Keyword", strkeyword);
            DataTable dt = employee.emp_details(employee.cmd);

            if (dt.Rows.Count > 0)
            {
                intRow = Convert.ToInt32(dt.Rows.Count.ToString());
            }
            else
            {
                intRow = 0;
            }
            toolStripStatusLabel1.Text = "Number of Row(s):" + intRow.ToString();

            DataGridView d1 = dataGridView1;
            d1.MultiSelect = false;
            d1.AutoGenerateColumns = true;
            d1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            d1.DataSource = dt;
            d1.Columns[0].HeaderText = "firstname";
            d1.Columns[1].HeaderText = "lastname";
            d1.Columns[2].HeaderText = "fullname";
            d1.Columns[3].HeaderText = "emp_no";
            d1.Columns[4].HeaderText = "contact_info";
            d1.Columns[5].HeaderText = "email";
            d1.Columns[6].HeaderText = "location";

            d1.Columns[0].Width = 90;
            d1.Columns[1].Width = 90;
            d1.Columns[2].Width = 150;
            d1.Columns[3].Width = 85;
            d1.Columns[4].Width = 105;
            d1.Columns[5].Width = 80;





        }
        private void execute(string mySQL, string param)
        {
            employee.cmd = new NpgsqlCommand(mySQL, employee.con);
            addParameters(param);
            employee.emp_details(employee.cmd);

        }

        private void addParameters(string str)
        {
            employee.cmd.Parameters.Clear();
            employee.cmd.Parameters.AddWithValue("firstname", firsttextBox.Text.Trim());
            employee.cmd.Parameters.AddWithValue("lastname", lastnametextBox.Text.Trim());
            employee.cmd.Parameters.AddWithValue("emp_no", Convert.ToInt32(EmpNotextBox.Text));
            employee.cmd.Parameters.AddWithValue("contact_info", Convert.ToInt64(ContactInfotextBox.Text.Trim()));
            employee.cmd.Parameters.AddWithValue("email", EmailtextBox.Text.Trim());
            employee.cmd.Parameters.AddWithValue("location", locationcomboBox.SelectedItem.ToString());

            if (str == "Update" || str == "Delete" && !string.IsNullOrEmpty(this.id))
            {
                employee.cmd.Parameters.AddWithValue("id", this.id);

            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(firsttextBox.Text.Trim()) || string.IsNullOrEmpty(lastnametextBox.Text.Trim()))
            {
                MessageBox.Show("Please input first name and last name.", "Insert Data",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;

            }
            employee.sql = "insert into emp_details(firstname,lastname,emp_no,contact_info,email,location) " +
                "VALUES(@firstname,@lastname,@emp_no,@contact_info,@email,@location)";
            execute(employee.sql, "Insert");

            MessageBox.Show("The record has been saved", "Insert Data", MessageBoxButtons.OK, MessageBoxIcon.Information);

            loadData("");
            resetMe();
        }


        private void updatebutton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                return;
            }
            if (string.IsNullOrEmpty(this.id))
            {
                MessageBox.Show("Please select an item from the list", "Update Data",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }
            if (string.IsNullOrEmpty(firsttextBox.Text.Trim()) || string.IsNullOrEmpty(lastnametextBox.Text.Trim()))
            {
                MessageBox.Show("Please input first name and last name.", "Insert Data",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }
            employee.sql = "UPDATE emp_details SET firstName=@firstname,lastname=@lastname,emp_no=@emp_no,contact_info=@contact_info,email=@email,location=@location where emp_no=@emp_no::integer ";
            execute(employee.sql, "Update");

            MessageBox.Show("The record has been Updated", "Insert Data", MessageBoxButtons.OK, MessageBoxIcon.Information);

            loadData("");
            resetMe();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridView dgv = dataGridView1;
                this.id = Convert.ToString(dgv.CurrentRow.Cells[0].Value);
                updatebutton.Text = "Update(" + this.id + ")";
                Deletebutton.Text = "Delete(" + this.id + ")";

                firsttextBox.Text = Convert.ToString(dgv.CurrentRow.Cells[1].Value);
                lastnametextBox.Text = Convert.ToString(dgv.CurrentRow.Cells[2].Value);
                EmpNotextBox.Text = Convert.ToString(dgv.CurrentRow.Cells[3].Value);
                ContactInfotextBox.Text = Convert.ToString(dgv.CurrentRow.Cells[4].Value);
                EmailtextBox.Text = Convert.ToString(dgv.CurrentRow.Cells[5].Value);
                locationcomboBox.SelectedItem = Convert.ToString(dgv.CurrentRow.Cells[6].Value);


            }
        }

      /*  private void Deletebutton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                return;
            }
            if (string.IsNullOrEmpty(this.id))
            {
                MessageBox.Show("Please select an item from the list", "Delete Data",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }
            if(MessageBox.Show("Do you want permanently delete the select record?","Delete data"))
            {

            }
            employee.sql = "UPDATE emp_details SET firstName=@firstname,lastname=@lastname,emp_no=@emp_no,contact_info=@contact_info,email=@email,location=@location where emp_no=@emp_no::integer ";
            execute(employee.sql, "Delete");

            MessageBox.Show("The record has been Deleted", "Delete Data", MessageBoxButtons.OK, MessageBoxIcon.Information);

            loadData("");
            resetMe();

        }*/

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void firsttextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
