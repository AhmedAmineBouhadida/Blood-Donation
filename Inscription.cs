using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Project_Donation
{
    public partial class Inscription : Form
    {
        int exist = 0;
        public Inscription()
        {
            InitializeComponent();
        }


        // Déclaration de la connexion : 

        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-U096NRI1\\SQLEXPRESS;Initial Catalog=Gest_Sang;Persist Security Info=True;User ID=sa;Password=;Encrypt=True;TrustServerCertificate=true ; Integrated Security=SSPI;");

        // Bouton Ajouter : 

        private void Btn_Ajouter_Click(object sender, EventArgs e)
        {
            if (exist == 0)
            {

                try
                {
                    conn.Open();

                    // Récupération des valeurs des contrôles

                    String cin = textcin.Text;
                    string nom = textnom.Text;
                    string prenom = textprenom.Text;
                    DateTime d_naiss = datepicker.Value;
                    string adresse = textadresse.Text;
                    string g_sang = comboBox1.Text;
                    float poids = float.Parse(textpoids.Text);
                    string ant_med = textantecedents.Text;
                    string nt = boxtel.Text;

                    // Requête pour insérer un nouveau donneur

                    string queryInsert = "INSERT INTO Donneurs (CIN, NOM, PRENOM, D_Naiss, ADRESSE, G_sanguin, POIDS, A_Med , tel) " +
                                         "VALUES (@cin, @nom, @prenom, @d_naiss, @adresse, @g_sang, @poids, @ant_med , @nt)";

                    // Création de la commande SQL

                    SqlCommand cmdInsert = new SqlCommand(queryInsert, conn);
                    cmdInsert.Parameters.AddWithValue("@cin", cin);
                    cmdInsert.Parameters.AddWithValue("@nom", nom);
                    cmdInsert.Parameters.AddWithValue("@prenom", prenom);
                    cmdInsert.Parameters.AddWithValue("@d_naiss", d_naiss);
                    cmdInsert.Parameters.AddWithValue("@adresse", adresse);
                    cmdInsert.Parameters.AddWithValue("@g_sang", g_sang);
                    cmdInsert.Parameters.AddWithValue("@poids", poids);
                    cmdInsert.Parameters.AddWithValue("@ant_med", ant_med);
                    cmdInsert.Parameters.AddWithValue("@nt", nt);


                    // Exécution de la commande SQL pour insérer un nouveau donneur

                    cmdInsert.ExecuteNonQuery();

                    MessageBox.Show("Le donneur a été ajouté avec succès.");

                    // Appele de la methode vider_interface pour vider l'interface 
                    vider_interface();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Le format des données est incorrect.");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Erreur lors de l'exécution de la requête SQL : " + ex.Message);
                }
                finally
                {
                    // Fermeture de la connexion
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Verifier que le client n'existe pas ! ");
            }
        }

        // Test si le donneur deja existe ou non :  

        private void textcin_Leave(object sender, EventArgs e)
        {
            // Ouvrir la connexion à la base de données
            conn.Open();

            // Récupérer le CIN saisi dans le champ de texte textcin
            String cin = textcin.Text;

            if (ctrl_cin(cin) == false)
            {
                Err_Cin.Visible = true;
                textcin.Clear();
            }

            string queryExiste = "SELECT COUNT(*) FROM Donneurs WHERE CIN = @cin";
            SqlCommand cmdExiste = new SqlCommand(queryExiste, conn);
            cmdExiste.Parameters.AddWithValue("@cin", cin);
            int count = (int)cmdExiste.ExecuteScalar();

            // Vérifier si un client avec le CIN donné existe déjà : 

            if (count > 0)
            {
                exist = 1;
                DialogResult dr = MessageBox.Show("Donneur déja existe ! Voulez vous ajouter un don pour se donneur?", "Don", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {
                    GestStock donation = new GestStock();
                    donation.Show();
                    this.Hide();
                }
                else
                {
                    // Recuperation et affichage des données : 

                    //Recuperation du nom : 
                    SqlCommand nom = new SqlCommand("Select NOM from donneurs where cin = @cin", conn);
                    nom.Parameters.AddWithValue("@cin", cin);
                    object result = nom.ExecuteScalar();
                    textnom.Text = result.ToString();

                    //Recuperation du prenom : 
                    SqlCommand prenom = new SqlCommand("Select prenom from donneurs where cin = @cin", conn);
                    prenom.Parameters.AddWithValue("@cin", cin);
                    result = prenom.ExecuteScalar();
                    textprenom.Text = result.ToString();

                    //Recuperation du adresse : 
                    SqlCommand addr = new SqlCommand("Select adresse from donneurs where cin = @cin", conn);
                    addr.Parameters.AddWithValue("@cin", cin);
                    result = addr.ExecuteScalar();
                    textadresse.Text = result.ToString();

                    //Recuperation du poids : 
                    SqlCommand poids = new SqlCommand("Select poids from donneurs where cin = @cin", conn);
                    poids.Parameters.AddWithValue("@cin", cin);
                    result = poids.ExecuteScalar();
                    textpoids.Text = result.ToString();

                    //Recuperation de l'antecedent medical : 
                    SqlCommand ant_med = new SqlCommand("Select A_Med from donneurs where cin = @cin", conn);
                    ant_med.Parameters.AddWithValue("@cin", cin);
                    result = ant_med.ExecuteScalar();
                    textantecedents.Text = result.ToString();

                    //Recuperation du Groupe Sanguin : 
                    SqlCommand G_sang = new SqlCommand("Select G_Sanguin from donneurs where cin = @cin", conn);
                    G_sang.Parameters.AddWithValue("@cin", cin);
                    result = G_sang.ExecuteScalar();
                    comboBox1.Text = result.ToString();

                    //Recuperation du Date de naissance  : 
                    SqlCommand D_Naiss = new SqlCommand("Select D_Naiss from donneurs where cin = @cin", conn);
                    D_Naiss.Parameters.AddWithValue("@cin", cin);
                    result = D_Naiss.ExecuteScalar();
                    datepicker.Text = result.ToString();

                    //Recuperation du num tel  : 
                    SqlCommand n_tel = new SqlCommand("Select tel from donneurs where cin = @cin", conn);
                    D_Naiss.Parameters.AddWithValue("@cin", cin);
                    result = n_tel.ExecuteScalar();
                    boxtel.Text = result.ToString();
                }


            }
            conn.Close();
        }



        void vider_interface()
        {
            textcin.Clear();
            textnom.Clear();
            textprenom.Clear();
            textadresse.Clear();
            textantecedents.Clear();
            comboBox1.ResetText();
            datepicker.ResetText();
            textpoids.Clear();
        }



        // CIN : 
        private void textcin_Click(object sender, EventArgs e)
        {
            Err_Cin.Visible = false;
            vider_interface();
        }

        bool ctrl_cin(String cin)
        {
            String pattern = @"^\d{8}$";

            if (Regex.IsMatch(cin, pattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Nom : 
        private void textnom_Leave(object sender, EventArgs e)
        {

            if (Ctrl_Nom(textnom.Text) == false)
            {
                Err_Nom.Visible = true;
            }

        }

        private void textnom_Click(object sender, EventArgs e)
        {
            Err_Nom.Visible = false;
        }

        bool Ctrl_Nom(String nom)
        {
            string pattern = @"^[a-zA-Z\s]*$";
            if (Regex.IsMatch(nom, pattern))
            {
                return true;
            }

            else
            {
                return false;
            }
        }


        // Prenom
        private void textprenom_Leave(object sender, EventArgs e)
        {
            if (Ctrl_Prenom(textprenom.Text) == false)
            {
                Err_Prenom.Visible = true;
            }
        }

        private void textprenom_Click(object sender, EventArgs e)
        {
            Err_Prenom.Visible = false;
        }

        bool Ctrl_Prenom(String prenom)
        {
            string pattern = @"^[a-zA-Z\s]*$";
            if (Regex.IsMatch(prenom, pattern))
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        // Adressse :
        private void textadresse_Leave(object sender, EventArgs e)
        {
            if (ctrl_adresse(textadresse.Text) == false)
            {
                Err_adrr.Visible = true;
            }
        }

        private void textadresse_Click(object sender, EventArgs e)
        {
            Err_adrr.Visible = false;
        }

        bool ctrl_adresse(String add)
        {
            string pattern = @"^[a-zA-Z0-9\s]*$";
            if (Regex.IsMatch(add, pattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Poids : 
        bool ctrl_Poids(float poids)
        {

            if (poids >= 50.0 && poids <= 150.0)
            {
                return true;
            }

            else
                return false;
        }

        private void textpoids_Leave(object sender, EventArgs e)
        {
            if (ctrl_Poids(float.Parse(textpoids.Text)) == false)
            {
                Err_Poids.Visible = true;
            }
        }

        private void textpoids_Click(object sender, EventArgs e)
        {
            Err_Poids.Visible = false;
        }

        private void boxtel_Leave(object sender, EventArgs e)
        {
            string pattern = @"^\d{8}$";


            if (!Regex.IsMatch(boxtel.Text, pattern))
            {
                errtel.Visible = true;
                errtel.Text = "Le numéro de téléphone doit contenir 8 chiffres";
                errtel.ForeColor = Color.Red;
            }

        }

        private void boxtel_Enter(object sender, EventArgs e)
        {
            errtel.Visible = false;
            boxtel.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu(); 
            menu.Show();
        }
    }

}
