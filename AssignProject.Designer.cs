
namespace MidProjectUI
{
    partial class AssignProject
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupIdComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.assigmentDatePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.assignProjectDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.showBtn = new Guna.UI2.WinForms.Guna2Button();
            this.updateStudentButton_Click = new Guna.UI2.WinForms.Guna2Button();
            this.addStudentButton = new Guna.UI2.WinForms.Guna2Button();
            this.projectIdcomboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.logoutBtn = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.assignProjectDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupIdComboBox
            // 
            this.groupIdComboBox.BackColor = System.Drawing.Color.Transparent;
            this.groupIdComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupIdComboBox.BorderRadius = 12;
            this.groupIdComboBox.BorderThickness = 2;
            this.groupIdComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.groupIdComboBox.DropDownHeight = 40;
            this.groupIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupIdComboBox.DropDownWidth = 240;
            this.groupIdComboBox.FillColor = System.Drawing.Color.Silver;
            this.groupIdComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.groupIdComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.groupIdComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.groupIdComboBox.ForeColor = System.Drawing.Color.Black;
            this.groupIdComboBox.HoverState.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.groupIdComboBox.HoverState.ForeColor = System.Drawing.Color.Black;
            this.groupIdComboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupIdComboBox.IntegralHeight = false;
            this.groupIdComboBox.ItemHeight = 30;
            this.groupIdComboBox.Location = new System.Drawing.Point(229, 464);
            this.groupIdComboBox.Name = "groupIdComboBox";
            this.groupIdComboBox.Size = new System.Drawing.Size(329, 36);
            this.groupIdComboBox.TabIndex = 107;
            // 
            // assigmentDatePicker
            // 
            this.assigmentDatePicker.BackColor = System.Drawing.Color.Transparent;
            this.assigmentDatePicker.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.assigmentDatePicker.BorderRadius = 12;
            this.assigmentDatePicker.BorderThickness = 2;
            this.assigmentDatePicker.Checked = true;
            this.assigmentDatePicker.FillColor = System.Drawing.Color.Silver;
            this.assigmentDatePicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.assigmentDatePicker.ForeColor = System.Drawing.Color.Black;
            this.assigmentDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.assigmentDatePicker.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.assigmentDatePicker.HoverState.ForeColor = System.Drawing.Color.Black;
            this.assigmentDatePicker.Location = new System.Drawing.Point(229, 579);
            this.assigmentDatePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.assigmentDatePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.assigmentDatePicker.Name = "assigmentDatePicker";
            this.assigmentDatePicker.Size = new System.Drawing.Size(329, 44);
            this.assigmentDatePicker.TabIndex = 106;
            this.assigmentDatePicker.Value = new System.DateTime(2023, 3, 10, 17, 47, 26, 901);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(218, 421);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 28);
            this.label3.TabIndex = 105;
            this.label3.Text = "Group Id";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(224, 539);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 37);
            this.label2.TabIndex = 104;
            this.label2.Text = "Assignment Date";
            // 
            // assignProjectDGV
            // 
            this.assignProjectDGV.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(64)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Silver;
            this.assignProjectDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.assignProjectDGV.BackgroundColor = System.Drawing.Color.Silver;
            this.assignProjectDGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.assignProjectDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.assignProjectDGV.ColumnHeadersHeight = 68;
            this.assignProjectDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(64)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.assignProjectDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.assignProjectDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.assignProjectDGV.Location = new System.Drawing.Point(616, 153);
            this.assignProjectDGV.Name = "assignProjectDGV";
            this.assignProjectDGV.ReadOnly = true;
            this.assignProjectDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.assignProjectDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.assignProjectDGV.RowHeadersVisible = false;
            this.assignProjectDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.assignProjectDGV.RowTemplate.Height = 47;
            this.assignProjectDGV.Size = new System.Drawing.Size(1147, 602);
            this.assignProjectDGV.TabIndex = 108;
            this.assignProjectDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.Silver;
            this.assignProjectDGV.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignProjectDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.assignProjectDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(64)))), ((int)(((byte)(72)))));
            this.assignProjectDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Silver;
            this.assignProjectDGV.ThemeStyle.BackColor = System.Drawing.Color.Silver;
            this.assignProjectDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.assignProjectDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Black;
            this.assignProjectDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.assignProjectDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignProjectDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Silver;
            this.assignProjectDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.assignProjectDGV.ThemeStyle.HeaderStyle.Height = 68;
            this.assignProjectDGV.ThemeStyle.ReadOnly = true;
            this.assignProjectDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.Gray;
            this.assignProjectDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.assignProjectDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignProjectDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.assignProjectDGV.ThemeStyle.RowsStyle.Height = 47;
            this.assignProjectDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(64)))), ((int)(((byte)(72)))));
            this.assignProjectDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Silver;
            this.assignProjectDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.assignProjectDGV_CellContentClick_1);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 12;
            this.guna2Button1.BorderThickness = 3;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Black;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.Ivory;
            this.guna2Button1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Button1.HoverState.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2Button1.Location = new System.Drawing.Point(1423, 793);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.BorderRadius = 26;
            this.guna2Button1.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2Button1.ShadowDecoration.Enabled = true;
            this.guna2Button1.Size = new System.Drawing.Size(175, 44);
            this.guna2Button1.TabIndex = 113;
            this.guna2Button1.Text = "CLEAR";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // showBtn
            // 
            this.showBtn.BackColor = System.Drawing.Color.Transparent;
            this.showBtn.BorderRadius = 12;
            this.showBtn.BorderThickness = 3;
            this.showBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.showBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.showBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.showBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.showBtn.FillColor = System.Drawing.Color.Black;
            this.showBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showBtn.ForeColor = System.Drawing.Color.Ivory;
            this.showBtn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.showBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.showBtn.HoverState.ForeColor = System.Drawing.Color.Black;
            this.showBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.showBtn.Location = new System.Drawing.Point(1002, 793);
            this.showBtn.Name = "showBtn";
            this.showBtn.ShadowDecoration.BorderRadius = 26;
            this.showBtn.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.showBtn.ShadowDecoration.Enabled = true;
            this.showBtn.Size = new System.Drawing.Size(175, 44);
            this.showBtn.TabIndex = 112;
            this.showBtn.Text = "DISPLAY";
            this.showBtn.Click += new System.EventHandler(this.showBtn_Click);
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
            this.updateStudentButton_Click.Location = new System.Drawing.Point(1202, 793);
            this.updateStudentButton_Click.Name = "updateStudentButton_Click";
            this.updateStudentButton_Click.ShadowDecoration.BorderRadius = 26;
            this.updateStudentButton_Click.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.updateStudentButton_Click.ShadowDecoration.Enabled = true;
            this.updateStudentButton_Click.Size = new System.Drawing.Size(175, 44);
            this.updateStudentButton_Click.TabIndex = 111;
            this.updateStudentButton_Click.Text = "UPDATE";
            this.updateStudentButton_Click.Click += new System.EventHandler(this.updateStudentButton_Click_Click);
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
            this.addStudentButton.Location = new System.Drawing.Point(777, 793);
            this.addStudentButton.Name = "addStudentButton";
            this.addStudentButton.ShadowDecoration.BorderRadius = 26;
            this.addStudentButton.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addStudentButton.ShadowDecoration.Enabled = true;
            this.addStudentButton.Size = new System.Drawing.Size(184, 44);
            this.addStudentButton.TabIndex = 109;
            this.addStudentButton.Text = "ADD";
            this.addStudentButton.Click += new System.EventHandler(this.addStudentButton_Click);
            // 
            // projectIdcomboBox
            // 
            this.projectIdcomboBox.BackColor = System.Drawing.Color.Transparent;
            this.projectIdcomboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.projectIdcomboBox.BorderRadius = 12;
            this.projectIdcomboBox.BorderThickness = 2;
            this.projectIdcomboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.projectIdcomboBox.DropDownHeight = 40;
            this.projectIdcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.projectIdcomboBox.DropDownWidth = 240;
            this.projectIdcomboBox.FillColor = System.Drawing.Color.Silver;
            this.projectIdcomboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.projectIdcomboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.projectIdcomboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.projectIdcomboBox.ForeColor = System.Drawing.Color.Black;
            this.projectIdcomboBox.HoverState.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.projectIdcomboBox.HoverState.ForeColor = System.Drawing.Color.Black;
            this.projectIdcomboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.projectIdcomboBox.IntegralHeight = false;
            this.projectIdcomboBox.ItemHeight = 30;
            this.projectIdcomboBox.Location = new System.Drawing.Point(229, 349);
            this.projectIdcomboBox.Name = "projectIdcomboBox";
            this.projectIdcomboBox.Size = new System.Drawing.Size(329, 36);
            this.projectIdcomboBox.TabIndex = 115;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(218, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 28);
            this.label4.TabIndex = 114;
            this.label4.Text = "Project Id";
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
            this.logoutBtn.Size = new System.Drawing.Size(171, 49);
            this.logoutBtn.TabIndex = 116;
            this.logoutBtn.Text = "Back";
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // AssignProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MidProjectUI.Properties.Resources.Black_Modern_Website_Desktop_Prototype___7_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.projectIdcomboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.showBtn);
            this.Controls.Add(this.updateStudentButton_Click);
            this.Controls.Add(this.addStudentButton);
            this.Controls.Add(this.groupIdComboBox);
            this.Controls.Add(this.assigmentDatePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.assignProjectDGV);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AssignProject";
            this.ShowIcon = false;
            this.Text = "AssignProject";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AssignProject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.assignProjectDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ComboBox groupIdComboBox;
        private Guna.UI2.WinForms.Guna2DateTimePicker assigmentDatePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DataGridView assignProjectDGV;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button showBtn;
        private Guna.UI2.WinForms.Guna2Button updateStudentButton_Click;
        private Guna.UI2.WinForms.Guna2Button addStudentButton;
        private Guna.UI2.WinForms.Guna2ComboBox projectIdcomboBox;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button logoutBtn;
    }
}