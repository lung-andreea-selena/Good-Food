using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Good_Food
{
    public partial class Vizualizare_comanda : Form
    {
        public string Usermail;
        public string totalk;
        public string totalp;

        public Vizualizare_comanda(Dictionary<int, int> cantitati, DataGridViewRowCollection rows, string mailul, string totalkcal, string totalpret)
        {
            InitializeComponent();
                Usermail = mailul;
                totalk = totalkcal;
                totalp = totalpret;
            foreach (int a in cantitati.Keys)
            {
               

                int cantitate = cantitati[a];
                string nume = Convert.ToString(rows[a].Cells[1].Value);
                string kcal = Convert.ToString(rows[a].Cells[4].Value);

                int pret = Convert.ToInt32(rows[a].Cells[3].Value);
                string pretText = Convert.ToString(pret * cantitate);

                string cantitateText = Convert.ToString(cantitate);

                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView2);
                row.Cells[0].Value = nume;
                row.Cells[1].Value = kcal;
                row.Cells[2].Value = pretText;
                row.Cells[3].Value = cantitateText;
                dataGridView2.Rows.Add(row);
            }
        }

        private void Vizualizare_comanda_Load(object sender, EventArgs e)
        {


            AppDomain.CurrentDomain.SetData("DataDirectory", System.Environment.CurrentDirectory.Replace("\\bin\\Debug", ""));
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\GOOD_FOOD.mdf;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string select = "SELECT kcal_zilnice FROM Clienti WHERE email='" + Usermail + "'";
            SqlCommand selectcmd = new SqlCommand(select, connection);
            SqlDataReader reader = selectcmd.ExecuteReader();
            reader.Read();
            tbneces.Text=reader[0].ToString();
            
            tbtotalkcal.Text = totalk;
            tbprettot.Text = totalp;//MessageBox.Show(tbprettot.Text + " "+ tbtotalkcal.Text);
        }

        private void btnfinalizare_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Comanda trimisa!");
            Start start = new Start();
            start.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int totk = Convert.ToInt32(totalk);
            int totp = Convert.ToInt32(totalp);
            if (dataGridView2.Columns[e.ColumnIndex].Name == "Elimina")
            {
                this.dataGridView2.Rows.RemoveAt(e.RowIndex);
                int can = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[3].Value);
                int kcal=Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[1].Value);
                int pret = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[2].Value);
                totk = totk - kcal*can;
                totp= totp - pret*can;
                tbtotalkcal.Text = totk.ToString();
                tbprettot.Text = totp.ToString();

            }
        }
    }
}
