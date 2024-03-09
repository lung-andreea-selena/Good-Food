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
    public partial class Creare_cont_client : Form
    {
        public Creare_cont_client()
        {
            InitializeComponent();
        }

        private void Creare_cont_client_Load(object sender, EventArgs e)
        {

        }

        private void btncrearecont_Click(object sender, EventArgs e)
        {
            string nume= txtbnume.Text;
            string prenume=txtbprenume.Text;
            string adresa=txtbadresa.Text;
            string parola=txtbparola.Text;
            string reintrpar = txtbreinparola.Text;
            string email=txtbemail.Text;

                if (email.Split('@').Length != 2)
                {
                    MessageBox.Show("Email invalid");
                    txtbemail.Clear();
                    return;
                }
                if (!email.Contains('.'))
                {
                    MessageBox.Show("Email invalid");
                    txtbemail.Clear();
                    return;
                }
                if (!email.EndsWith(".com") && !email.EndsWith(".ro"))
                {
                    MessageBox.Show("Email invalid");
                    txtbemail.Clear();
                    return;
                }
                if (parola.Length < 6)
                {
                    MessageBox.Show("Parola trebuie sa aiba minim 6 caractere");
                    txtbreinparola.Clear();
                    txtbparola.Clear();
                    return;
                }
                if (parola != reintrpar)
                {
                    MessageBox.Show("Parolele nu coincid");
                    txtbreinparola.Clear();
                    txtbparola.Clear();
                    return;
                }
            

            AppDomain.CurrentDomain.SetData("DataDirectory", System.Environment.CurrentDirectory.Replace("\\bin\\Debug", ""));
            //am facut asta de mai sus ca sa lucram direct cu baza de date nu cu folderu copie
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\GOOD_FOOD.mdf;Integrated Security=True";
            //variabila care ne tine minte drumu catre baza de date

            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                //o variabila noua de tip clasa sqlconnection din drumul respectiv
                connection.Open(); //deschidem conexiunea

                string emailverif = @"SELECT * FROM Clienti WHERE email='" + email + "'";
                //emailverif e actiunea pe care o face noua comanda
                SqlCommand emailcmd= new SqlCommand(emailverif, connection);
                //creeam comanda de tip sqlcommand care( face ceva, din conexiunea la drum)
                SqlDataReader sqlreader =emailcmd.ExecuteReader();
                //sqlreader citeste ce face comanda, respectiv ce a selectat comanda
                if(sqlreader.HasRows)
                {
                    MessageBox.Show("Email deja utilizat");
                    txtbemail.Clear();
                    connection.Close();
                    sqlreader.Close();
                    return;
                }
                sqlreader.Close();

                string commandText = @"INSERT INTO Clienti(nume, prenume,adresa, parola, email) VALUES ('"+nume+"', '"+prenume+"', '"+adresa+"' , '"+parola+"' , '"+email+"')";
                SqlCommand command = new SqlCommand(commandText, connection);
                command.ExecuteNonQuery();



                connection.Close();
                txtbnume.Clear();
                txtbemail.Clear();
                txtbprenume.Clear();
                txtbreinparola.Clear();
                txtbparola.Clear();
                txtbadresa.Clear();
                MessageBox.Show("Utilizator creat cu succes");
                Start s = new Start();
                s.Show();
                Hide();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ";" + ex.GetType().Name);
            }
        }
    }
}
