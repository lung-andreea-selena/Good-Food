namespace Good_Food
{
    partial class Start
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblstart = new System.Windows.Forms.Label();
            this.btninregistrare = new System.Windows.Forms.Button();
            this.btnautentificare = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Good_Food.Properties.Resources.good_food_1;
            this.pictureBox1.Location = new System.Drawing.Point(54, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(371, 392);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblstart
            // 
            this.lblstart.AutoSize = true;
            this.lblstart.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstart.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblstart.Location = new System.Drawing.Point(47, 23);
            this.lblstart.Name = "lblstart";
            this.lblstart.Size = new System.Drawing.Size(638, 37);
            this.lblstart.TabIndex = 1;
            this.lblstart.Text = "Meniuri personalizate pentru oameni cu personalitate";
            // 
            // btninregistrare
            // 
            this.btninregistrare.BackColor = System.Drawing.Color.Khaki;
            this.btninregistrare.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btninregistrare.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninregistrare.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btninregistrare.Location = new System.Drawing.Point(485, 201);
            this.btninregistrare.Name = "btninregistrare";
            this.btninregistrare.Size = new System.Drawing.Size(190, 59);
            this.btninregistrare.TabIndex = 2;
            this.btninregistrare.Text = "Inregistrare";
            this.btninregistrare.UseVisualStyleBackColor = false;
            this.btninregistrare.Click += new System.EventHandler(this.btninregistrare_Click);
            // 
            // btnautentificare
            // 
            this.btnautentificare.BackColor = System.Drawing.Color.Khaki;
            this.btnautentificare.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnautentificare.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnautentificare.Location = new System.Drawing.Point(485, 317);
            this.btnautentificare.Name = "btnautentificare";
            this.btnautentificare.Size = new System.Drawing.Size(190, 59);
            this.btnautentificare.TabIndex = 3;
            this.btnautentificare.Text = "Autentificare";
            this.btnautentificare.UseVisualStyleBackColor = false;
            this.btnautentificare.Click += new System.EventHandler(this.btnautentificare_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.Location = new System.Drawing.Point(140, 502);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(483, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Proiect realizat de Lung Andreea Selena";
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(800, 560);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnautentificare);
            this.Controls.Add(this.btninregistrare);
            this.Controls.Add(this.lblstart);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Start";
            this.Text = "Start";
            this.Load += new System.EventHandler(this.Start_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblstart;
        private System.Windows.Forms.Button btninregistrare;
        private System.Windows.Forms.Button btnautentificare;
        private System.Windows.Forms.Label label1;
    }
}

