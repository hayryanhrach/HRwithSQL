namespace HRForms
{
    partial class AddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddForm));
            txtAddTitle = new TextBox();
            txtCodeValue = new TextBox();
            txtCodeName = new TextBox();
            txtFirstNameValue = new TextBox();
            txtFirstNameName = new TextBox();
            txtLastNameValue = new TextBox();
            txtLastNameName = new TextBox();
            txtDeparmentName = new TextBox();
            txtDepartmentValue = new TextBox();
            btnAdd = new Button();
            btnCancel = new Button();
            btnGoToMain = new Button();
            btnAll = new Button();
            picAddMain = new PictureBox();
            picAddAdd = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picAddMain).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAddAdd).BeginInit();
            SuspendLayout();
            // 
            // txtAddTitle
            // 
            txtAddTitle.BackColor = Color.FromArgb(157, 171, 215);
            txtAddTitle.BorderStyle = BorderStyle.FixedSingle;
            txtAddTitle.Font = new Font("Courgette", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtAddTitle.ForeColor = Color.FromArgb(18, 49, 85);
            txtAddTitle.Location = new Point(53, 14);
            txtAddTitle.Margin = new Padding(4, 3, 4, 3);
            txtAddTitle.Name = "txtAddTitle";
            txtAddTitle.ReadOnly = true;
            txtAddTitle.Size = new Size(194, 24);
            txtAddTitle.TabIndex = 0;
            txtAddTitle.Text = "Նոր աշխատողի գրանցում";
            // 
            // txtCodeValue
            // 
            txtCodeValue.BackColor = Color.White;
            txtCodeValue.BorderStyle = BorderStyle.FixedSingle;
            txtCodeValue.Location = new Point(90, 57);
            txtCodeValue.Margin = new Padding(4, 3, 4, 3);
            txtCodeValue.Name = "txtCodeValue";
            txtCodeValue.Size = new Size(238, 23);
            txtCodeValue.TabIndex = 1;
            // 
            // txtCodeName
            // 
            txtCodeName.BackColor = Color.FromArgb(197, 216, 238);
            txtCodeName.BorderStyle = BorderStyle.FixedSingle;
            txtCodeName.ForeColor = Color.FromArgb(18, 49, 85);
            txtCodeName.Location = new Point(12, 57);
            txtCodeName.Margin = new Padding(4, 3, 4, 3);
            txtCodeName.Name = "txtCodeName";
            txtCodeName.ReadOnly = true;
            txtCodeName.Size = new Size(70, 23);
            txtCodeName.TabIndex = 2;
            txtCodeName.Text = "Կոդ";
            // 
            // txtFirstNameValue
            // 
            txtFirstNameValue.BackColor = Color.White;
            txtFirstNameValue.BorderStyle = BorderStyle.FixedSingle;
            txtFirstNameValue.Location = new Point(90, 86);
            txtFirstNameValue.Margin = new Padding(4, 3, 4, 3);
            txtFirstNameValue.Name = "txtFirstNameValue";
            txtFirstNameValue.Size = new Size(238, 23);
            txtFirstNameValue.TabIndex = 1;
            // 
            // txtFirstNameName
            // 
            txtFirstNameName.BackColor = Color.FromArgb(197, 216, 238);
            txtFirstNameName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstNameName.ForeColor = Color.FromArgb(18, 49, 85);
            txtFirstNameName.Location = new Point(12, 86);
            txtFirstNameName.Margin = new Padding(4, 3, 4, 3);
            txtFirstNameName.Name = "txtFirstNameName";
            txtFirstNameName.ReadOnly = true;
            txtFirstNameName.Size = new Size(70, 23);
            txtFirstNameName.TabIndex = 2;
            txtFirstNameName.Text = "Անուն";
            // 
            // txtLastNameValue
            // 
            txtLastNameValue.BackColor = Color.White;
            txtLastNameValue.BorderStyle = BorderStyle.FixedSingle;
            txtLastNameValue.Location = new Point(90, 115);
            txtLastNameValue.Margin = new Padding(4, 3, 4, 3);
            txtLastNameValue.Name = "txtLastNameValue";
            txtLastNameValue.Size = new Size(238, 23);
            txtLastNameValue.TabIndex = 1;
            // 
            // txtLastNameName
            // 
            txtLastNameName.BackColor = Color.FromArgb(197, 216, 238);
            txtLastNameName.BorderStyle = BorderStyle.FixedSingle;
            txtLastNameName.ForeColor = Color.FromArgb(18, 49, 85);
            txtLastNameName.Location = new Point(12, 115);
            txtLastNameName.Margin = new Padding(4, 3, 4, 3);
            txtLastNameName.Name = "txtLastNameName";
            txtLastNameName.ReadOnly = true;
            txtLastNameName.Size = new Size(70, 23);
            txtLastNameName.TabIndex = 2;
            txtLastNameName.Text = "Ազգանուն";
            // 
            // txtDeparmentName
            // 
            txtDeparmentName.BackColor = Color.FromArgb(197, 216, 238);
            txtDeparmentName.BorderStyle = BorderStyle.FixedSingle;
            txtDeparmentName.ForeColor = Color.FromArgb(18, 49, 85);
            txtDeparmentName.Location = new Point(12, 144);
            txtDeparmentName.Margin = new Padding(4, 3, 4, 3);
            txtDeparmentName.Name = "txtDeparmentName";
            txtDeparmentName.ReadOnly = true;
            txtDeparmentName.Size = new Size(70, 23);
            txtDeparmentName.TabIndex = 2;
            txtDeparmentName.Text = "Բաժին";
            // 
            // txtDepartmentValue
            // 
            txtDepartmentValue.BackColor = Color.White;
            txtDepartmentValue.BorderStyle = BorderStyle.FixedSingle;
            txtDepartmentValue.Location = new Point(90, 144);
            txtDepartmentValue.Margin = new Padding(4, 3, 4, 3);
            txtDepartmentValue.Name = "txtDepartmentValue";
            txtDepartmentValue.Size = new Size(238, 23);
            txtDepartmentValue.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(128, 146, 203);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Location = new Point(12, 186);
            btnAdd.Margin = new Padding(4, 3, 4, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 30);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Ավելացնել";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(128, 146, 203);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Location = new Point(120, 186);
            btnCancel.Margin = new Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 30);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Չեղարկել";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnGoToMain
            // 
            btnGoToMain.BackColor = Color.FromArgb(128, 146, 203);
            btnGoToMain.FlatStyle = FlatStyle.Flat;
            btnGoToMain.Location = new Point(228, 230);
            btnGoToMain.Margin = new Padding(4, 3, 4, 3);
            btnGoToMain.Name = "btnGoToMain";
            btnGoToMain.Size = new Size(100, 30);
            btnGoToMain.TabIndex = 5;
            btnGoToMain.Text = "Գլխավոր մենյու";
            btnGoToMain.UseVisualStyleBackColor = false;
            btnGoToMain.Click += btnGoToMain_Click;
            // 
            // btnAll
            // 
            btnAll.BackColor = Color.FromArgb(128, 146, 203);
            btnAll.FlatStyle = FlatStyle.Flat;
            btnAll.Location = new Point(228, 186);
            btnAll.Margin = new Padding(4, 3, 4, 3);
            btnAll.Name = "btnAll";
            btnAll.Size = new Size(100, 30);
            btnAll.TabIndex = 5;
            btnAll.Text = "Դիտել բոլորը";
            btnAll.UseVisualStyleBackColor = false;
            btnAll.Click += btnAll_Click;
            // 
            // picAddMain
            // 
            picAddMain.Image = (Image)resources.GetObject("picAddMain.Image");
            picAddMain.Location = new Point(335, -5);
            picAddMain.Name = "picAddMain";
            picAddMain.Size = new Size(221, 276);
            picAddMain.TabIndex = 6;
            picAddMain.TabStop = false;
            // 
            // picAddAdd
            // 
            picAddAdd.Image = (Image)resources.GetObject("picAddAdd.Image");
            picAddAdd.Location = new Point(12, 12);
            picAddAdd.Name = "picAddAdd";
            picAddAdd.Size = new Size(40, 40);
            picAddAdd.TabIndex = 7;
            picAddAdd.TabStop = false;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(157, 171, 215);
            ClientSize = new Size(556, 272);
            ControlBox = false;
            Controls.Add(picAddAdd);
            Controls.Add(picAddMain);
            Controls.Add(btnAll);
            Controls.Add(btnGoToMain);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(txtDepartmentValue);
            Controls.Add(txtDeparmentName);
            Controls.Add(txtLastNameName);
            Controls.Add(txtFirstNameName);
            Controls.Add(txtCodeName);
            Controls.Add(txtLastNameValue);
            Controls.Add(txtFirstNameValue);
            Controls.Add(txtCodeValue);
            Controls.Add(txtAddTitle);
            Margin = new Padding(4, 3, 4, 3);
            Name = "AddForm";
            Text = "AddForm";
            ((System.ComponentModel.ISupportInitialize)picAddMain).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAddAdd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAddTitle;
        private TextBox txtCodeValue;
        private TextBox txtCodeName;
        private TextBox txtFirstNameValue;
        private TextBox txtFirstNameName;
        private TextBox txtLastNameValue;
        private TextBox txtLastNameName;
        private TextBox txtDeparmentName;
        private TextBox txtDepartmentValue;
        private Button btnAdd;
        private Button btnCancel;
        private Button btnGoToMain;
        private Button btnAll;
        private PictureBox picAddMain;
        private PictureBox picAddAdd;
    }
}