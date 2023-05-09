namespace HRForms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btbAdd = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.picMainMain = new System.Windows.Forms.PictureBox();
            this.picMainAdd = new System.Windows.Forms.PictureBox();
            this.picMainAll = new System.Windows.Forms.PictureBox();
            this.picMainExit = new System.Windows.Forms.PictureBox();
            this.btnHelp = new System.Windows.Forms.Button();
            this.picMainHelp = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picMainMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMainAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMainAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMainExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMainHelp)).BeginInit();
            this.SuspendLayout();
            // 
            // btbAdd
            // 
            this.btbAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(146)))), ((int)(((byte)(203)))));
            this.btbAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btbAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btbAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btbAdd.Location = new System.Drawing.Point(545, 28);
            this.btbAdd.Name = "btbAdd";
            this.btbAdd.Size = new System.Drawing.Size(142, 29);
            this.btbAdd.TabIndex = 0;
            this.btbAdd.Text = "Ավելացնել";
            this.btbAdd.UseVisualStyleBackColor = false;
            this.btbAdd.Click += new System.EventHandler(this.btbAdd_Click);
            // 
            // btnAll
            // 
            this.btnAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(146)))), ((int)(((byte)(203)))));
            this.btnAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAll.Location = new System.Drawing.Point(545, 78);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(142, 29);
            this.btnAll.TabIndex = 0;
            this.btnAll.Text = "Դիտել բոլորը";
            this.btnAll.UseVisualStyleBackColor = false;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(146)))), ((int)(((byte)(203)))));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(545, 125);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(142, 29);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Աշխատանքի ավարտ";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // picMainMain
            // 
            this.picMainMain.Image = ((System.Drawing.Image)(resources.GetObject("picMainMain.Image")));
            this.picMainMain.Location = new System.Drawing.Point(-9, -4);
            this.picMainMain.Name = "picMainMain";
            this.picMainMain.Size = new System.Drawing.Size(501, 347);
            this.picMainMain.TabIndex = 1;
            this.picMainMain.TabStop = false;
            // 
            // picMainAdd
            // 
            this.picMainAdd.Image = ((System.Drawing.Image)(resources.GetObject("picMainAdd.Image")));
            this.picMainAdd.Location = new System.Drawing.Point(503, 28);
            this.picMainAdd.Name = "picMainAdd";
            this.picMainAdd.Size = new System.Drawing.Size(29, 29);
            this.picMainAdd.TabIndex = 2;
            this.picMainAdd.TabStop = false;
            // 
            // picMainAll
            // 
            this.picMainAll.Image = ((System.Drawing.Image)(resources.GetObject("picMainAll.Image")));
            this.picMainAll.Location = new System.Drawing.Point(503, 78);
            this.picMainAll.Name = "picMainAll";
            this.picMainAll.Size = new System.Drawing.Size(29, 29);
            this.picMainAll.TabIndex = 2;
            this.picMainAll.TabStop = false;
            // 
            // picMainExit
            // 
            this.picMainExit.Image = ((System.Drawing.Image)(resources.GetObject("picMainExit.Image")));
            this.picMainExit.Location = new System.Drawing.Point(503, 125);
            this.picMainExit.Name = "picMainExit";
            this.picMainExit.Size = new System.Drawing.Size(29, 29);
            this.picMainExit.TabIndex = 2;
            this.picMainExit.TabStop = false;
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(146)))), ((int)(((byte)(203)))));
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Location = new System.Drawing.Point(545, 175);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(142, 29);
            this.btnHelp.TabIndex = 0;
            this.btnHelp.Text = "Օգնություն";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // picMainHelp
            // 
            this.picMainHelp.Image = ((System.Drawing.Image)(resources.GetObject("picMainHelp.Image")));
            this.picMainHelp.Location = new System.Drawing.Point(503, 175);
            this.picMainHelp.Name = "picMainHelp";
            this.picMainHelp.Size = new System.Drawing.Size(29, 29);
            this.picMainHelp.TabIndex = 2;
            this.picMainHelp.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(171)))), ((int)(((byte)(215)))));
            this.ClientSize = new System.Drawing.Size(699, 336);
            this.ControlBox = false;
            this.Controls.Add(this.picMainHelp);
            this.Controls.Add(this.picMainExit);
            this.Controls.Add(this.picMainAll);
            this.Controls.Add(this.picMainAdd);
            this.Controls.Add(this.picMainMain);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.btbAdd);
            this.Name = "MainForm";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.picMainMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMainAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMainAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMainExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMainHelp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btbAdd;
        private Button btnAll;
        private Button btnExit;
        private PictureBox picMainMain;
        private PictureBox picMainAdd;
        private PictureBox picMainAll;
        private PictureBox picMainExit;
        private Button btnHelp;
        private PictureBox picMainHelp;
    }
}