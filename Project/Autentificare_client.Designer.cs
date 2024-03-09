namespace Good_Food
{
    partial class Autentificare_client
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
            this.lblemail2 = new System.Windows.Forms.Label();
            this.lblparola2 = new System.Windows.Forms.Label();
            this.txtbemail2 = new System.Windows.Forms.TextBox();
            this.txtbparola2 = new System.Windows.Forms.TextBox();
            this.btnintrare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblemail2
            // 
            this.lblemail2.AutoSize = true;
            this.lblemail2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail2.Location = new System.Drawing.Point(84, 89);
            this.lblemail2.Name = "lblemail2";
            this.lblemail2.Size = new System.Drawing.Size(51, 20);
            this.lblemail2.TabIndex = 0;
            this.lblemail2.Text = "Email";
            this.lblemail2.Click += new System.EventHandler(this.lblemail2_Click);
            // 
            // lblparola2
            // 
            this.lblparola2.AutoSize = true;
            this.lblparola2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblparola2.Location = new System.Drawing.Point(84, 161);
            this.lblparola2.Name = "lblparola2";
            this.lblparola2.Size = new System.Drawing.Size(57, 20);
            this.lblparola2.TabIndex = 1;
            this.lblparola2.Text = "Parola";
            // 
            // txtbemail2
            // 
            this.txtbemail2.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbemail2.Location = new System.Drawing.Point(281, 85);
            this.txtbemail2.Name = "txtbemail2";
            this.txtbemail2.Size = new System.Drawing.Size(224, 24);
            this.txtbemail2.TabIndex = 2;
            // 
            // txtbparola2
            // 
            this.txtbparola2.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbparola2.Location = new System.Drawing.Point(281, 157);
            this.txtbparola2.Name = "txtbparola2";
            this.txtbparola2.PasswordChar = '*';
            this.txtbparola2.Size = new System.Drawing.Size(224, 24);
            this.txtbparola2.TabIndex = 3;
            // 
            // btnintrare
            // 
            this.btnintrare.Location = new System.Drawing.Point(218, 245);
            this.btnintrare.Name = "btnintrare";
            this.btnintrare.Size = new System.Drawing.Size(152, 37);
            this.btnintrare.TabIndex = 4;
            this.btnintrare.Text = "Intrare in cont";
            this.btnintrare.UseVisualStyleBackColor = true;
            this.btnintrare.Click += new System.EventHandler(this.btnintrare_Click);
            // 
            // Autentificare_client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(619, 305);
            this.Controls.Add(this.btnintrare);
            this.Controls.Add(this.txtbparola2);
            this.Controls.Add(this.txtbemail2);
            this.Controls.Add(this.lblparola2);
            this.Controls.Add(this.lblemail2);
            this.Name = "Autentificare_client";
            this.Text = "Autentificare_client";
            this.Load += new System.EventHandler(this.Autentificare_client_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblemail2;
        private System.Windows.Forms.Label lblparola2;
        private System.Windows.Forms.TextBox txtbemail2;
        private System.Windows.Forms.TextBox txtbparola2;
        private System.Windows.Forms.Button btnintrare;
    }
}