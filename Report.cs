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
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;

namespace MidProjectUI
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        
        private void reportDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void report1_Click(object sender, EventArgs e)
        {

            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("Select CONCAT(FirstName,LastName) As [Name],t4.Value ,Title  ,AssignmentDate ,t3.Email from Project t1 JOIN ProjectAdvisor t2 on t1.Id = t2.ProjectId JOIN Person t3 on t3.Id = t2.AdvisorId join Lookup t4 on AdvisorRole = t4.Id", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            reportDGV.DataSource = dt;


        }

    private void report2_Click(object sender, EventArgs e)
        {

            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("Select RegistrationNo , t2.Status ,t5.Title,RegistrationNo, CONCAT(FirstName,LastName) as [Name] from Student t1 join GroupStudent t2 on t1.Id = t2.StudentId join [Group] t3 on t2.GroupId = t3.Id join GroupProject t4 on t4.GroupId = t3.Id join Project t5 on t5.Id = t4.ProjectId join ProjectAdvisor t6 on t5.Id = t6.ProjectId join Person t7 on t6.AdvisorId = t7.Id", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            reportDGV.DataSource = dt;
        }

        private void report3_Click(object sender, EventArgs e)
        {

            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("Select RegistrationNo from Student t1 where Id Not In(Select Id from Student t2 join GroupStudent t3 on t2.Id = t3.StudentId)", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            reportDGV.DataSource = dt;
        }

        private void report4_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("select Project.Id AS [Project Id], Evaluation.Id AS [Evaluation Id], GroupEvaluation.ObtainedMarks, Student.RegistrationNo from Project JOIN Student on Project.Id = Student.Id JOIN Evaluation on Evaluation.Id = Student.Id JOIN GroupEvaluation on GroupEvaluation.EvaluationId = Evaluation.Id", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            reportDGV.DataSource = dt;
        }

        private void repoort5_Click(object sender, EventArgs e)
        {

            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("SELECT GroupEvaluation.GroupId , Project.Title , Name [Project Name], ObtainedMarks, TotalMarks[Total Marks], (CAST(ObtainedMarks AS float) / TotalMarks) * 100 Percentage FROM GroupEvaluation JOIN Evaluation On Evaluation.Id = GroupEvaluation.EvaluationId JOIN GroupProject ON GroupEvaluation.GroupId = GroupProject.GroupId JOIN Project ON Project.Id = GroupProject.ProjectId WHERE(CAST( ObtainedMarks AS float) / TotalMarks) * 100 < 30", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            reportDGV.DataSource = dt;
        }

        private void report6_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("select GroupStudent.GroupId AS [Group ID] , Student.RegistrationNo, Person.FirstName, Person.LastName from GroupStudent JOIN Student on Student.Id = GroupStudent.StudentId JOIN Person on GroupStudent.StudentId= Person.Id Group by GroupStudent.GroupId, Student.RegistrationNo, Person.FirstName, Person.LastName", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            reportDGV.DataSource = dt;
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {

            MainForm mf = new MainForm();
            mf.Show();
            this.Hide();
        }
    }
    }

