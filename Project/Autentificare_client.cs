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
    public partial class Autentificare_client : Form
    {
        public Autentificare_client()
        {
            InitializeComponent();
        }

        private void lblemail2_Click(object sender, EventArgs e)
        {

        }

        private void Autentificare_client_Load(object sender, EventArgs e)
        {

        }

        private void btnintrare_Click(object sender, EventArgs e)
        {
            string email = txtbemail2.Text;
            string parola = txtbparola2.Text;
            AppDomain.CurrentDomain.SetData("DataDirectory", System.Environment.CurrentDirectory.Replace("\\bin\\Debug", ""));
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\GOOD_FOOD.mdf;Integrated Security=True";

            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Clienti WHERE email='" + email + "'and parola='" + parola + "'",connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                int r=dt.Rows.Count;
                if (r>0)             
                {
                    MessageBox.Show("Conectat cu succes");
                    Optiuni optiuni=new Optiuni(txtbemail2.Text);
                    txtbemail2.Clear();
                    txtbparola2.Clear();
                    optiuni.Show();
                    Hide();
                    return;
                }
                else
                {
                    MessageBox.Show("Eroare autentificare!");
                    txtbemail2.Clear();
                    txtbparola2.Clear();
                    return;
                }
                connection.Close();
                txtbemail2.Clear();
                txtbparola2.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
