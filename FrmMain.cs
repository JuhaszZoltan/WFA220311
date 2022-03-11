using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WFA220311
{
    public partial class FrmMain : Form
    {
        public string ConnectionString =>
            "Server = (localdb)\\MSSQLLocalDB; Database = felhasznalok";

        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            //amit lehet alkalmazásszinten ellenőrizni, azt ellenőrzömű
            //ezt most mi kihagyjuk, kivéve:

            if (tbRJelszo.Text == tbRJelszoEll.Text)
            {
                using (var conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();

                    var command = new SqlCommand("INSERT INTO autorizacio VALUES " +
                        $"('{tbRFN.Text}', '{tbREmail.Text}', '{PwdToHash(tbRJelszo.Text)}');", conn);

                    command.ExecuteNonQuery();
                }

            }
            else MessageBox.Show("nem egyforma a 2 jelszo");
        }

        private string PwdToHash(string pwd)
        {
            using (var md5 = MD5.Create())
            {
                byte[] hashBytes = md5.ComputeHash(
                    buffer: Encoding.ASCII.GetBytes(pwd));
                string hash = string.Empty;
                foreach (var b in hashBytes)
                    hash += b.ToString("X2");
                return hash;
            }
        }

        private void btnBej_Click(object sender, EventArgs e)
        {
            using (var conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                var hash = PwdToHash(tbBejJelszo.Text);

                var cmd = new SqlCommand("SELECT id FROM autorizacio WHERE " +
                    $"(felfnev = '{tbBejFNEmail.Text}' OR email = '{tbBejFNEmail.Text}') " +
                    $"AND md5hash = '{hash}';", conn);

                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("YEP!");
                }
                else
                {
                    MessageBox.Show("NOPE!");
                }
            }
        }
    }
}
