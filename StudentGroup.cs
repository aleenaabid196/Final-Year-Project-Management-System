using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidProjectUI
{
    public partial class StudentGroup : Form
    {
        public StudentGroup()
        {
            InitializeComponent();
        }

        private void StudentGroup_Load(object sender, EventArgs e)
        {
            /*var con1 = Configuration.getInstance().getConnection();

            string query = "Select Id FROM Lookup WHERE Category = 'STATUS'";
            string query1 = "Select Id FROM Student";
            string query2 = "Select Id FROM [Group]";
            SqlCommand command = new SqlCommand(query, con1);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int statusCode = reader.GetInt32(0);
                statusComboBox.Items.Add(statusCode);
            }
            reader.Close();
            command = new SqlCommand(query1, con1);
            SqlDataReader reader1 = command.ExecuteReader();
            while (reader1.Read())
            {
                int studentCode = reader1.GetInt32(0);
                studentIdcomboBox.Items.Add(studentCode);
            }
            reader1.Close();
            command = new SqlCommand(query2, con1);
            SqlDataReader reader2 = command.ExecuteReader();
            while (reader2.Read())
            {
                int groupCode = reader2.GetInt32(0);
                groupIdComboBox.Items.Add(groupCode);
            }
            reader2.Close();

            *//*StatusBoxValue();
            GroupIdValue();
            StudentIdValue();*//*
*/
            StatusBoxValue();
            GroupBoxValue();
            StudentBoxValue();

        }

        public void GroupBoxValue()
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("Select Id from [Group]", con);
            SqlDataReader reader = cmd.ExecuteReader();
            // Create list to store retrieved data
            List<object> dataList = new List<object>();
            // Loop through reader and add retrieved data to list
            while (reader.Read())
            {
                // Retrieve data from reader
                object data = reader["Id"];
                // Add data to list
                dataList.Add(data);
            }
            // Close reader and connection
            reader.Close();
            con.Close();
            groupIdComboBox.DataSource = dataList;
        }

        public void StudentBoxValue()
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("SELECT Id from Student", con);
            SqlDataReader reader = cmd.ExecuteReader();
            // Create list to store retrieved data
            List<object> dataList = new List<object>();
            // Loop through reader and add retrieved data to list
            while (reader.Read())
            {
                // Retrieve data from reader
                object data = reader["Id"];
                // Add data to list
                dataList.Add(data);
            }
            // Close reader and connection
            reader.Close();
            con.Close();
            studentIdcomboBox.DataSource = dataList;
        }

        public void StatusBoxValue()
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("Select Id,Value from Lookup where Category = 'STATUS'", con);
            SqlDataReader reader = cmd.ExecuteReader();
            // Create list to store retrieved data
            List<object> dataList = new List<object>();
            // Loop through reader and add retrieved data to list
            while (reader.Read())
            {
                // Retrieve data from reader
                object data = reader["Value"];
                // Add data to list
                dataList.Add(data);
            }
            // Close reader and connection
            reader.Close();
            con.Close();
            statusComboBox.DataSource = dataList;
        }
        public int GetStatusId(string Value)
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string sql = "SELECT id FROM Lookup WHERE Value = @Enter And  Category = 'STATUS'";
            SqlCommand command = new SqlCommand(sql, con);
            command.Parameters.AddWithValue("@Enter", Value);
            // execute the query and retrieve the results
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            // retrieve the integer data and convert it to int type
            int intValue = reader.GetInt32(0);
            //int userAge = reader.GetInt32(1);

            // use the retrieved integer data as needed
            // Console.WriteLine("User ID: {0}, User Age: {1}", userId, userAge);


            // close the database connection
            con.Close();
            return intValue;
        }

        /* public void StatusBoxValue()
         {
             var con = Configuration.getInstance().getConnection();
             if (con.State == ConnectionState.Closed)
             {
                 con.Open();
             }
             SqlCommand cmd = new SqlCommand("Select Id,Value from Lookup where Category = 'STATUS'", con);
             SqlDataReader reader = cmd.ExecuteReader();
             // Create list to store retrieved data
             List<object> dataList = new List<object>();
             // Loop through reader and add retrieved data to list
             while (reader.Read())
             {
                 // Retrieve data from reader
                 object data = reader["Value"];
                 // Add data to list
                 dataList.Add(data);
             }
             // Close reader and connection
             reader.Close();
             con.Close();
             statusComboBox.DataSource = dataList;
         }

         public void GroupIdValue()
         {
             var con = Configuration.getInstance().getConnection();
             if (con.State == ConnectionState.Closed)
             {
                 con.Open();
             }
             SqlCommand cmd = new SqlCommand("Select Id FROM [Group]", con);
             SqlDataReader reader = cmd.ExecuteReader();
             // Create list to store retrieved data
             List<object> dataList = new List<object>();
             // Loop through reader and add retrieved data to list
             while (reader.Read())
             {
                 // Retrieve data from reader
                 object data = reader["Id"];
                 // Add data to list
                 dataList.Add(data);
             }
             // Close reader and connection
             reader.Close();
             con.Close();
             groupIdComboBox.DataSource = dataList;
         }

         public void StudentIdValue()
         {
             var con = Configuration.getInstance().getConnection();
             if (con.State == ConnectionState.Closed)
             {
                 con.Open();
             }
             SqlCommand cmd = new SqlCommand("Select Id,RegistrationNo from Student", con);
             SqlDataReader reader = cmd.ExecuteReader();
             // Create list to store retrieved data
             List<object> dataList = new List<object>();
             // Loop through reader and add retrieved data to list
             while (reader.Read())
             {
                 // Retrieve data from reader
                 object data = reader["RegistrationNo"];
                 // Add data to list
                 dataList.Add(data);
             }
             // Close reader and connection
             reader.Close();
             con.Close();
             studentIdcomboBox.DataSource = dataList;
         }
 */

        private bool CheckStudentAlreadyExistInGroup(string Student)
        {
            string connectionString = @"Data Source=(local);Initial Catalog=2021-CS-146;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM GroupStudent WHERE StudentId = @StudentId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@StudentId", Student);
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }
        private int CheckSTudentCountInGroup(int groupId)
        {
            string connectionString = @"Data Source=(local);Initial Catalog=2021-CS-146;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM GroupStudent  WHERE GroupId = @GroupId AND STATUS = 3 ";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@GroupId", groupId);
                int count = (int)command.ExecuteScalar();
                return count;
            }
        }

        private bool insertStudentInGroup(int groupId, int studentId, int status, string assignDate)
        {



            SqlConnection con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            DateTime gco = Convert.ToDateTime(assignDate);
            SqlCommand cmd = new SqlCommand("INSERT INTO GroupStudent (GroupId, StudentId, Status, AssignmentDate) " +
                "VALUES (@GroupId,@StudentId,@Status, @assignDate)", con);
            cmd.Parameters.AddWithValue("@GroupId", groupId);
            cmd.Parameters.AddWithValue("@StudentId", studentId);
            cmd.Parameters.AddWithValue("@Status", status);
            cmd.Parameters.AddWithValue("@assignDate", gco);


            try
            {
                
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
                return false;
            }



        }


       

        private void updateBtn_Click(object sender, EventArgs e)
        {
            int status = GetStatusId(statusComboBox.Text);
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            
                // Get group ID and inactive status
                int groupId = int.Parse(groupIdComboBox.Text);
               
                // Update all group student IDs with inactive status
                SqlCommand cm = new SqlCommand("UPDATE GroupStudent SET Status = @Status WHERE GroupId = @GroupId AND StudentId = @StudentId ", con);
                cm.Parameters.AddWithValue("@GroupId", groupId);
                cm.Parameters.AddWithValue("@StudentId", int.Parse(studentIdcomboBox.Text));
                cm.Parameters.AddWithValue("@Status", status);
                var rowsAffected = cm.ExecuteNonQuery();
                MessageBox.Show(rowsAffected.ToString() + " rows updated.");
           
         
            con.Close();
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("SELECT * FROM GroupStudent WHERE STATUS = 3 ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            studentGroupDGV.DataSource = dt;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {

        }

      


        private void addBtn_Click(object sender, EventArgs e)
        {
            bool value = true;
            int status = GetStatusId(statusComboBox.Text);
            if (statusComboBox.Text == "Active")
            {

            }
            else
            {
                MessageBox.Show("Student is InACtive. You can't add in group");
                value = false;
            }
            if (CheckStudentAlreadyExistInGroup(studentIdcomboBox.Text))
            {
                MessageBox.Show("Student already exists in group");
                return;
            }
            if (CheckSTudentCountInGroup(int.Parse(groupIdComboBox.Text)) == 3)
            {
                MessageBox.Show("Group has already 3 members.");
                return;
            }
           
            if (value)
            {

                insertStudentInGroup(int.Parse(groupIdComboBox.Text), int.Parse(studentIdcomboBox.Text), status, assignmentDatePicker.Text);
                MessageBox.Show("Successfully saved");

            }
        }

        private void studentGroupDGV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            // Get the selected row
            DataGridViewRow row = studentGroupDGV.Rows[e.RowIndex];

            // Populate the text boxes with the data
            assignmentDatePicker.Text = row.Cells["AssignmentDate"].Value.ToString();
            groupIdComboBox.Text = row.Cells["GroupId"].Value.ToString();
            studentIdcomboBox.Text = row.Cells["StudentId"].Value.ToString();
            statusComboBox.Text = row.Cells["Status"].Value.ToString();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            this.Hide();
        }
    }
}
