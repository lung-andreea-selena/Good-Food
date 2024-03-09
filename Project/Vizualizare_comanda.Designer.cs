namespace Good_Food
{
    partial class Vizualizare_comanda
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Numeprodus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kcal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pret = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantitate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Elimina = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblneces3 = new System.Windows.Forms.Label();
            this.tbneces = new System.Windows.Forms.TextBox();
            this.lbltotalkc = new System.Windows.Forms.Label();
            this.lblprettot = new System.Windows.Forms.Label();
            this.tbtotalkcal = new System.Windows.Forms.TextBox();
            this.tbprettot = new System.Windows.Forms.TextBox();
            this.btnfinalizare = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numeprodus,
            this.kcal,
            this.pret,
            this.cantitate,
            this.Elimina});
            this.dataGridView2.Location = new System.Drawing.Point(12, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(927, 284);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Numeprodus
            // 
            this.Numeprodus.HeaderText = "Nume produs";
            this.Numeprodus.MinimumWidth = 6;
            this.Numeprodus.Name = "Numeprodus";
            this.Numeprodus.ReadOnly = true;
            this.Numeprodus.Width = 125;
            // 
            // kcal
            // 
            this.kcal.HeaderText = "kcal";
            this.kcal.MinimumWidth = 6;
            this.kcal.Name = "kcal";
            this.kcal.ReadOnly = true;
            this.kcal.Width = 125;
            // 
            // pret
            // 
            this.pret.HeaderText = "pret";
            this.pret.MinimumWidth = 6;
            this.pret.Name = "pret";
            this.pret.ReadOnly = true;
            this.pret.Width = 125;
            // 
            // cantitate
            // 
            this.cantitate.HeaderText = "Cantitate";
            this.cantitate.MinimumWidth = 6;
            this.cantitate.Name = "cantitate";
            this.cantitate.ReadOnly = true;
            this.cantitate.Width = 125;
            // 
            // Elimina
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "Elimina";
            this.Elimina.DefaultCellStyle = dataGridViewCellStyle1;
            this.Elimina.HeaderText = "Elimina";
            this.Elimina.MinimumWidth = 6;
            this.Elimina.Name = "Elimina";
            this.Elimina.ReadOnly = true;
            this.Elimina.Width = 125;
            // 
            // lblneces3
            // 
            this.lblneces3.AutoSize = true;
            this.lblneces3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblneces3.Location = new System.Drawing.Point(21, 339);
            this.lblneces3.Name = "lblneces3";
            this.lblneces3.Size = new System.Drawing.Size(112, 20);
            this.lblneces3.TabIndex = 1;
            this.lblneces3.Text = "Necesar zilnic:";
            // 
            // tbneces
            // 
            this.tbneces.Location = new System.Drawing.Point(149, 336);
            this.tbneces.Name = "tbneces";
            this.tbneces.Size = new System.Drawing.Size(100, 22);
            this.tbneces.TabIndex = 2;
            // 
            // lbltotalkc
            // 
            this.lbltotalkc.AutoSize = true;
            this.lbltotalkc.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalkc.Location = new System.Drawing.Point(21, 390);
            this.lbltotalkc.Name = "lbltotalkc";
            this.lbltotalkc.Size = new System.Drawing.Size(82, 20);
            this.lbltotalkc.TabIndex = 3;
            this.lbltotalkc.Text = "Total kcal:";
            // 
            // lblprettot
            // 
            this.lblprettot.AutoSize = true;
            this.lblprettot.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprettot.Location = new System.Drawing.Point(21, 439);
            this.lblprettot.Name = "lblprettot";
            this.lblprettot.Size = new System.Drawing.Size(81, 20);
            this.lblprettot.TabIndex = 4;
            this.lblprettot.Text = "Pret total:";
            // 
            // tbtotalkcal
            // 
            this.tbtotalkcal.Location = new System.Drawing.Point(149, 388);
            this.tbtotalkcal.Name = "tbtotalkcal";
            this.tbtotalkcal.Size = new System.Drawing.Size(100, 22);
            this.tbtotalkcal.TabIndex = 5;
            // 
            // tbprettot
            // 
            this.tbprettot.Location = new System.Drawing.Point(149, 437);
            this.tbprettot.Name = "tbprettot";
            this.tbprettot.Size = new System.Drawing.Size(100, 22);
            this.tbprettot.TabIndex = 6;
            // 
            // btnfinalizare
            // 
            this.btnfinalizare.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfinalizare.Location = new System.Drawing.Point(401, 439);
            this.btnfinalizare.Name = "btnfinalizare";
            this.btnfinalizare.Size = new System.Drawing.Size(122, 41);
            this.btnfinalizare.TabIndex = 7;
            this.btnfinalizare.Text = "Finalizare";
            this.btnfinalizare.UseVisualStyleBackColor = true;
            this.btnfinalizare.Click += new System.EventHandler(this.btnfinalizare_Click);
            // 
            // Vizualizare_comanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(951, 492);
            this.Controls.Add(this.btnfinalizare);
            this.Controls.Add(this.tbprettot);
            this.Controls.Add(this.tbtotalkcal);
            this.Controls.Add(this.lblprettot);
            this.Controls.Add(this.lbltotalkc);
            this.Controls.Add(this.tbneces);
            this.Controls.Add(this.lblneces3);
            this.Controls.Add(this.dataGridView2);
            this.Name = "Vizualizare_comanda";
            this.Text = "Vizualizare Comanda";
            this.Load += new System.EventHandler(this.Vizualizare_comanda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label lblneces3;
        private System.Windows.Forms.TextBox tbneces;
        private System.Windows.Forms.Label lbltotalkc;
        private System.Windows.Forms.Label lblprettot;
        private System.Windows.Forms.TextBox tbtotalkcal;
        private System.Windows.Forms.TextBox tbprettot;
        private System.Windows.Forms.Button btnfinalizare;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numeprodus;
        private System.Windows.Forms.DataGridViewTextBoxColumn kcal;
        private System.Windows.Forms.DataGridViewTextBoxColumn pret;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantitate;
        private System.Windows.Forms.DataGridViewButtonColumn Elimina;
    }
}