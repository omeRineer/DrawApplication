namespace DrawApplication
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button btnSave;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Button btnOpenFile;
            System.Windows.Forms.Button btnClear;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbShapes = new System.Windows.Forms.ComboBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            btnSave = new System.Windows.Forms.Button();
            btnOpenFile = new System.Windows.Forms.Button();
            btnClear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnSave.Location = new System.Drawing.Point(932, 518);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(86, 74);
            btnSave.TabIndex = 0;
            btnSave.Tag = "Kaydet";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnOpenFile
            // 
            btnOpenFile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOpenFile.BackgroundImage")));
            btnOpenFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnOpenFile.Location = new System.Drawing.Point(1023, 518);
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.Size = new System.Drawing.Size(86, 74);
            btnOpenFile.TabIndex = 0;
            btnOpenFile.Tag = "Dosya Aç";
            btnOpenFile.UseVisualStyleBackColor = true;
            btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnClear
            // 
            btnClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClear.BackgroundImage")));
            btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnClear.Location = new System.Drawing.Point(1115, 518);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(86, 74);
            btnClear.TabIndex = 0;
            btnClear.Tag = "Temizle";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbShapes);
            this.groupBox1.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(952, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 166);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Şekiller";
            // 
            // cmbShapes
            // 
            this.cmbShapes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShapes.FormattingEnabled = true;
            this.cmbShapes.Location = new System.Drawing.Point(20, 81);
            this.cmbShapes.Name = "cmbShapes";
            this.cmbShapes.Size = new System.Drawing.Size(192, 37);
            this.cmbShapes.TabIndex = 0;
            this.cmbShapes.SelectedValueChanged += new System.EventHandler(this.cmbShapes_SelectedValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(900, 580);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // groupBox2
            // 
            this.groupBox2.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(952, 197);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(230, 315);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Renkler";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 604);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(btnClear);
            this.Controls.Add(btnOpenFile);
            this.Controls.Add(btnSave);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbShapes;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}
