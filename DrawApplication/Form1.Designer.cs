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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.cmbColors = new System.Windows.Forms.ComboBox();
            this.listShapes = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.lblW = new System.Windows.Forms.Label();
            this.lblH = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            btnOpenFile = new System.Windows.Forms.Button();
            btnClear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
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
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(900, 580);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Controls.Add(this.cmbColors);
            this.groupBox2.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(952, 197);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(230, 149);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Renkler";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 29;
            this.listBox1.Location = new System.Drawing.Point(20, 100);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(192, 33);
            this.listBox1.TabIndex = 2;
            // 
            // cmbColors
            // 
            this.cmbColors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColors.FormattingEnabled = true;
            this.cmbColors.Location = new System.Drawing.Point(20, 57);
            this.cmbColors.Name = "cmbColors";
            this.cmbColors.Size = new System.Drawing.Size(192, 37);
            this.cmbColors.TabIndex = 1;
            this.cmbColors.SelectedIndexChanged += new System.EventHandler(this.cmbColors_SelectedIndexChanged);
            // 
            // listShapes
            // 
            this.listShapes.FormattingEnabled = true;
            this.listShapes.ItemHeight = 15;
            this.listShapes.Location = new System.Drawing.Point(952, 364);
            this.listShapes.Name = "listShapes";
            this.listShapes.Size = new System.Drawing.Size(112, 109);
            this.listShapes.TabIndex = 5;
            this.listShapes.SelectedIndexChanged += new System.EventHandler(this.listShapes_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(1081, 373);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "X :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(1081, 408);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Y :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(1077, 442);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "W :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(1079, 476);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "H :";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblX.ForeColor = System.Drawing.Color.Blue;
            this.lblX.Location = new System.Drawing.Point(1115, 373);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(22, 18);
            this.lblX.TabIndex = 6;
            this.lblX.Text = "00";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblY.ForeColor = System.Drawing.Color.Blue;
            this.lblY.Location = new System.Drawing.Point(1115, 408);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(22, 18);
            this.lblY.TabIndex = 6;
            this.lblY.Text = "00";
            // 
            // lblW
            // 
            this.lblW.AutoSize = true;
            this.lblW.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblW.ForeColor = System.Drawing.Color.Blue;
            this.lblW.Location = new System.Drawing.Point(1115, 442);
            this.lblW.Name = "lblW";
            this.lblW.Size = new System.Drawing.Size(22, 18);
            this.lblW.TabIndex = 6;
            this.lblW.Text = "00";
            // 
            // lblH
            // 
            this.lblH.AutoSize = true;
            this.lblH.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblH.ForeColor = System.Drawing.Color.Blue;
            this.lblH.Location = new System.Drawing.Point(1115, 476);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(22, 18);
            this.lblH.TabIndex = 6;
            this.lblH.Text = "00";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(952, 479);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(112, 33);
            this.btnSil.TabIndex = 7;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 604);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.lblH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblW);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listShapes);
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
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbShapes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox cmbColors;
        private System.Windows.Forms.ListBox listShapes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblW;
        private System.Windows.Forms.Label lblH;
        private System.Windows.Forms.Button btnSil;
    }
}
