namespace Good_Food
{
    partial class Optiuni
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabcontrol = new System.Windows.Forms.TabControl();
            this.tpcalckcal = new System.Windows.Forms.TabPage();
            this.lblrez = new System.Windows.Forms.Label();
            this.lblneces1 = new System.Windows.Forms.Label();
            this.btncalcul = new System.Windows.Forms.Button();
            this.tbinaltime = new System.Windows.Forms.TextBox();
            this.tbgreutate = new System.Windows.Forms.TextBox();
            this.tbvarsta = new System.Windows.Forms.TextBox();
            this.lblinaltime = new System.Windows.Forms.Label();
            this.lblgreutate = new System.Windows.Forms.Label();
            this.lblvarsta = new System.Windows.Forms.Label();
            this.tpcomanda = new System.Windows.Forms.TabPage();
            this.btncomanda = new System.Windows.Forms.Button();
            this.txtbtotalp = new System.Windows.Forms.TextBox();
            this.txtbtotalk = new System.Windows.Forms.TextBox();
            this.lblprettotal = new System.Windows.Forms.Label();
            this.lbltotalkcal = new System.Windows.Forms.Label();
            this.txtbneces = new System.Windows.Forms.TextBox();
            this.lblnecesarzilnic = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idprodusDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denumireprodusDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriereDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pretDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kcalDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.felulDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantitatee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adauga = new System.Windows.Forms.DataGridViewButtonColumn();
            this.meniuBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gOODFOODDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gOOD_FOODDataSet = new Good_Food.GOOD_FOODDataSet();
            this.gOODFOODDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.meniuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.meniuTableAdapter = new Good_Food.GOOD_FOODDataSetTableAdapters.MeniuTableAdapter();
            this.idprodusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denumireprodusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriereDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pretDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kcalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.felulDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabcontrol.SuspendLayout();
            this.tpcalckcal.SuspendLayout();
            this.tpcomanda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meniuBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gOODFOODDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gOOD_FOODDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gOODFOODDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meniuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabcontrol
            // 
            this.tabcontrol.Controls.Add(this.tpcalckcal);
            this.tabcontrol.Controls.Add(this.tpcomanda);
            this.tabcontrol.Location = new System.Drawing.Point(1, 1);
            this.tabcontrol.Name = "tabcontrol";
            this.tabcontrol.SelectedIndex = 0;
            this.tabcontrol.Size = new System.Drawing.Size(952, 525);
            this.tabcontrol.TabIndex = 0;
            // 
            // tpcalckcal
            // 
            this.tpcalckcal.BackColor = System.Drawing.Color.Beige;
            this.tpcalckcal.Controls.Add(this.lblrez);
            this.tpcalckcal.Controls.Add(this.lblneces1);
            this.tpcalckcal.Controls.Add(this.btncalcul);
            this.tpcalckcal.Controls.Add(this.tbinaltime);
            this.tpcalckcal.Controls.Add(this.tbgreutate);
            this.tpcalckcal.Controls.Add(this.tbvarsta);
            this.tpcalckcal.Controls.Add(this.lblinaltime);
            this.tpcalckcal.Controls.Add(this.lblgreutate);
            this.tpcalckcal.Controls.Add(this.lblvarsta);
            this.tpcalckcal.Location = new System.Drawing.Point(4, 25);
            this.tpcalckcal.Name = "tpcalckcal";
            this.tpcalckcal.Padding = new System.Windows.Forms.Padding(3);
            this.tpcalckcal.Size = new System.Drawing.Size(944, 496);
            this.tpcalckcal.TabIndex = 0;
            this.tpcalckcal.Text = "CalculatorKcal";
            // 
            // lblrez
            // 
            this.lblrez.AutoSize = true;
            this.lblrez.BackColor = System.Drawing.Color.LightGray;
            this.lblrez.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblrez.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrez.Location = new System.Drawing.Point(705, 208);
            this.lblrez.Name = "lblrez";
            this.lblrez.Size = new System.Drawing.Size(2, 21);
            this.lblrez.TabIndex = 8;
            // 
            // lblneces1
            // 
            this.lblneces1.AutoSize = true;
            this.lblneces1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblneces1.Location = new System.Drawing.Point(587, 209);
            this.lblneces1.Name = "lblneces1";
            this.lblneces1.Size = new System.Drawing.Size(112, 20);
            this.lblneces1.TabIndex = 7;
            this.lblneces1.Text = "Necesar zilnic:";
            // 
            // btncalcul
            // 
            this.btncalcul.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcul.Location = new System.Drawing.Point(173, 377);
            this.btncalcul.Name = "btncalcul";
            this.btncalcul.Size = new System.Drawing.Size(127, 50);
            this.btncalcul.TabIndex = 6;
            this.btncalcul.Text = "Calculeaza";
            this.btncalcul.UseVisualStyleBackColor = true;
            this.btncalcul.Click += new System.EventHandler(this.btncalcul_Click);
            // 
            // tbinaltime
            // 
            this.tbinaltime.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbinaltime.Location = new System.Drawing.Point(220, 205);
            this.tbinaltime.Name = "tbinaltime";
            this.tbinaltime.Size = new System.Drawing.Size(183, 25);
            this.tbinaltime.TabIndex = 5;
            // 
            // tbgreutate
            // 
            this.tbgreutate.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbgreutate.Location = new System.Drawing.Point(220, 277);
            this.tbgreutate.Name = "tbgreutate";
            this.tbgreutate.Size = new System.Drawing.Size(183, 25);
            this.tbgreutate.TabIndex = 4;
            // 
            // tbvarsta
            // 
            this.tbvarsta.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbvarsta.Location = new System.Drawing.Point(220, 139);
            this.tbvarsta.Name = "tbvarsta";
            this.tbvarsta.Size = new System.Drawing.Size(183, 25);
            this.tbvarsta.TabIndex = 3;
            // 
            // lblinaltime
            // 
            this.lblinaltime.AutoSize = true;
            this.lblinaltime.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinaltime.Location = new System.Drawing.Point(32, 211);
            this.lblinaltime.Name = "lblinaltime";
            this.lblinaltime.Size = new System.Drawing.Size(110, 19);
            this.lblinaltime.TabIndex = 2;
            this.lblinaltime.Text = "Inaltime (cm)";
            // 
            // lblgreutate
            // 
            this.lblgreutate.AutoSize = true;
            this.lblgreutate.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgreutate.Location = new System.Drawing.Point(32, 283);
            this.lblgreutate.Name = "lblgreutate";
            this.lblgreutate.Size = new System.Drawing.Size(110, 19);
            this.lblgreutate.TabIndex = 1;
            this.lblgreutate.Text = "Greutate (kg)";
            // 
            // lblvarsta
            // 
            this.lblvarsta.AutoSize = true;
            this.lblvarsta.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvarsta.Location = new System.Drawing.Point(32, 145);
            this.lblvarsta.Name = "lblvarsta";
            this.lblvarsta.Size = new System.Drawing.Size(96, 19);
            this.lblvarsta.TabIndex = 0;
            this.lblvarsta.Text = "Varsta (ani)";
            // 
            // tpcomanda
            // 
            this.tpcomanda.BackColor = System.Drawing.Color.Beige;
            this.tpcomanda.Controls.Add(this.btncomanda);
            this.tpcomanda.Controls.Add(this.txtbtotalp);
            this.tpcomanda.Controls.Add(this.txtbtotalk);
            this.tpcomanda.Controls.Add(this.lblprettotal);
            this.tpcomanda.Controls.Add(this.lbltotalkcal);
            this.tpcomanda.Controls.Add(this.txtbneces);
            this.tpcomanda.Controls.Add(this.lblnecesarzilnic);
            this.tpcomanda.Controls.Add(this.dataGridView1);
            this.tpcomanda.Location = new System.Drawing.Point(4, 25);
            this.tpcomanda.Name = "tpcomanda";
            this.tpcomanda.Padding = new System.Windows.Forms.Padding(3);
            this.tpcomanda.Size = new System.Drawing.Size(944, 496);
            this.tpcomanda.TabIndex = 1;
            this.tpcomanda.Text = "Comanda";
            this.tpcomanda.Click += new System.EventHandler(this.tpcomanda_Click);
            // 
            // btncomanda
            // 
            this.btncomanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncomanda.Location = new System.Drawing.Point(529, 362);
            this.btncomanda.Name = "btncomanda";
            this.btncomanda.Size = new System.Drawing.Size(130, 39);
            this.btncomanda.TabIndex = 7;
            this.btncomanda.Text = "Comanda";
            this.btncomanda.UseVisualStyleBackColor = true;
            this.btncomanda.Click += new System.EventHandler(this.btncomanda_Click);
            // 
            // txtbtotalp
            // 
            this.txtbtotalp.Location = new System.Drawing.Point(138, 419);
            this.txtbtotalp.Name = "txtbtotalp";
            this.txtbtotalp.ReadOnly = true;
            this.txtbtotalp.Size = new System.Drawing.Size(100, 22);
            this.txtbtotalp.TabIndex = 6;
            this.txtbtotalp.Text = "0";
            // 
            // txtbtotalk
            // 
            this.txtbtotalk.Location = new System.Drawing.Point(138, 372);
            this.txtbtotalk.Name = "txtbtotalk";
            this.txtbtotalk.ReadOnly = true;
            this.txtbtotalk.Size = new System.Drawing.Size(100, 22);
            this.txtbtotalk.TabIndex = 5;
            this.txtbtotalk.Text = "0";
            // 
            // lblprettotal
            // 
            this.lblprettotal.AutoSize = true;
            this.lblprettotal.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprettotal.Location = new System.Drawing.Point(26, 421);
            this.lblprettotal.Name = "lblprettotal";
            this.lblprettotal.Size = new System.Drawing.Size(77, 20);
            this.lblprettotal.TabIndex = 4;
            this.lblprettotal.Text = "Pret Total:";
            // 
            // lbltotalkcal
            // 
            this.lbltotalkcal.AutoSize = true;
            this.lbltotalkcal.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalkcal.Location = new System.Drawing.Point(26, 374);
            this.lbltotalkcal.Name = "lbltotalkcal";
            this.lbltotalkcal.Size = new System.Drawing.Size(78, 20);
            this.lbltotalkcal.TabIndex = 3;
            this.lbltotalkcal.Text = "Total Kcal:";
            // 
            // txtbneces
            // 
            this.txtbneces.Location = new System.Drawing.Point(138, 324);
            this.txtbneces.Name = "txtbneces";
            this.txtbneces.ReadOnly = true;
            this.txtbneces.Size = new System.Drawing.Size(100, 22);
            this.txtbneces.TabIndex = 2;
            // 
            // lblnecesarzilnic
            // 
            this.lblnecesarzilnic.AutoSize = true;
            this.lblnecesarzilnic.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnecesarzilnic.Location = new System.Drawing.Point(26, 325);
            this.lblnecesarzilnic.Name = "lblnecesarzilnic";
            this.lblnecesarzilnic.Size = new System.Drawing.Size(104, 20);
            this.lblnecesarzilnic.TabIndex = 1;
            this.lblnecesarzilnic.Text = "Necesar zilnic:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idprodusDataGridViewTextBoxColumn1,
            this.denumireprodusDataGridViewTextBoxColumn1,
            this.descriereDataGridViewTextBoxColumn1,
            this.pretDataGridViewTextBoxColumn1,
            this.kcalDataGridViewTextBoxColumn1,
            this.felulDataGridViewTextBoxColumn1,
            this.Cantitatee,
            this.Adauga});
            this.dataGridView1.DataSource = this.meniuBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(7, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(931, 294);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idprodusDataGridViewTextBoxColumn1
            // 
            this.idprodusDataGridViewTextBoxColumn1.DataPropertyName = "id_produs";
            this.idprodusDataGridViewTextBoxColumn1.HeaderText = "id_produs";
            this.idprodusDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.idprodusDataGridViewTextBoxColumn1.Name = "idprodusDataGridViewTextBoxColumn1";
            this.idprodusDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // denumireprodusDataGridViewTextBoxColumn1
            // 
            this.denumireprodusDataGridViewTextBoxColumn1.DataPropertyName = "denumire_produs";
            this.denumireprodusDataGridViewTextBoxColumn1.HeaderText = "denumire_produs";
            this.denumireprodusDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.denumireprodusDataGridViewTextBoxColumn1.Name = "denumireprodusDataGridViewTextBoxColumn1";
            this.denumireprodusDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // descriereDataGridViewTextBoxColumn1
            // 
            this.descriereDataGridViewTextBoxColumn1.DataPropertyName = "descriere";
            this.descriereDataGridViewTextBoxColumn1.HeaderText = "descriere";
            this.descriereDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.descriereDataGridViewTextBoxColumn1.Name = "descriereDataGridViewTextBoxColumn1";
            this.descriereDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // pretDataGridViewTextBoxColumn1
            // 
            this.pretDataGridViewTextBoxColumn1.DataPropertyName = "pret";
            this.pretDataGridViewTextBoxColumn1.HeaderText = "pret";
            this.pretDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.pretDataGridViewTextBoxColumn1.Name = "pretDataGridViewTextBoxColumn1";
            this.pretDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // kcalDataGridViewTextBoxColumn1
            // 
            this.kcalDataGridViewTextBoxColumn1.DataPropertyName = "kcal";
            this.kcalDataGridViewTextBoxColumn1.HeaderText = "kcal";
            this.kcalDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.kcalDataGridViewTextBoxColumn1.Name = "kcalDataGridViewTextBoxColumn1";
            this.kcalDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // felulDataGridViewTextBoxColumn1
            // 
            this.felulDataGridViewTextBoxColumn1.DataPropertyName = "felul";
            this.felulDataGridViewTextBoxColumn1.HeaderText = "felul";
            this.felulDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.felulDataGridViewTextBoxColumn1.Name = "felulDataGridViewTextBoxColumn1";
            this.felulDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Cantitatee
            // 
            dataGridViewCellStyle1.NullValue = "1";
            this.Cantitatee.DefaultCellStyle = dataGridViewCellStyle1;
            this.Cantitatee.HeaderText = "Cantitate";
            this.Cantitatee.MinimumWidth = 6;
            this.Cantitatee.Name = "Cantitatee";
            // 
            // Adauga
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "Adauga";
            this.Adauga.DefaultCellStyle = dataGridViewCellStyle2;
            this.Adauga.HeaderText = "Adauga";
            this.Adauga.MinimumWidth = 6;
            this.Adauga.Name = "Adauga";
            // 
            // meniuBindingSource1
            // 
            this.meniuBindingSource1.DataMember = "Meniu";
            this.meniuBindingSource1.DataSource = this.gOODFOODDataSetBindingSource;
            // 
            // gOODFOODDataSetBindingSource
            // 
            this.gOODFOODDataSetBindingSource.DataSource = this.gOOD_FOODDataSet;
            this.gOODFOODDataSetBindingSource.Position = 0;
            // 
            // gOOD_FOODDataSet
            // 
            this.gOOD_FOODDataSet.DataSetName = "GOOD_FOODDataSet";
            this.gOOD_FOODDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gOODFOODDataSetBindingSource1
            // 
            this.gOODFOODDataSetBindingSource1.DataSource = this.gOOD_FOODDataSet;
            this.gOODFOODDataSetBindingSource1.Position = 0;
            // 
            // meniuBindingSource
            // 
            this.meniuBindingSource.DataMember = "Meniu";
            this.meniuBindingSource.DataSource = this.gOODFOODDataSetBindingSource;
            // 
            // meniuTableAdapter
            // 
            this.meniuTableAdapter.ClearBeforeFill = true;
            // 
            // idprodusDataGridViewTextBoxColumn
            // 
            this.idprodusDataGridViewTextBoxColumn.DataPropertyName = "id_produs";
            this.idprodusDataGridViewTextBoxColumn.HeaderText = "id_produs";
            this.idprodusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idprodusDataGridViewTextBoxColumn.Name = "idprodusDataGridViewTextBoxColumn";
            this.idprodusDataGridViewTextBoxColumn.ReadOnly = true;
            this.idprodusDataGridViewTextBoxColumn.Width = 110;
            // 
            // denumireprodusDataGridViewTextBoxColumn
            // 
            this.denumireprodusDataGridViewTextBoxColumn.DataPropertyName = "denumire_produs";
            this.denumireprodusDataGridViewTextBoxColumn.HeaderText = "denumire_produs";
            this.denumireprodusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.denumireprodusDataGridViewTextBoxColumn.Name = "denumireprodusDataGridViewTextBoxColumn";
            this.denumireprodusDataGridViewTextBoxColumn.ReadOnly = true;
            this.denumireprodusDataGridViewTextBoxColumn.Width = 110;
            // 
            // descriereDataGridViewTextBoxColumn
            // 
            this.descriereDataGridViewTextBoxColumn.DataPropertyName = "descriere";
            this.descriereDataGridViewTextBoxColumn.HeaderText = "descriere";
            this.descriereDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriereDataGridViewTextBoxColumn.Name = "descriereDataGridViewTextBoxColumn";
            this.descriereDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriereDataGridViewTextBoxColumn.Width = 109;
            // 
            // pretDataGridViewTextBoxColumn
            // 
            this.pretDataGridViewTextBoxColumn.DataPropertyName = "pret";
            this.pretDataGridViewTextBoxColumn.HeaderText = "pret";
            this.pretDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pretDataGridViewTextBoxColumn.Name = "pretDataGridViewTextBoxColumn";
            this.pretDataGridViewTextBoxColumn.ReadOnly = true;
            this.pretDataGridViewTextBoxColumn.Width = 110;
            // 
            // kcalDataGridViewTextBoxColumn
            // 
            this.kcalDataGridViewTextBoxColumn.DataPropertyName = "kcal";
            this.kcalDataGridViewTextBoxColumn.HeaderText = "kcal";
            this.kcalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kcalDataGridViewTextBoxColumn.Name = "kcalDataGridViewTextBoxColumn";
            this.kcalDataGridViewTextBoxColumn.ReadOnly = true;
            this.kcalDataGridViewTextBoxColumn.Width = 110;
            // 
            // felulDataGridViewTextBoxColumn
            // 
            this.felulDataGridViewTextBoxColumn.DataPropertyName = "felul";
            this.felulDataGridViewTextBoxColumn.HeaderText = "felul";
            this.felulDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.felulDataGridViewTextBoxColumn.Name = "felulDataGridViewTextBoxColumn";
            this.felulDataGridViewTextBoxColumn.ReadOnly = true;
            this.felulDataGridViewTextBoxColumn.Width = 110;
            // 
            // Optiuni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(952, 525);
            this.Controls.Add(this.tabcontrol);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Optiuni";
            this.Text = "Optiuni";
            this.Load += new System.EventHandler(this.Optiuni_Load);
            this.tabcontrol.ResumeLayout(false);
            this.tpcalckcal.ResumeLayout(false);
            this.tpcalckcal.PerformLayout();
            this.tpcomanda.ResumeLayout(false);
            this.tpcomanda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meniuBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gOODFOODDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gOOD_FOODDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gOODFOODDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meniuBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabcontrol;
        private System.Windows.Forms.TabPage tpcalckcal;
        private System.Windows.Forms.TabPage tpcomanda;
        private System.Windows.Forms.Label lblrez;
        private System.Windows.Forms.Label lblneces1;
        private System.Windows.Forms.Button btncalcul;
        private System.Windows.Forms.TextBox tbinaltime;
        private System.Windows.Forms.TextBox tbgreutate;
        private System.Windows.Forms.TextBox tbvarsta;
        private System.Windows.Forms.Label lblinaltime;
        private System.Windows.Forms.Label lblgreutate;
        private System.Windows.Forms.Label lblvarsta;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource gOODFOODDataSetBindingSource1;
        private GOOD_FOODDataSet gOOD_FOODDataSet;
        private System.Windows.Forms.BindingSource gOODFOODDataSetBindingSource;
        private System.Windows.Forms.BindingSource meniuBindingSource;
        private GOOD_FOODDataSetTableAdapters.MeniuTableAdapter meniuTableAdapter;
        private System.Windows.Forms.BindingSource meniuBindingSource1;
        private System.Windows.Forms.TextBox txtbtotalp;
        private System.Windows.Forms.TextBox txtbtotalk;
        private System.Windows.Forms.Label lblprettotal;
        private System.Windows.Forms.Label lbltotalkcal;
        private System.Windows.Forms.TextBox txtbneces;
        private System.Windows.Forms.Label lblnecesarzilnic;
        private System.Windows.Forms.Button btncomanda;
        private System.Windows.Forms.DataGridViewTextBoxColumn idprodusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn denumireprodusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriereDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kcalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn felulDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idprodusDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn denumireprodusDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriereDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kcalDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn felulDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantitatee;
        private System.Windows.Forms.DataGridViewButtonColumn Adauga;
    }
}