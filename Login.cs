using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project_Donation
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void valider_Click(object sender, EventArgs e)
        {
            String name = textnom.Text;
            String pwd = textmdp.Text;

            // Login invalide :  
            if (name != "name" || pwd != "password")
            {
                textnom.Clear();
                textmdp.Clear();
                MessageBox.Show("Veuillez verifier vos données ! ");
            }

            //Login Valide : 

            else
            {
                
                String query_Aplus = "SELECT SUM(Qte) FROM DONS WHERE D_Exp < GETDATE() AND G_Sang = 'A+'";
                String query_Amoins = "SELECT SUM(Qte) FROM DONS WHERE D_Exp < GETDATE() AND G_Sang = 'A-'";
                String query_Bplus = "SELECT SUM(Qte) FROM DONS WHERE D_Exp < GETDATE() AND G_Sang = 'B+'";
                String query_Bmoins = "SELECT SUM(Qte) FROM DONS WHERE D_Exp < GETDATE() AND G_Sang = 'B-'";
                String query_ABplus = "SELECT SUM(Qte) FROM DONS WHERE D_Exp < GETDATE() AND G_Sang = 'AB+'";
                String query_ABmoins = "SELECT SUM(Qte) FROM DONS WHERE D_Exp < GETDATE() AND G_Sang = 'AB-'";
                String query_Oplus = "SELECT SUM(Qte) FROM DONS WHERE D_Exp < GETDATE() AND G_Sang = 'O+'";
                String query_Omoins = "SELECT SUM(Qte) FROM DONS WHERE D_Exp < GETDATE() AND G_Sang = 'O-'";

                int sum_Aplus = 0;
                int sum_Amoins = 0;
                int sum_Bplus = 0;
                int sum_Bmoins = 0;
                int sum_ABplus = 0;
                int sum_ABmoins = 0;
                int sum_Oplus = 0;
                int sum_Omoins = 0;


                using (SqlConnection conn = new SqlConnection("Data Source=LAPTOP-U096NRI1\\SQLEXPRESS;Initial Catalog=Gest_Sang;Persist Security Info=True;User ID=sa;Password=;Encrypt=True;TrustServerCertificate=true ; Integrated Security=SSPI;"))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query_Aplus, conn))
                    {
                        object result = cmd.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            sum_Aplus = Convert.ToInt32(result);
                        }
                    }

                    using (SqlCommand cmd = new SqlCommand(query_Amoins, conn))
                    {
                        object result = cmd.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            sum_Amoins = Convert.ToInt32(result);
                        }
                    }

                    using (SqlCommand cmd = new SqlCommand(query_Bplus, conn))
                    {
                        object result = cmd.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            sum_Bplus = Convert.ToInt32(result);
                        }
                    }

                    using (SqlCommand cmd = new SqlCommand(query_Bmoins, conn))
                    {
                        object result = cmd.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            sum_Bmoins = Convert.ToInt32(result);
                        }
                    }

                    using (SqlCommand cmd = new SqlCommand(query_ABplus, conn))
                    {
                        object result = cmd.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            sum_ABplus = Convert.ToInt32(result);
                        }
                    }

                    using (SqlCommand cmd = new SqlCommand(query_ABmoins, conn))
                    {
                        object result = cmd.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            sum_ABmoins = Convert.ToInt32(result);
                        }
                    }

                    using (SqlCommand cmd = new SqlCommand(query_Oplus, conn))
                    {
                        object result = cmd.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            sum_Oplus = Convert.ToInt32(result);
                        }
                    }

                    using (SqlCommand cmd = new SqlCommand(query_Omoins, conn))
                    {
                        object result = cmd.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            sum_Omoins = Convert.ToInt32(result);
                        }
                    }

                    // Exécution des mises à jour pour chaque groupe sanguin

                    string updateQuery_Aplus = "UPDATE stocke SET QTE = QTE - '" + sum_Aplus + "' WHERE G_Sanguin = 'A+'";
                    UpdateStock(conn, updateQuery_Aplus, sum_Aplus);

                    string updateQuery_Amoins = "UPDATE stocke SET QTE = QTE - '" + sum_Amoins + "' WHERE G_Sanguin = 'A-'";
                    UpdateStock(conn, updateQuery_Amoins, sum_Amoins);

                    string updateQuery_Bplus = "UPDATE stocke SET QTE = QTE - '" + sum_Bplus + "' WHERE G_Sanguin = 'B+'";
                    UpdateStock(conn, updateQuery_Bplus, sum_Bplus);

                    string updateQuery_Bmoins = "UPDATE stocke SET QTE = QTE - '" + sum_Bmoins + "' WHERE G_Sanguin = 'B-'";
                    UpdateStock(conn, updateQuery_Bmoins, sum_Bmoins);

                    string updateQuery_ABplus = "UPDATE stocke SET QTE = QTE - '" + sum_ABplus + "' WHERE G_Sanguin = 'AB+'";
                    UpdateStock(conn, updateQuery_ABplus, sum_ABplus);

                    string updateQuery_ABmoins = "UPDATE stocke SET QTE = QTE - '" + sum_ABmoins + "' WHERE G_Sanguin = 'AB-'";
                    UpdateStock(conn, updateQuery_ABmoins, sum_ABmoins);

                    string updateQuery_Oplus = "UPDATE stocke SET QTE = QTE - '" + sum_Oplus + "' WHERE G_Sanguin = 'O+'";
                    UpdateStock(conn, updateQuery_Oplus, sum_Oplus);

                    string updateQuery_Omoins = "UPDATE stocke SET QTE = QTE - '" + sum_Omoins + "' WHERE G_Sanguin = 'O-'";
                    UpdateStock(conn, updateQuery_Omoins, sum_Omoins);

                    // Ici mise a jour de la date D_Exp de tout les DONS qui ont une D_Exp egale a SysDate  : 
                    String queryupdate = "UPDATE DONS SET D_Exp = '9999-01-01' WHERE D_Exp < GETDATE()";
                    SqlCommand command = new SqlCommand(queryupdate, conn);
                    command.ExecuteNonQuery();
                    

                    string query = "Select qte from stocke where qte < 1000 ";  
                    SqlCommand command2 = new SqlCommand(query , conn); 
                    object rst = command2.ExecuteScalar();

                    if(rst != null )
                    {
                        notifyIcon1.ShowBalloonTip(3000, "Alert", "vous avez un stock faible , veillez consulter votre stock", ToolTipIcon.Warning);
                    }
                    
                    conn.Close();
                }

                Menu formmenu = new Menu();
                formmenu.Show();
                this.Hide();
            }


        }

        // Méthode pour mettre à jour le stock
        static void UpdateStock(SqlConnection conn, string query, int sum)
        {
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.ExecuteNonQuery();
            }
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            Suivi_Stock ss = new Suivi_Stock();
            ss.Show();
            this.Hide(); 
        }
    }
}
