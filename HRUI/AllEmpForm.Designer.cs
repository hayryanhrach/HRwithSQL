namespace HRForms
{
    partial class AllEmpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllEmpForm));
            txtFindName = new TextBox();
            txtFindValue = new TextBox();
            btnDelateAll = new Button();
            btnDelate = new Button();
            btnAdd = new Button();
            btnGoToMain = new Button();
            picAllAll = new PictureBox();
            picAllSearch = new PictureBox();
            AllEmpDataGridView = new DataGridView();
            Կոդ = new DataGridViewTextBoxColumn();
            Անուն = new DataGridViewTextBoxColumn();
            Ազգանուն = new DataGridViewTextBoxColumn();
            Բաժին = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)picAllAll).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAllSearch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AllEmpDataGridView).BeginInit();
            SuspendLayout();
            // 
            // txtFindName
            // 
            txtFindName.BackColor = Color.FromArgb(157, 171, 215);
            txtFindName.BorderStyle = BorderStyle.FixedSingle;
            txtFindName.Font = new Font("Courgette", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtFindName.ForeColor = Color.FromArgb(18, 49, 85);
            txtFindName.Location = new Point(37, 11);
            txtFindName.Name = "txtFindName";
            txtFindName.ReadOnly = true;
            txtFindName.Size = new Size(61, 24);
            txtFindName.TabIndex = 2;
            txtFindName.Text = "Փնտրել";
            // 
            // txtFindValue
            // 
            txtFindValue.BackColor = Color.White;
            txtFindValue.BorderStyle = BorderStyle.FixedSingle;
            txtFindValue.Location = new Point(104, 11);
            txtFindValue.Name = "txtFindValue";
            txtFindValue.Size = new Size(471, 23);
            txtFindValue.TabIndex = 3;
            // 
            // btnDelateAll
            // 
            btnDelateAll.BackColor = Color.FromArgb(128, 146, 203);
            btnDelateAll.FlatStyle = FlatStyle.Flat;
            btnDelateAll.Location = new Point(592, 227);
            btnDelateAll.Name = "btnDelateAll";
            btnDelateAll.Size = new Size(117, 33);
            btnDelateAll.TabIndex = 1;
            btnDelateAll.Text = "Ջնջել բոլորը";
            btnDelateAll.UseVisualStyleBackColor = false;
            btnDelateAll.Click += btnDelateAll_Click;
            // 
            // btnDelate
            // 
            btnDelate.BackColor = Color.FromArgb(128, 146, 203);
            btnDelate.FlatStyle = FlatStyle.Flat;
            btnDelate.Location = new Point(592, 188);
            btnDelate.Name = "btnDelate";
            btnDelate.Size = new Size(117, 33);
            btnDelate.TabIndex = 1;
            btnDelate.Text = "Ջնջել";
            btnDelate.UseVisualStyleBackColor = false;
            btnDelate.Click += btnDelate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(128, 146, 203);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Location = new Point(590, 149);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(117, 33);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Ավելացնել";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnGoToMain
            // 
            btnGoToMain.BackColor = Color.FromArgb(128, 146, 203);
            btnGoToMain.FlatStyle = FlatStyle.Flat;
            btnGoToMain.Location = new Point(592, 266);
            btnGoToMain.Name = "btnGoToMain";
            btnGoToMain.Size = new Size(117, 33);
            btnGoToMain.TabIndex = 1;
            btnGoToMain.Text = "Գլխավոր մենյու";
            btnGoToMain.UseVisualStyleBackColor = false;
            btnGoToMain.Click += btnGoToMain_Click;
            // 
            // picAllAll
            // 
            picAllAll.Image = (Image)resources.GetObject("picAllAll.Image");
            picAllAll.Location = new Point(590, 12);
            picAllAll.Name = "picAllAll";
            picAllAll.Size = new Size(117, 117);
            picAllAll.TabIndex = 4;
            picAllAll.TabStop = false;
            // 
            // picAllSearch
            // 
            picAllSearch.Image = (Image)resources.GetObject("picAllSearch.Image");
            picAllSearch.Location = new Point(12, 11);
            picAllSearch.Name = "picAllSearch";
            picAllSearch.Size = new Size(24, 24);
            picAllSearch.TabIndex = 5;
            picAllSearch.TabStop = false;
            // 
            // AllEmpDataGridView
            // 
            AllEmpDataGridView.BackgroundColor = Color.FromArgb(197, 216, 238);
            AllEmpDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AllEmpDataGridView.Columns.AddRange(new DataGridViewColumn[] { Կոդ, Անուն, Ազգանուն, Բաժին });
            AllEmpDataGridView.Location = new Point(12, 41);
            AllEmpDataGridView.Name = "AllEmpDataGridView";
            AllEmpDataGridView.RowTemplate.Height = 25;
            AllEmpDataGridView.ScrollBars = ScrollBars.Vertical;
            AllEmpDataGridView.Size = new Size(563, 258);
            AllEmpDataGridView.TabIndex = 6;
            // 
            // Կոդ
            // 
            Կոդ.Frozen = true;
            Կոդ.HeaderText = "Կոդ";
            Կոդ.Name = "Կոդ";
            Կոդ.ReadOnly = true;
            Կոդ.Width = 80;
            // 
            // Անուն
            // 
            Անուն.Frozen = true;
            Անուն.HeaderText = "Անուն";
            Անուն.Name = "Անուն";
            Անուն.ReadOnly = true;
            Անուն.Width = 160;
            // 
            // Ազգանուն
            // 
            Ազգանուն.Frozen = true;
            Ազգանուն.HeaderText = "Ազգանուն";
            Ազգանուն.Name = "Ազգանուն";
            Ազգանուն.ReadOnly = true;
            Ազգանուն.Width = 160;
            // 
            // Բաժին
            // 
            Բաժին.Frozen = true;
            Բաժին.HeaderText = "Բաժին";
            Բաժին.Name = "Բաժին";
            Բաժին.ReadOnly = true;
            Բաժին.Width = 120;
            // 
            // AllEmpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(157, 171, 215);
            ClientSize = new Size(719, 388);
            ControlBox = false;
            Controls.Add(AllEmpDataGridView);
            Controls.Add(picAllSearch);
            Controls.Add(picAllAll);
            Controls.Add(txtFindValue);
            Controls.Add(txtFindName);
            Controls.Add(btnAdd);
            Controls.Add(btnDelate);
            Controls.Add(btnGoToMain);
            Controls.Add(btnDelateAll);
            Name = "AllEmpForm";
            Text = "AllEmpForm";
            ((System.ComponentModel.ISupportInitialize)picAllAll).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAllSearch).EndInit();
            ((System.ComponentModel.ISupportInitialize)AllEmpDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtFindName;
        private TextBox txtFindValue;
        private Button btnDelateAll;
        private Button btnDelate;
        private Button btnAdd;
        private Button btnGoToMain;
        private PictureBox picAllAll;
        private PictureBox picAllSearch;
        private DataGridView AllEmpDataGridView;
        private DataGridViewTextBoxColumn Կոդ;
        private DataGridViewTextBoxColumn Անուն;
        private DataGridViewTextBoxColumn Ազգանուն;
        private DataGridViewTextBoxColumn Բաժին;
    }
}