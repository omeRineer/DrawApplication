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
            System.Windows.Forms.Button button1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Button button2;
            System.Windows.Forms.Button button3;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            button1.Location = new System.Drawing.Point(932, 518);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(86, 74);
            button1.TabIndex = 0;
            button1.Tag = "Kaydet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            button2.Location = new System.Drawing.Point(1023, 518);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(86, 74);
            button2.TabIndex = 0;
            button2.Tag = "Dosya Aç";
            button2.UseVisualStyleBackColor = true;
            button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            button3.Location = new System.Drawing.Point(1115, 518);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(86, 74);
            button3.TabIndex = 0;
            button3.Tag = "Temizle";
            button3.UseVisualStyleBackColor = true;
            button3.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(932, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 500);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İşlemler";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 604);
            this.Controls.Add(button3);
            this.Controls.Add(button2);
            this.Controls.Add(button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
