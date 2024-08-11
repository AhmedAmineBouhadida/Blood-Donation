using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Project_Donation
{
    public partial class Suivi_Stock : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-U096NRI1\\SQLEXPRESS;Initial Catalog=Gest_Sang;Persist Security Info=True;User ID=sa;Password=;Encrypt=True;TrustServerCertificate=true;Integrated Security=SSPI;");

        public Suivi_Stock()
        {
            InitializeComponent();
        }

        private void Suivi_Stock_Load(object sender, EventArgs e)
        {
            // Configuration de la liste pour afficher les informations
            listView1.GridLines = true;
            listView1.View = View.Details;

            // Calcul de la largeur de chaque colonne
            int columnWidth = listView1.Width / 2 - 5; // Soustrayez 5 pour laisser de l'espace entre les colonnes

            // Ajout des colonnes avec la largeur calculée
            listView1.Columns.Add("Groupe Sanguin", columnWidth);
            listView1.Columns.Add("Quantité", columnWidth);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                // Requête SQL pour récupérer les informations sur le stock
                string query = "SELECT G_Sanguin, QTE FROM Stocke";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        // Effacer les éléments précédents de la liste
                        listView1.Items.Clear();

                        // Lire les résultats de la requête et les afficher dans la liste
                        while (dr.Read())
                        {
                            ListViewItem item = new ListViewItem(dr.GetString(0)); // G_Sanguin
                            item.SubItems.Add(dr.GetInt32(1).ToString()); // QTE
                            if (dr.GetInt32(1) <= 1000)
                            {
                                item.BackColor = Color.LightPink;
                            }
                            else
                            {
                                item.BackColor = Color.LightGreen;
                            }

                            listView1.Items.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
            finally
            {
                // Fermer la connexion après avoir terminé l'accès à la base de données
                conn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            // Requête SQL pour récupérer les informations sur le stock
            string query = "SELECT G_Sanguin, QTE FROM Stocke";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    // Effacer les éléments précédents de la liste
                    listView1.Items.Clear();

                    // Créer une liste temporaire pour stocker les éléments à trier
                    List<ListViewItem> itemsToSort = new List<ListViewItem>();



                    // Lire les résultats de la requête et les ajouter à la liste temporaire
                    while (dr.Read())
                    {
                        ListViewItem item = new ListViewItem(dr.GetString(0)); // G_Sanguin
                        item.SubItems.Add(dr.GetInt32(1).ToString()); // QTE

                        itemsToSort.Add(item);
                    }

                    // Trier la liste temporaire selon la deuxième colonne en utilisant une méthode de tri personnalisée
                    itemsToSort.Sort((x, y) =>
                    {
                        int numX = int.Parse(x.SubItems[1].Text);
                        int numY = int.Parse(y.SubItems[1].Text);
                        // Pour trier dans l'ordre descendant, retournez le résultat de la comparaison inversée
                        return numY.CompareTo(numX); // Compare en ordre descendant
                    });

                    // Ajouter les éléments triés à la ListView
                    foreach (var item in itemsToSort)
                    {
                        listView1.Items.Add(item);
                    }
                }
            }

            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu(); 
            menu.Show();
        }
    }
}
