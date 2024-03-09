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
using System.IO;


namespace Good_Food
{
    public partial class Optiuni : Form
    {
        string kcal2; int total = 0,totalk=0;
        public string Usermail;
        public string totalkcal;
        public string totalpret;
        int j = 0;
        
        public Optiuni(string mailul)
        {
            InitializeComponent();
            Usermail = mailul;
            
        }

        Dictionary<int, int> cantitati = new Dictionary<int, int>();

        private void Optiuni_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gOOD_FOODDataSet.Meniu' table. You can move, or remove it, as needed.
            this.meniuTableAdapter.Fill(this.gOOD_FOODDataSet.Meniu);
            try
            {  AppDomain.CurrentDomain.SetData("DataDirectory", System.Environment.CurrentDirectory.Replace("\\bin\\Debug", ""));
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\GOOD_FOOD.mdf;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                SqlCommand clear = new SqlCommand("truncate table Meniu", connection);
                clear.ExecuteNonQuery();
                StreamReader sr = new StreamReader(@"C:\Users\Lung\OneDrive\Desktop\c#\Good_Food\Resurse_C#\data\meniu.txt");
                string line=sr.ReadLine();
                while(line != null)
                {
                    line = sr.ReadLine();
                    if(line==null)
                    {
                        continue;
                    }
                    line= line.Trim();
                    if(line.Length == 0)
                    {
                        continue;
                    }
                    string[] parts = line.Split(';');
                    string commandText = "INSERT INTO Meniu(denumire_produs,descriere, pret,kcal,felul) VALUES(@param1, @param2, @param3, @param4, @param5)";
                    SqlCommand cmd = new SqlCommand(commandText, connection);

                    for (int i= 1; i< parts.Length-1;i++)
                    {
                        cmd.Parameters.AddWithValue("param" + i, parts[i].Trim());
                    }
                    cmd.ExecuteNonQuery();
                }

                string select = "SELECT kcal_zilnice FROM Clienti WHERE email='"+Usermail+"'";//STRINGU
                SqlCommand selectcmd=new SqlCommand(select, connection);//creez comanda
                SqlDataReader reader = selectcmd.ExecuteReader();
                reader.Read();
                txtbneces.Text = reader[0].ToString();
                lblrez.Text = reader[0].ToString();

                connection.Close();
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btncalcul_Click(object sender, EventArgs e)
        {
           try
            {

            int v = Convert.ToInt32(tbvarsta.Text.ToString());
            int i=Convert.ToInt32(tbinaltime.Text.ToString());
            int g=Convert.ToInt32(tbgreutate.Text.ToString());
            int S = 0, kcal=0;
            S = v + i + g;
            if(S<250)
            {
                kcal = 1800;
                lblrez.Text = kcal.ToString();
            }
            if(S>=250 && S<=275)
            {
                kcal = 2200;
                lblrez.Text = kcal.ToString();
            }
            if(S>275)
            {
                kcal = 2500;
                lblrez.Text = kcal.ToString();
            }

            AppDomain.CurrentDomain.SetData("DataDirectory", System.Environment.CurrentDirectory.Replace("\\bin\\Debug", ""));
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\GOOD_FOOD.mdf;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            kcal2 =kcal.ToString();
            txtbneces.Text = kcal2.ToString();
            string email = Usermail;
            string commandText = "UPDATE Clienti SET kcal_zilnice='"+ kcal2 +"' WHERE email='"+ email+"'";
            SqlCommand command = new SqlCommand(commandText, connection);
            command.ExecuteNonQuery();

                connection.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                try 
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "Adauga")
                {
                    
                    int a = e.RowIndex;
                    object val = dataGridView1.Rows[a].Cells[6].Value;
                    if(val== null)
                    {
                        val = "1";
                    }
                    string can=Convert.ToString(val);
                    int c= Convert.ToInt32(can);
                    if(c<0)
                    {
                        MessageBox.Show("Cantitate negativa!");
                        return;
                    }
                    int t= Convert.ToInt32(dataGridView1.Rows[a].Cells[4].Value);
                    txtbtotalk.Text = t.ToString();
                    totalk = totalk + t*c;
                    txtbtotalk.Text = totalk.ToString();
                

                    int t2 = Convert.ToInt32(dataGridView1.Rows[a].Cells[3].Value);
                    txtbtotalp.Text = t2.ToString();
                    total = total + t2*c;
                    txtbtotalp.Text = total.ToString();

                    if (!cantitati.ContainsKey(a))
                    {
                        cantitati.Add(a, c);
                    } else
                    {
                        cantitati[a] += c;
                    }
                    totalkcal = totalk.ToString();
                    totalpret = total.ToString();

                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btncomanda_Click(object sender, EventArgs e)
        {
            
            try
            {
                AppDomain.CurrentDomain.SetData("DataDirectory", System.Environment.CurrentDirectory.Replace("\\bin\\Debug", ""));
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\GOOD_FOOD.mdf;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                string email = Usermail;
                string commandtext= "SELECT id_client FROM Clienti WHERE email='" + email + "'";
                SqlCommand command = new SqlCommand(commandtext, connection);
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                string id=reader[0].ToString();
                DateTime data = DateTime.Now;
                int id2=Convert.ToInt32(id);
                connection.Close();
                string inserare = "INSERT INTO Comenzi(id_client,data_comanda) VALUES ('" + id2 + "', '"+data+"')";
                connection.Open();
                SqlCommand inser = new SqlCommand(inserare, connection);
                inser.ExecuteNonQuery();
                connection.Close();
                


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Vizualizare_comanda viz = new Vizualizare_comanda(cantitati, dataGridView1.Rows, Usermail,totalkcal,totalpret);
            viz.Show();
            Hide();
        }

        private void btngenereaza_Click(object sender, EventArgs e)
        {
            
            
            try
            {
                /*AppDomain.CurrentDomain.SetData("DataDirectory", System.Environment.CurrentDirectory.Replace("\\bin\\Debug", ""));
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\GOOD_FOOD.mdf;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                string action = "SELECT felul FROM Meniu";
                SqlCommand cmd = new SqlCommand(action, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();*/
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void tpcomanda_Click(object sender, EventArgs e)
        {

        }
    }
}
