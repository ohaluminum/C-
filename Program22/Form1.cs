using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Program22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // --------------------- BUILD-IN PROPERTY ------------------------------

            this.studentTableAdapter.Fill(this.testDBDataSet.Student);
        }

        private void studentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.testDBDataSet);
        }

        private void student_idTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void connectionButton_Click(object sender, EventArgs e)
        {
            // ----------------------- BASIC CODE -------------------------------

            //Step 1: sets up a new data connection.
            SqlConnection MainConnection = new SqlConnection();

            //Step 2: populates it with the connection string (get the connection string from Server Explorer => Connected Database => Property).
            MainConnection.ConnectionString = "Data Source=localhost;Initial Catalog=TestDB;Integrated Security=True";

            MessageBox.Show("Connection Open!");

            //Step 3: Line 3 has a SQL Query in it.
            SqlDataAdapter StudentAdapter = new SqlDataAdapter("SELECT * FROM Student", MainConnection);

            //Step 4: builds a new dataset.
            DataTable StudentDataTable = new DataTable();

            //Step 5: open the connection and contact the database.
            MainConnection.Open();

            //Step 6: fill the dataset using the adapter.
            StudentAdapter.Fill(StudentDataTable);

            //Only able to show the first record - need to do some research on it
            first_nameTextBox.Text = (string)StudentDataTable.Rows[0]["first_name"];
            last_nameTextBox.Text = (string)StudentDataTable.Rows[0]["last_name"];
            phoneTextBox.Text = (string)StudentDataTable.Rows[0]["phone"];
            emailTextBox.Text = (string)StudentDataTable.Rows[0]["email"];

            //Step 7: close the database.
            MainConnection.Close();
        }
    }
}
