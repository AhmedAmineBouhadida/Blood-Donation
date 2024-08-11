using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project_Donation
{
    public partial class utilisateurs_cas_vitale : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-U096NRI1\\SQLEXPRESS;Initial Catalog=Gest_Sang;Persist Security Info=True;User ID=sa;Password=;Encrypt=True;TrustServerCertificate=true ; Integrated Security=SSPI;");

        public utilisateurs_cas_vitale(String gsang)
        {
            InitializeComponent();
            string type_sang = gsang;

            
            listView1.GridLines = true;
            listView1.View = View.Details;
            int columnWidth = listView1.Width / 4 - 5; 

            listView1.Columns.Add("Nom", columnWidth);
            listView1.Columns.Add("Prenom", columnWidth);
            listView1.Columns.Add("Groupe Sanguin", columnWidth);
            listView1.Columns.Add("Numero tel", columnWidth);

            string query_found = "SELECT * FROM donneurs WHERE G_Sanguin = @type_sang;";
            conn.Open();
            SqlCommand cmd = new SqlCommand(query_found, conn);

            cmd.Parameters.AddWithValue("@type_sang", type_sang);

            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                listView1.Items.Clear();

                while (dr.Read())
                {
                    ListViewItem item = new ListViewItem(dr.GetString(1)); // Nom
                    item.SubItems.Add(dr.GetString(2)); // Prenom
                    item.SubItems.Add(dr.GetString(5)); // Groupe Sanguin
                    item.SubItems.Add(dr.GetString(8)); // Numero tel

                    listView1.Items.Add(item);
                }
            }

            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }
    }
}
