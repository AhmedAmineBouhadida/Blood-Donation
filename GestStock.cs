using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Project_Donation
{
    public partial class GestStock : Form
    {
        public GestStock()
        {
            InitializeComponent();
        }

        // Controle CIN :  
        private bool ctrl_cin(string cin)
        {
            string pattern = @"^\d{8}$";
            return Regex.IsMatch(cin, pattern);
        }

        
        private bool ctrl_qte(float qte)
        {
            return qte >= 100 && qte <= 500;
        }


        private void valider_Click(object sender, EventArgs e)
        {
            if (!ctrl_cin(cin.Text))
            {
                errcin.Visible = true;
                return;
            }

            string G_Sanguin = string.Empty;
            float quanti = 0;

            using (SqlConnection conn = new SqlConnection("Data Source=LAPTOP-U096NRI1\\SQLEXPRESS;Initial Catalog=Gest_Sang;Persist Security Info=True;User ID=sa;Password=;Encrypt=True;TrustServerCertificate=true ; Integrated Security=SSPI;"))
            {
                conn.Open();
                String txtcin = cin.Text;
                string query = "SELECT count(*) FROM donneurs WHERE cin = @CIN";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CIN", txtcin);
                    int count = (int)cmd.ExecuteScalar();
                    if (count > 0)
                    {
                        if (float.TryParse(quantité.Text, out quanti) && ctrl_qte(quanti))
                        {
                            string recuperer = "SELECT G_Sanguin FROM donneurs WHERE cin = @CIN";
                            using (SqlCommand comnd = new SqlCommand(recuperer, conn))
                            {
                                comnd.Parameters.AddWithValue("@CIN", txtcin);
                                object result = comnd.ExecuteScalar();
                                if (result != null)
                                {
                                    G_Sanguin = result.ToString();
                                }
                            }

                            // insertio, des donnees dans la table DONS 
                            if (!string.IsNullOrEmpty(G_Sanguin))
                            {
                                string rq_insertion = "INSERT INTO dons (CIN, G_Sang, D_Don, Qte, D_Exp) VALUES (@CIN, @G_Sang, GETDATE(), @Qte, DATEADD(day, 42, GETDATE()))";
                                string rq_update_stk = "Update STOCKE SET QTE = QTE + @Qte where G_Sanguin = @G_Sang ";

                                using (SqlCommand comm = new SqlCommand(rq_insertion, conn))
                                {
                                    comm.Parameters.AddWithValue("@CIN", txtcin);
                                    comm.Parameters.AddWithValue("@G_Sang", G_Sanguin);
                                    comm.Parameters.AddWithValue("@Qte", quanti);
                                    comm.ExecuteNonQuery();
                                }


                                using (SqlCommand comm = new SqlCommand(rq_update_stk, conn))
                                {
                                    comm.Parameters.AddWithValue("@G_Sang", G_Sanguin);
                                    comm.Parameters.AddWithValue("@Qte", quanti);
                                    comm.ExecuteNonQuery();
                                    MessageBox.Show("Données ajoutées merci !");
                                    cin.Clear();
                                    quantité.Clear();
                                    errqté.Visible = false;
                                }
                            }
                        }
                        else
                        {
                            errqté.Visible = true;
                        }
                    }
                    else
                    {
                        // Affichage du message CIN n'est pas trouvée 
                        errcin_indspo.Visible = true;
                        quantité.Clear();
                    }
                }
            } 
        }

        private void cin_Click(object sender, EventArgs e)
        {
            // Cacher le message d'err quand le textbox est cliqué 
            errcin.Visible = false;
            cin.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }
    }
}
