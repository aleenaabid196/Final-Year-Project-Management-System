
namespace MidProjectUI
{
    partial class ManageStudentForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.firstNameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblfirstName = new System.Windows.Forms.Label();
            this.lastNameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.regNoTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.contactTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.emailTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.dateOfBirthPicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.genderComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.studentDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.addStudentButton = new Guna.UI2.WinForms.Guna2Button();
            this.showStudentButton_Click = new Guna.UI2.WinForms.Guna2Button();
            this.updateStudentButton_Click = new Guna.UI2.WinForms.Guna2Button();
            this.personBtn = new Guna.UI2.WinForms.Guna2Button();
            this.clearBtn = new Guna.UI2.WinForms.Guna2Button();
            this.logoutBtn = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Animated = true;
            this.firstNameTextBox.BackColor = System.Drawing.Color.Transparent;
            this.firstNameTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.firstNameTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.firstNameTextBox.BorderRadius = 12;
            this.firstNameTextBox.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.firstNameTextBox.BorderThickness = 2;
            this.firstNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.firstNameTextBox.DefaultText = "";
            this.firstNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.firstNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.firstNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.firstNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.firstNameTextBox.FillColor = System.Drawing.Color.Silver;
            this.firstNameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.firstNameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.firstNameTextBox.ForeColor = System.Drawing.Color.Black;
            this.firstNameTextBox.HoverState.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.firstNameTextBox.HoverState.ForeColor = System.Drawing.Color.Black;
            this.firstNameTextBox.HoverState.PlaceholderForeColor = System.Drawing.Color.Black;
            this.firstNameTextBox.Location = new System.Drawing.Point(261, 202);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.PasswordChar = '\0';
            this.firstNameTextBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.firstNameTextBox.PlaceholderText = "";
            this.firstNameTextBox.SelectedText = "";
            this.firstNameTextBox.Size = new System.Drawing.Size(329, 44);
            this.firstNameTextBox.TabIndex = 62;
            // 
            // lblfirstName
            // 
            this.lblfirstName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblfirstName.BackColor = System.Drawing.Color.Transparent;
            this.lblfirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfirstName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblfirstName.Location = new System.Drawing.Point(256, 167);
            this.lblfirstName.Name = "lblfirstName";
            this.lblfirstName.Size = new System.Drawing.Size(269, 31);
            this.lblfirstName.TabIndex = 60;
            this.lblfirstName.Text = "First Name";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Animated = true;
            this.lastNameTextBox.BackColor = System.Drawing.Color.Transparent;
            this.lastNameTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.lastNameTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lastNameTextBox.BorderRadius = 12;
            this.lastNameTextBox.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.lastNameTextBox.BorderThickness = 2;
            this.lastNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lastNameTextBox.DefaultText = "";
            this.lastNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.lastNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.lastNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lastNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lastNameTextBox.FillColor = System.Drawing.Color.Silver;
            this.lastNameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lastNameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lastNameTextBox.ForeColor = System.Drawing.Color.Black;
            this.lastNameTextBox.HoverState.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.lastNameTextBox.HoverState.ForeColor = System.Drawing.Color.Black;
            this.lastNameTextBox.HoverState.PlaceholderForeColor = System.Drawing.Color.Black;
            this.lastNameTextBox.Location = new System.Drawing.Point(261, 307);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.PasswordChar = '\0';
            this.lastNameTextBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.lastNameTextBox.PlaceholderText = "";
            this.lastNameTextBox.SelectedText = "";
            this.lastNameTextBox.Size = new System.Drawing.Size(329, 44);
            this.lastNameTextBox.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(256, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 39);
            this.label1.TabIndex = 63;
            this.label1.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(262, 493);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 37);
            this.label2.TabIndex = 65;
            this.label2.Text = "Date of Birth";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(256, 385);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 28);
            this.label3.TabIndex = 67;
            this.label3.Text = "Gender";
            // 
            // regNoTextBox
            // 
            this.regNoTextBox.Animated = true;
            this.regNoTextBox.BackColor = System.Drawing.Color.Transparent;
            this.regNoTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.regNoTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.regNoTextBox.BorderRadius = 12;
            this.regNoTextBox.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.regNoTextBox.BorderThickness = 2;
            this.regNoTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.regNoTextBox.DefaultText = "";
            this.regNoTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.regNoTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.regNoTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.regNoTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.regNoTextBox.FillColor = System.Drawing.Color.Silver;
            this.regNoTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.regNoTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.regNoTextBox.ForeColor = System.Drawing.Color.Black;
            this.regNoTextBox.HoverState.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.regNoTextBox.HoverState.ForeColor = System.Drawing.Color.Black;
            this.regNoTextBox.HoverState.PlaceholderForeColor = System.Drawing.Color.Black;
            this.regNoTextBox.Location = new System.Drawing.Point(261, 833);
            this.regNoTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.regNoTextBox.Name = "regNoTextBox";
            this.regNoTextBox.PasswordChar = '\0';
            this.regNoTextBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.regNoTextBox.PlaceholderText = "";
            this.regNoTextBox.SelectedText = "";
            this.regNoTextBox.Size = new System.Drawing.Size(329, 44);
            this.regNoTextBox.TabIndex = 70;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(268, 799);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 30);
            this.label4.TabIndex = 69;
            this.label4.Text = "Reg No.";
            // 
            // contactTextBox
            // 
            this.contactTextBox.Animated = true;
            this.contactTextBox.BackColor = System.Drawing.Color.Transparent;
            this.contactTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.contactTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.contactTextBox.BorderRadius = 12;
            this.contactTextBox.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.contactTextBox.BorderThickness = 2;
            this.contactTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.contactTextBox.DefaultText = "";
            this.contactTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.contactTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.contactTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.contactTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.contactTextBox.FillColor = System.Drawing.Color.Silver;
            this.contactTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.contactTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.contactTextBox.ForeColor = System.Drawing.Color.Black;
            this.contactTextBox.HoverState.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.contactTextBox.HoverState.ForeColor = System.Drawing.Color.Black;
            this.contactTextBox.HoverState.PlaceholderForeColor = System.Drawing.Color.Black;
            this.contactTextBox.Location = new System.Drawing.Point(261, 628);
            this.contactTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.contactTextBox.Name = "contactTextBox";
            this.contactTextBox.PasswordChar = '\0';
            this.contactTextBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.contactTextBox.PlaceholderText = "";
            this.contactTextBox.SelectedText = "";
            this.contactTextBox.Size = new System.Drawing.Size(329, 44);
            this.contactTextBox.TabIndex = 72;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(262, 596);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 28);
            this.label5.TabIndex = 71;
            this.label5.Text = "Contact";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(262, 702);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(211, 28);
            this.label6.TabIndex = 73;
            this.label6.Text = "Email";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Animated = true;
            this.emailTextBox.BackColor = System.Drawing.Color.Transparent;
            this.emailTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.emailTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.emailTextBox.BorderRadius = 12;
            this.emailTextBox.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.emailTextBox.BorderThickness = 2;
            this.emailTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailTextBox.DefaultText = "";
            this.emailTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.emailTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.emailTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailTextBox.FillColor = System.Drawing.Color.Silver;
            this.emailTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.emailTextBox.ForeColor = System.Drawing.Color.Black;
            this.emailTextBox.HoverState.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.emailTextBox.HoverState.ForeColor = System.Drawing.Color.Black;
            this.emailTextBox.HoverState.PlaceholderForeColor = System.Drawing.Color.Black;
            this.emailTextBox.Location = new System.Drawing.Point(261, 734);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.PasswordChar = '\0';
            this.emailTextBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.emailTextBox.PlaceholderText = "";
            this.emailTextBox.SelectedText = "";
            this.emailTextBox.Size = new System.Drawing.Size(329, 44);
            this.emailTextBox.TabIndex = 74;
            // 
            // dateOfBirthPicker
            // 
            this.dateOfBirthPicker.BackColor = System.Drawing.Color.Transparent;
            this.dateOfBirthPicker.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dateOfBirthPicker.BorderRadius = 12;
            this.dateOfBirthPicker.BorderThickness = 2;
            this.dateOfBirthPicker.Checked = true;
            this.dateOfBirthPicker.FillColor = System.Drawing.Color.Silver;
            this.dateOfBirthPicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateOfBirthPicker.ForeColor = System.Drawing.Color.Black;
            this.dateOfBirthPicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateOfBirthPicker.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dateOfBirthPicker.HoverState.ForeColor = System.Drawing.Color.Black;
            this.dateOfBirthPicker.Location = new System.Drawing.Point(261, 521);
            this.dateOfBirthPicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateOfBirthPicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateOfBirthPicker.Name = "dateOfBirthPicker";
            this.dateOfBirthPicker.Size = new System.Drawing.Size(329, 44);
            this.dateOfBirthPicker.TabIndex = 75;
            this.dateOfBirthPicker.Value = new System.DateTime(2023, 3, 10, 17, 47, 26, 901);
            // 
            // genderComboBox
            // 
            this.genderComboBox.BackColor = System.Drawing.Color.Transparent;
            this.genderComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.genderComboBox.BorderRadius = 12;
            this.genderComboBox.BorderThickness = 2;
            this.genderComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.genderComboBox.DropDownHeight = 40;
            this.genderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderComboBox.DropDownWidth = 240;
            this.genderComboBox.FillColor = System.Drawing.Color.Silver;
            this.genderComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.genderComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.genderComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.genderComboBox.ForeColor = System.Drawing.Color.Black;
            this.genderComboBox.HoverState.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.genderComboBox.HoverState.ForeColor = System.Drawing.Color.Black;
            this.genderComboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.genderComboBox.IntegralHeight = false;
            this.genderComboBox.ItemHeight = 30;
            this.genderComboBox.Location = new System.Drawing.Point(261, 416);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(329, 36);
            this.genderComboBox.TabIndex = 76;
            // 
            // studentDataGridView
            // 
            this.studentDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(64)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Silver;
            this.studentDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.studentDataGridView.BackgroundColor = System.Drawing.Color.Silver;
            this.studentDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studentDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.studentDataGridView.ColumnHeadersHeight = 68;
            this.studentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(64)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.studentDataGridView.DefaultCellStyle = dataGridViewCellStyle11;
            this.studentDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.studentDataGridView.Location = new System.Drawing.Point(669, 212);
            this.studentDataGridView.Name = "studentDataGridView";
            this.studentDataGridView.ReadOnly = true;
            this.studentDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studentDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.studentDataGridView.RowHeadersVisible = false;
            this.studentDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.studentDataGridView.RowTemplate.Height = 47;
            this.studentDataGridView.Size = new System.Drawing.Size(1105, 601);
            this.studentDataGridView.TabIndex = 78;
            this.studentDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.Silver;
            this.studentDataGridView.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.studentDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(64)))), ((int)(((byte)(72)))));
            this.studentDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Silver;
            this.studentDataGridView.ThemeStyle.BackColor = System.Drawing.Color.Silver;
            this.studentDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.studentDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Black;
            this.studentDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.studentDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Silver;
            this.studentDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.studentDataGridView.ThemeStyle.HeaderStyle.Height = 68;
            this.studentDataGridView.ThemeStyle.ReadOnly = true;
            this.studentDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.Gray;
            this.studentDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.studentDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.studentDataGridView.ThemeStyle.RowsStyle.Height = 47;
            this.studentDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(64)))), ((int)(((byte)(72)))));
            this.studentDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Silver;
            this.studentDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentDataGridView_CellContentClick);
            // 
            // addStudentButton
            // 
            this.addStudentButton.BackColor = System.Drawing.Color.Transparent;
            this.addStudentButton.BorderRadius = 12;
            this.addStudentButton.BorderThickness = 3;
            this.addStudentButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addStudentButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addStudentButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addStudentButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addStudentButton.FillColor = System.Drawing.Color.Black;
            this.addStudentButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStudentButton.ForeColor = System.Drawing.Color.Ivory;
            this.addStudentButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.addStudentButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addStudentButton.HoverState.ForeColor = System.Drawing.Color.Black;
            this.addStudentButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.addStudentButton.Location = new System.Drawing.Point(710, 833);
            this.addStudentButton.Name = "addStudentButton";
            this.addStudentButton.ShadowDecoration.BorderRadius = 26;
            this.addStudentButton.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addStudentButton.ShadowDecoration.Enabled = true;
            this.addStudentButton.Size = new System.Drawing.Size(184, 44);
            this.addStudentButton.TabIndex = 79;
            this.addStudentButton.Text = "ADD";
            this.addStudentButton.Click += new System.EventHandler(this.addStudentButton_Click_1);
            // 
            // showStudentButton_Click
            // 
            this.showStudentButton_Click.BackColor = System.Drawing.Color.Transparent;
            this.showStudentButton_Click.BorderRadius = 12;
            this.showStudentButton_Click.BorderThickness = 3;
            this.showStudentButton_Click.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.showStudentButton_Click.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.showStudentButton_Click.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.showStudentButton_Click.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.showStudentButton_Click.FillColor = System.Drawing.Color.Black;
            this.showStudentButton_Click.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showStudentButton_Click.ForeColor = System.Drawing.Color.Ivory;
            this.showStudentButton_Click.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.showStudentButton_Click.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.showStudentButton_Click.HoverState.ForeColor = System.Drawing.Color.Black;
            this.showStudentButton_Click.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.showStudentButton_Click.Location = new System.Drawing.Point(918, 833);
            this.showStudentButton_Click.Name = "showStudentButton_Click";
            this.showStudentButton_Click.ShadowDecoration.BorderRadius = 26;
            this.showStudentButton_Click.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.showStudentButton_Click.ShadowDecoration.Enabled = true;
            this.showStudentButton_Click.Size = new System.Drawing.Size(175, 44);
            this.showStudentButton_Click.TabIndex = 80;
            this.showStudentButton_Click.Text = "DISPLAY  STUDENT";
            this.showStudentButton_Click.Click += new System.EventHandler(this.showStudentButton_Click_Click_1);
            // 
            // updateStudentButton_Click
            // 
            this.updateStudentButton_Click.BackColor = System.Drawing.Color.Transparent;
            this.updateStudentButton_Click.BorderRadius = 12;
            this.updateStudentButton_Click.BorderThickness = 3;
            this.updateStudentButton_Click.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.updateStudentButton_Click.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.updateStudentButton_Click.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.updateStudentButton_Click.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.updateStudentButton_Click.FillColor = System.Drawing.Color.Black;
            this.updateStudentButton_Click.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateStudentButton_Click.ForeColor = System.Drawing.Color.Ivory;
            this.updateStudentButton_Click.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.updateStudentButton_Click.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.updateStudentButton_Click.HoverState.ForeColor = System.Drawing.Color.Black;
            this.updateStudentButton_Click.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.updateStudentButton_Click.Location = new System.Drawing.Point(1135, 833);
            this.updateStudentButton_Click.Name = "updateStudentButton_Click";
            this.updateStudentButton_Click.ShadowDecoration.BorderRadius = 26;
            this.updateStudentButton_Click.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.updateStudentButton_Click.ShadowDecoration.Enabled = true;
            this.updateStudentButton_Click.Size = new System.Drawing.Size(175, 44);
            this.updateStudentButton_Click.TabIndex = 81;
            this.updateStudentButton_Click.Text = "UPDATE";
            this.updateStudentButton_Click.Click += new System.EventHandler(this.updateStudentButton_Click_Click_1);
            // 
            // personBtn
            // 
            this.personBtn.BackColor = System.Drawing.Color.Transparent;
            this.personBtn.BorderRadius = 12;
            this.personBtn.BorderThickness = 3;
            this.personBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.personBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.personBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.personBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.personBtn.FillColor = System.Drawing.Color.Black;
            this.personBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personBtn.ForeColor = System.Drawing.Color.Ivory;
            this.personBtn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.personBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.personBtn.HoverState.ForeColor = System.Drawing.Color.Black;
            this.personBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.personBtn.Location = new System.Drawing.Point(1355, 833);
            this.personBtn.Name = "personBtn";
            this.personBtn.ShadowDecoration.BorderRadius = 26;
            this.personBtn.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.personBtn.ShadowDecoration.Enabled = true;
            this.personBtn.Size = new System.Drawing.Size(175, 44);
            this.personBtn.TabIndex = 82;
            this.personBtn.Text = "DISPLAY  PERSON";
            this.personBtn.Click += new System.EventHandler(this.personBtn_Click_1);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.Transparent;
            this.clearBtn.BorderRadius = 12;
            this.clearBtn.BorderThickness = 3;
            this.clearBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.clearBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.clearBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.clearBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.clearBtn.FillColor = System.Drawing.Color.Black;
            this.clearBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.ForeColor = System.Drawing.Color.Ivory;
            this.clearBtn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.clearBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clearBtn.HoverState.ForeColor = System.Drawing.Color.Black;
            this.clearBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.clearBtn.Location = new System.Drawing.Point(1568, 833);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.ShadowDecoration.BorderRadius = 26;
            this.clearBtn.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.clearBtn.ShadowDecoration.Enabled = true;
            this.clearBtn.Size = new System.Drawing.Size(175, 44);
            this.clearBtn.TabIndex = 83;
            this.clearBtn.Text = "CLEAR";
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click_1);
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.Transparent;
            this.logoutBtn.BorderColor = System.Drawing.Color.Gainsboro;
            this.logoutBtn.BorderRadius = 12;
            this.logoutBtn.BorderThickness = 2;
            this.logoutBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.logoutBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.logoutBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.logoutBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.logoutBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.logoutBtn.FillColor = System.Drawing.Color.LightGray;
            this.logoutBtn.FocusedColor = System.Drawing.Color.White;
            this.logoutBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.ForeColor = System.Drawing.Color.Black;
            this.logoutBtn.HoverState.BorderColor = System.Drawing.Color.Silver;
            this.logoutBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.logoutBtn.HoverState.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.logoutBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.logoutBtn.Location = new System.Drawing.Point(1768, 38);
            this.logoutBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.PressedDepth = 20;
            this.logoutBtn.ShadowDecoration.BorderRadius = 26;
            this.logoutBtn.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.logoutBtn.ShadowDecoration.Enabled = true;
            this.logoutBtn.Size = new System.Drawing.Size(189, 42);
            this.logoutBtn.TabIndex = 117;
            this.logoutBtn.Text = "Back";
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // ManageStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::MidProjectUI.Properties.Resources.Black_Modern_Website_Desktop_Prototype___7_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.personBtn);
            this.Controls.Add(this.updateStudentButton_Click);
            this.Controls.Add(this.showStudentButton_Click);
            this.Controls.Add(this.addStudentButton);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(this.dateOfBirthPicker);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.contactTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.regNoTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.lblfirstName);
            this.Controls.Add(this.studentDataGridView);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManageStudentForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageStudentsForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ManageStudentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox firstNameTextBox;
        private System.Windows.Forms.Label lblfirstName;
        private Guna.UI2.WinForms.Guna2TextBox lastNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox regNoTextBox;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox contactTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox emailTextBox;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateOfBirthPicker;
        private Guna.UI2.WinForms.Guna2ComboBox genderComboBox;
        private Guna.UI2.WinForms.Guna2DataGridView studentDataGridView;
        private Guna.UI2.WinForms.Guna2Button addStudentButton;
        private Guna.UI2.WinForms.Guna2Button showStudentButton_Click;
        private Guna.UI2.WinForms.Guna2Button updateStudentButton_Click;
        private Guna.UI2.WinForms.Guna2Button personBtn;
        private Guna.UI2.WinForms.Guna2Button clearBtn;
        private Guna.UI2.WinForms.Guna2Button logoutBtn;
    }
}