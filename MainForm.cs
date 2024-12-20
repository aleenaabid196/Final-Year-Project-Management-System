using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidProjectUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        
        private void MainForm_Load(object sender, EventArgs e)
        {
           /* // Add a Panel control for the header section
            Panel headerPanel = new Panel();
            headerPanel.Location = new Point(0, 0);
            headerPanel.Size = new Size(800, 80);
            headerPanel.BackColor = Color.DodgerBlue;
            this.Controls.Add(headerPanel);*/

            // Add a Label control for the title in the header section
           /* Label titleLabel = new Label();
            titleLabel.Location = new Point(20, 20);
            titleLabel.Size = new Size(200, 40);
            titleLabel.Font = new Font("Arial", 16, FontStyle.Bold);
            titleLabel.ForeColor = Color.White;
            titleLabel.Text = "Final Year Projects";
            headerPanel.Controls.Add(titleLabel);*/

            // Add a PictureBox control for the logo in the header section
           /* PictureBox logoPictureBox = new PictureBox();
            logoPictureBox.Location = new Point(600, 10);
            logoPictureBox.Size = new Size(150, 60);
           // logoPictureBox.Image = Image.FromFile("logo.png");
            logoPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            headerPanel.Controls.Add(logoPictureBox);
*/
            // Add a Panel control for the menu section
            /*Panel menuPanel = new Panel();
            menuPanel.Location = new Point(0, 80);
            menuPanel.Size = new Size(200, 520);
            menuPanel.BackColor = Color.LightGray;
            this.Controls.Add(menuPanel);

            // Add a Button control for the "Manage Students" menu item
            Button manageStudentsButton = new Button();
            manageStudentsButton.Location = new Point(20, 20);
            manageStudentsButton.Size = new Size(160, 40);
            manageStudentsButton.Text = "Manage Students";
            menuPanel.Controls.Add(manageStudentsButton);*/
            // Add an event handler for the Click event of the manageStudentsButton
           /* manageStudentsButton.Click += ManageStudentsButton_Click;


            // Add a Button control for the "Manage Advisors" menu item
            Button manageAdvisorsButton = new Button();
            manageAdvisorsButton.Location = new Point(20, 80);
            manageAdvisorsButton.Size = new Size(160, 40);
            manageAdvisorsButton.Text = "Manage Advisors";
            menuPanel.Controls.Add(manageAdvisorsButton);
            // Add an event handler for the Click event of the manageStudentsButton
            manageAdvisorsButton.Click += ManageAdvisorsButton_Click;

            // Add a Button control for the "Manage Projects" menu item
            Button manageProjectsButton = new Button();
            manageProjectsButton.Location = new Point(20, 140);
            manageProjectsButton.Size = new Size(160, 40);
            manageProjectsButton.Text = "Manage Projects";
            menuPanel.Controls.Add(manageProjectsButton);

            // Add a Button control for the "Formation of Student Group" menu item
            Button formationButton = new Button();
            formationButton.Location = new Point(20, 200);
            formationButton.Size = new Size(160, 40);
            formationButton.Text = "Formation of Student Group";
            menuPanel.Controls.Add(formationButton);*/
        }



        private void logoutBtn_Click(object sender, EventArgs e)
        {
            // Navigate back to the login form
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void manageStuBtn_Click(object sender, EventArgs e)
        {
            // Create an instance of the ManageStudentsForm
            ManageStudentForm manageStudentsForm = new ManageStudentForm();

            // Show the ManageStudentsForm
            manageStudentsForm.Show();
            this.Hide();
        }

        private void manageAdvisorBtn_Click(object sender, EventArgs e)
        {
           
            AdvisorForm advisorForm = new AdvisorForm();

            advisorForm.Show();
            this.Hide();
        }

        private void manageProjectBtn_Click(object sender, EventArgs e)
        {
            ManageProject project= new ManageProject();

            project.Show();
            this.Hide();
        }

        private void assignProjectBtn_Click(object sender, EventArgs e)
        {
            AssignProject project= new AssignProject();

            project.Show();
            this.Hide();
        }

        private void assignAdvisorsBtn_Click(object sender, EventArgs e)
        {
            ProjectAdvisor advisorForm = new ProjectAdvisor();

            advisorForm.Show();
            this.Hide();
        }

        private void manageEvaluationBtn_Click(object sender, EventArgs e)
        {
            ManageEvaluation evaluation = new ManageEvaluation();

            evaluation.Show();
            this.Hide();
        }

        private void markEvaluationBtn_Click(object sender, EventArgs e)
        {
            GroupEvaluation evaluation = new GroupEvaluation();

            evaluation.Show();
            this.Hide();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Group evaluation = new Group();

            evaluation.Show();
            this.Hide();
        }

        private void groupFormationBtn_Click(object sender, EventArgs e)
        {
            StudentGroup evaluation = new StudentGroup();

            evaluation.Show();
            this.Hide();
        }

        private void report_Click(object sender, EventArgs e)
        {
            Report evaluation = new Report();

            evaluation.Show();
            this.Hide();

        }
    }
}
