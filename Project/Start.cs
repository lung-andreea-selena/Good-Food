using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Good_Food
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void btnautentificare_Click(object sender, EventArgs e)
        {
            Autentificare_client auten = new Autentificare_client();
            auten.Show();
            this.Hide();
        }

        private void btninregistrare_Click(object sender, EventArgs e)
        {
            Creare_cont_client create = new Creare_cont_client();
            create.Show();
            this.Hide();
        }

        private void Start_Load(object sender, EventArgs e)
        {

        }
    }
}
