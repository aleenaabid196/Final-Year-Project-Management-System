﻿using System;
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
    public partial class ManageStudentForm : Form
    {
        int rowIndex;
        public ManageStudentForm()

        {
          
            InitializeComponent();
            
           
        }
       
       

        private void ManageStudentsForm_Load(object sender, EventArgs e)
        {

            GenderBoxValue();

        }

        public int GetGender(string Value)
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string sql = "SELECT id FROM Lookup WHERE Value = @Enter And  Category = 'GENDER'";
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


        public void GenderBoxValue()
         {
             var con = Configuration.getInstance().getConnection();
             if (con.State == ConnectionState.Closed)
             {
                 con.Open();
             }
             SqlCommand cmd = new SqlCommand("Select Id,Value from Lookup where Category = 'GENDER'", con);
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
             genderComboBox.DataSource = dataList;
         }



        private bool CheckRegistrationNumberExists(string registrationNumber)
        {
            string connectionString = @"Data Source=(local);Initial Catalog=2021-CS-146;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Student WHERE RegistrationNo = @RegistrationNo";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@RegistrationNo", registrationNumber);
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }

        private bool CheckEmailExists(string email)
        {
            string connectionString = @"Data Source=(local);Initial Catalog=2021-CS-146;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*)  FROM Person WHERE Email = @Email";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Email", email);
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }



        private bool insertStudent(String regNo, String FirstName, String LastName, String Email, String Contact, String DOB, int Gender)
        {

            SqlConnection con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            DateTime dob = Convert.ToDateTime(DOB);
            SqlCommand cmd = new SqlCommand("INSERT INTO Person (FirstName, LastName, Contact, Email, DateOfBirth, Gender) " +
                "OUTPUT INSERTED.ID " +
                "VALUES (@FirstName, @LastName, @Contact, @Email, @DOB, @Gender)", con);
            cmd.Parameters.AddWithValue("@FirstName", FirstName);
            cmd.Parameters.AddWithValue("@LastName", LastName);
            cmd.Parameters.AddWithValue("@Contact", Contact);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@DOB", dob);
            cmd.Parameters.AddWithValue("@Gender", Gender);

            int insertedPersonID = (int)cmd.ExecuteScalar();

            cmd = new SqlCommand("INSERT INTO Student (RegistrationNo, ID) " +
                "VALUES (@RegistrationNo, @ID)", con);
            cmd.Parameters.AddWithValue("@RegistrationNo", regNo);
            cmd.Parameters.AddWithValue("@ID", insertedPersonID);

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



        private void ClearTextboxes(Control parentControl)
        {
            foreach (Control control in parentControl.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Clear();
                }
                else if (control.HasChildren)
                {
                    ClearTextboxes(control);
                }
            }
        }

      
        private void studentDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            // Get the selected row
            DataGridViewRow row = studentDataGridView.Rows[e.RowIndex];

            // Populate the text boxes with the data
            rowIndex = e.RowIndex;
            regNoTextBox.Text = row.Cells["RegistrationNo"].Value.ToString();
            firstNameTextBox.Text = row.Cells["FirstName"].Value.ToString();
            lastNameTextBox.Text = row.Cells["LastName"].Value.ToString();
            contactTextBox.Text = row.Cells["Contact"].Value.ToString();
            emailTextBox.Text = row.Cells["Email"].Value.ToString();
            dateOfBirthPicker.Text = row.Cells["DateOfBirth"].Value.ToString();
            genderComboBox.Text = row.Cells["Gender"].Value.ToString();
        }

        private void addStudentButton_Click_1(object sender, EventArgs e)
        {



            bool value = true;
            int gender = GetGender(genderComboBox.Text);


            if (Validation.CheckFirstName(firstNameTextBox.Text))
            {
                // first name is valid
            }
            else
            {
                MessageBox.Show("first name is invalid");
                value = false;
            }
            if (Validation.CheckSecondName(lastNameTextBox.Text))
            {

            }
            else
            {
                MessageBox.Show("last name is invalid");
                value = false;
            }
            if (Validation.CheckRegNo(regNoTextBox.Text))
            {

            }
            else
            {
                MessageBox.Show("regNo is invalid");
                value = false;
            }

            if (Validation.CheckEmail(emailTextBox.Text))
            {

            }
            else
            {
                MessageBox.Show("email is invalid");
                value = false;

            }
            if (Validation.CheckContact(contactTextBox.Text))
            {

            }
            else
            {
                MessageBox.Show("contact is invalid");
                value = false;
            }

            if (CheckRegistrationNumberExists(regNoTextBox.Text))
            {
                MessageBox.Show("Registration number already exists.");
                value = false;
                return;
            }
            if (CheckEmailExists(emailTextBox.Text))
            {
                MessageBox.Show("Email address already exists.");
                value = false;
                return;
            }

            if (value)
            {


                insertStudent(regNoTextBox.Text, firstNameTextBox.Text, lastNameTextBox.Text, emailTextBox.Text, contactTextBox.Text, dateOfBirthPicker.Text, gender);
                MessageBox.Show("Successfully saved");


            }
        }

        private void personBtn_Click_1(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("SELECT * FROM Person ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            studentDataGridView.DataSource = dt;
        }

        private void updateStudentButton_Click_Click_1(object sender, EventArgs e)
        {
            int gender = GetGender(genderComboBox.Text);

            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string idValueFromGrid = studentDataGridView.Rows[rowIndex].Cells[0].Value.ToString();

            SqlCommand cmd = new SqlCommand("UPDATE Student SET Student.RegistrationNo = @RegistrationNo WHERE Student.Id = @Id", con);
            cmd.Parameters.AddWithValue("@RegistrationNo", regNoTextBox.Text);

            cmd.Parameters.AddWithValue("@Id", int.Parse(idValueFromGrid));
            var rowsAffected = cmd.ExecuteNonQuery();
            SqlCommand cm = new SqlCommand("UPDATE Person SET Person.FirstName = @FirstName, Person.LastName = @LastName, Person.Contact = @Contact, Person.Email = @Email, Person.DateOfBirth = @DateOfBirth, Person.Gender = @Gender  WHERE Person.Id = @Id", con);
            cm.Parameters.AddWithValue("@LastName", lastNameTextBox.Text);
            cm.Parameters.AddWithValue("@Contact", contactTextBox.Text);
            cm.Parameters.AddWithValue("@FirstName", firstNameTextBox.Text);
            cm.Parameters.AddWithValue("@Email", emailTextBox.Text);
            cm.Parameters.AddWithValue("@Id", int.Parse(idValueFromGrid));
            cm.Parameters.AddWithValue("@DateOfBirth", DateTime.Parse(dateOfBirthPicker.Text));
            cm.Parameters.AddWithValue("@Gender", gender);

            var rowsAffected1 = cm.ExecuteNonQuery();

            MessageBox.Show(" rows updated.");
        }

        private void showStudentButton_Click_Click_1(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("SELECT Person.*, Student.* FROM Person INNER JOIN Student ON Person.Id = Student.Id", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            studentDataGridView.DataSource = dt;
        }

        private void clearBtn_Click_1(object sender, EventArgs e)
        {
            ClearTextboxes(this.emailTextBox); // clears all textboxes on the current form
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            this.Hide();
        }
    }
}