
namespace MidProjectUI
{
    partial class StudentGroup
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
            this.clearBtn = new Guna.UI2.WinForms.Guna2Button();
            this.showBtn = new Guna.UI2.WinForms.Guna2Button();
            this.updateBtn = new Guna.UI2.WinForms.Guna2Button();
            this.addBtn = new Guna.UI2.WinForms.Guna2Button();
            this.studentGroupDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.assignmentDatePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.statusComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupIdComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.studentIdcomboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.logoutBtn = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.studentGroupDGV)).BeginInit();
            this.SuspendLayout();
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
            this.clearBtn.Location = new System.Drawing.Point(1454, 804);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.ShadowDecoration.BorderRadius = 26;
            this.clearBtn.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.clearBtn.ShadowDecoration.Enabled = true;
            this.clearBtn.Size = new System.Drawing.Size(159, 46);
            this.clearBtn.TabIndex = 146;
            this.clearBtn.Text = "CLEAR";
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
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
            this.showBtn.Location = new System.Drawing.Point(1033, 804);
            this.showBtn.Name = "showBtn";
            this.showBtn.ShadowDecoration.BorderRadius = 26;
            this.showBtn.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.showBtn.ShadowDecoration.Enabled = true;
            this.showBtn.Size = new System.Drawing.Size(159, 46);
            this.showBtn.TabIndex = 145;
            this.showBtn.Text = "DISPLAY";
            this.showBtn.Click += new System.EventHandler(this.showBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.Transparent;
            this.updateBtn.BorderRadius = 12;
            this.updateBtn.BorderThickness = 3;
            this.updateBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.updateBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.updateBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.updateBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.updateBtn.FillColor = System.Drawing.Color.Black;
            this.updateBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.ForeColor = System.Drawing.Color.Ivory;
            this.updateBtn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.updateBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.updateBtn.HoverState.ForeColor = System.Drawing.Color.Black;
            this.updateBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.updateBtn.Location = new System.Drawing.Point(1233, 804);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.ShadowDecoration.BorderRadius = 26;
            this.updateBtn.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.updateBtn.ShadowDecoration.Enabled = true;
            this.updateBtn.Size = new System.Drawing.Size(159, 46);
            this.updateBtn.TabIndex = 144;
            this.updateBtn.Text = "UPDATE";
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.Transparent;
            this.addBtn.BorderRadius = 12;
            this.addBtn.BorderThickness = 3;
            this.addBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addBtn.FillColor = System.Drawing.Color.Black;
            this.addBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.Color.Ivory;
            this.addBtn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.addBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addBtn.HoverState.ForeColor = System.Drawing.Color.Black;
            this.addBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.addBtn.Location = new System.Drawing.Point(808, 804);
            this.addBtn.Name = "addBtn";
            this.addBtn.ShadowDecoration.BorderRadius = 26;
            this.addBtn.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addBtn.ShadowDecoration.Enabled = true;
            this.addBtn.Size = new System.Drawing.Size(168, 46);
            this.addBtn.TabIndex = 143;
            this.addBtn.Text = "ADD";
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // studentGroupDGV
            // 
            this.studentGroupDGV.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(64)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Silver;
            this.studentGroupDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.studentGroupDGV.BackgroundColor = System.Drawing.Color.Silver;
            this.studentGroupDGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studentGroupDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.studentGroupDGV.ColumnHeadersHeight = 68;
            this.studentGroupDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(64)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.studentGroupDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.studentGroupDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.studentGroupDGV.Location = new System.Drawing.Point(672, 188);
            this.studentGroupDGV.Name = "studentGroupDGV";
            this.studentGroupDGV.ReadOnly = true;
            this.studentGroupDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studentGroupDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.studentGroupDGV.RowHeadersVisible = false;
            this.studentGroupDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.studentGroupDGV.RowTemplate.Height = 47;
            this.studentGroupDGV.Size = new System.Drawing.Size(1085, 592);
            this.studentGroupDGV.TabIndex = 142;
            this.studentGroupDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.Silver;
            this.studentGroupDGV.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentGroupDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.studentGroupDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(64)))), ((int)(((byte)(72)))));
            this.studentGroupDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Silver;
            this.studentGroupDGV.ThemeStyle.BackColor = System.Drawing.Color.Silver;
            this.studentGroupDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.studentGroupDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Black;
            this.studentGroupDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.studentGroupDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentGroupDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Silver;
            this.studentGroupDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.studentGroupDGV.ThemeStyle.HeaderStyle.Height = 68;
            this.studentGroupDGV.ThemeStyle.ReadOnly = true;
            this.studentGroupDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.Gray;
            this.studentGroupDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.studentGroupDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentGroupDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.studentGroupDGV.ThemeStyle.RowsStyle.Height = 47;
            this.studentGroupDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(64)))), ((int)(((byte)(72)))));
            this.studentGroupDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Silver;
            this.studentGroupDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentGroupDGV_CellContentClick_1);
            // 
            // assignmentDatePicker
            // 
            this.assignmentDatePicker.BackColor = System.Drawing.Color.Transparent;
            this.assignmentDatePicker.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.assignmentDatePicker.BorderRadius = 12;
            this.assignmentDatePicker.BorderThickness = 2;
            this.assignmentDatePicker.Checked = true;
            this.assignmentDatePicker.FillColor = System.Drawing.Color.Silver;
            this.assignmentDatePicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.assignmentDatePicker.ForeColor = System.Drawing.Color.Black;
            this.assignmentDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.assignmentDatePicker.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.assignmentDatePicker.HoverState.ForeColor = System.Drawing.Color.Black;
            this.assignmentDatePicker.Location = new System.Drawing.Point(289, 655);
            this.assignmentDatePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.assignmentDatePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.assignmentDatePicker.Name = "assignmentDatePicker";
            this.assignmentDatePicker.Size = new System.Drawing.Size(329, 44);
            this.assignmentDatePicker.TabIndex = 141;
            this.assignmentDatePicker.Value = new System.DateTime(2023, 3, 10, 17, 47, 26, 901);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(284, 600);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(223, 37);
            this.label6.TabIndex = 140;
            this.label6.Text = "Assignment Date";
            // 
            // statusComboBox
            // 
            this.statusComboBox.BackColor = System.Drawing.Color.Transparent;
            this.statusComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.statusComboBox.BorderRadius = 12;
            this.statusComboBox.BorderThickness = 2;
            this.statusComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.statusComboBox.DropDownHeight = 40;
            this.statusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusComboBox.DropDownWidth = 240;
            this.statusComboBox.FillColor = System.Drawing.Color.Silver;
            this.statusComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.statusComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.statusComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.statusComboBox.ForeColor = System.Drawing.Color.Black;
            this.statusComboBox.HoverState.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.statusComboBox.HoverState.ForeColor = System.Drawing.Color.Black;
            this.statusComboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.statusComboBox.IntegralHeight = false;
            this.statusComboBox.ItemHeight = 30;
            this.statusComboBox.Location = new System.Drawing.Point(289, 538);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(329, 36);
            this.statusComboBox.TabIndex = 139;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(284, 495);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 40);
            this.label5.TabIndex = 138;
            this.label5.Text = "Status Role";
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
            this.groupIdComboBox.Location = new System.Drawing.Point(289, 314);
            this.groupIdComboBox.Name = "groupIdComboBox";
            this.groupIdComboBox.Size = new System.Drawing.Size(329, 36);
            this.groupIdComboBox.TabIndex = 137;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(278, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 40);
            this.label4.TabIndex = 136;
            this.label4.Text = "Group Id";
            // 
            // studentIdcomboBox
            // 
            this.studentIdcomboBox.BackColor = System.Drawing.Color.Transparent;
            this.studentIdcomboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.studentIdcomboBox.BorderRadius = 12;
            this.studentIdcomboBox.BorderThickness = 2;
            this.studentIdcomboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.studentIdcomboBox.DropDownHeight = 40;
            this.studentIdcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.studentIdcomboBox.DropDownWidth = 240;
            this.studentIdcomboBox.FillColor = System.Drawing.Color.Silver;
            this.studentIdcomboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.studentIdcomboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.studentIdcomboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.studentIdcomboBox.ForeColor = System.Drawing.Color.Black;
            this.studentIdcomboBox.HoverState.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.studentIdcomboBox.HoverState.ForeColor = System.Drawing.Color.Black;
            this.studentIdcomboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.studentIdcomboBox.IntegralHeight = false;
            this.studentIdcomboBox.ItemHeight = 30;
            this.studentIdcomboBox.Location = new System.Drawing.Point(289, 429);
            this.studentIdcomboBox.Name = "studentIdcomboBox";
            this.studentIdcomboBox.Size = new System.Drawing.Size(329, 36);
            this.studentIdcomboBox.TabIndex = 135;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(278, 386);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 28);
            this.label3.TabIndex = 134;
            this.label3.Text = "Student Id";
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
            this.logoutBtn.Size = new System.Drawing.Size(198, 46);
            this.logoutBtn.TabIndex = 147;
            this.logoutBtn.Text = "Back";
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // StudentGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MidProjectUI.Properties.Resources.Black_Modern_Website_Desktop_Prototype___7_8;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.showBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.studentGroupDGV);
            this.Controls.Add(this.assignmentDatePicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupIdComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.studentIdcomboBox);
            this.Controls.Add(this.label3);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StudentGroup";
            this.ShowIcon = false;
            this.Text = "StudentGroup";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StudentGroup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentGroupDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button clearBtn;
        private Guna.UI2.WinForms.Guna2Button showBtn;
        private Guna.UI2.WinForms.Guna2Button updateBtn;
        private Guna.UI2.WinForms.Guna2Button addBtn;
        private Guna.UI2.WinForms.Guna2DataGridView studentGroupDGV;
        private Guna.UI2.WinForms.Guna2DateTimePicker assignmentDatePicker;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2ComboBox statusComboBox;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox groupIdComboBox;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox studentIdcomboBox;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button logoutBtn;
    }
}