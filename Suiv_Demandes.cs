using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project_Donation
{
    public partial class Suiv_Demandes : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-U096NRI1\\SQLEXPRESS;Initial Catalog=Gest_Sang;Persist Security Info=True;User ID=sa;Password=;Encrypt=True;TrustServerCertificate=true ; Integrated Security=SSPI;");

        public Suiv_Demandes()
        {
            InitializeComponent();
        }

        private void ajout_demande_Click(object sender, EventArgs e)
        {
            conn.Open();

            string id_demande = iddem.Text;
            string g_sang = comboBox1.Text;
            int quanti = int.Parse(qte.Text);
            string urg = combo2.Text;

            string get_quanti = "SELECT qte FROM stocke WHERE G_Sanguin = @g_sang;";

            SqlCommand cmnd = new SqlCommand(get_quanti, conn);

            cmnd.Parameters.AddWithValue("@g_sang", g_sang);
            object result = cmnd.ExecuteScalar();
            int? quantite_dispo = result != DBNull.Value ? (int?)result : null;

            if (quantite_dispo != null && quanti <= quantite_dispo)
            {
                string rq = "INSERT INTO demandes VALUES (@id_demande, @g_sang, @quanti, @urg);";

                SqlCommand cmdInsert = new SqlCommand(rq, conn);
                cmdInsert.Parameters.AddWithValue("@id_demande", id_demande);
                cmdInsert.Parameters.AddWithValue("@g_sang", g_sang);
                cmdInsert.Parameters.AddWithValue("@quanti", quanti);
                cmdInsert.Parameters.AddWithValue("@urg", urg);

                cmdInsert.ExecuteNonQuery();

                MessageBox.Show("Votre demande a été enregistrée avec succès.");
            }

            else if (urg == "Vitale")
            {
                utilisateurs_cas_vitale x = new utilisateurs_cas_vitale(g_sang);
                x.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Pas de quantité suffisante pour la demande .", "Echec", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();  
            Menu mn =  new Menu();
            mn.Show();
        }
    }
}
