namespace Project_Donation
{
    partial class Inscription
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inscription));
            Btn_Ajouter = new Button();
            textcin = new TextBox();
            textnom = new TextBox();
            textprenom = new TextBox();
            textadresse = new TextBox();
            textpoids = new TextBox();
            textantecedents = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            datepicker = new DateTimePicker();
            comboBox1 = new ComboBox();
            Err_Cin = new Label();
            Err_Nom = new Label();
            Err_Prenom = new Label();
            Err_Poids = new Label();
            Err_adrr = new Label();
            boxtel = new TextBox();
            label9 = new Label();
            errtel = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // Btn_Ajouter
            // 
            Btn_Ajouter.Location = new Point(596, 633);
            Btn_Ajouter.Name = "Btn_Ajouter";
            Btn_Ajouter.Size = new Size(157, 34);
            Btn_Ajouter.TabIndex = 0;
            Btn_Ajouter.Text = "Ajouter";
            Btn_Ajouter.UseVisualStyleBackColor = true;
            Btn_Ajouter.Click += Btn_Ajouter_Click;
            // 
            // textcin
            // 
            textcin.Location = new Point(73, 288);
            textcin.Name = "textcin";
            textcin.Size = new Size(139, 27);
            textcin.TabIndex = 1;
            textcin.Click += textcin_Click;
            textcin.Leave += textcin_Leave;
            // 
            // textnom
            // 
            textnom.Location = new Point(306, 288);
            textnom.Name = "textnom";
            textnom.Size = new Size(132, 27);
            textnom.TabIndex = 2;
            textnom.Click += textnom_Click;
            textnom.Leave += textnom_Leave;
            // 
            // textprenom
            // 
            textprenom.Location = new Point(565, 288);
            textprenom.Name = "textprenom";
            textprenom.Size = new Size(131, 27);
            textprenom.TabIndex = 3;
            textprenom.Click += textprenom_Click;
            textprenom.Leave += textprenom_Leave;
            // 
            // textadresse
            // 
            textadresse.Location = new Point(72, 416);
            textadresse.Name = "textadresse";
            textadresse.Size = new Size(140, 27);
            textadresse.TabIndex = 4;
            textadresse.Click += textadresse_Click;
            textadresse.Leave += textadresse_Leave;
            // 
            // textpoids
            // 
            textpoids.Location = new Point(295, 418);
            textpoids.Name = "textpoids";
            textpoids.Size = new Size(143, 27);
            textpoids.TabIndex = 6;
            textpoids.Click += textpoids_Click;
            textpoids.Leave += textpoids_Leave;
            // 
            // textantecedents
            // 
            textantecedents.Location = new Point(565, 418);
            textantecedents.Name = "textantecedents";
            textantecedents.Size = new Size(131, 27);
            textantecedents.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.OldLace;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(115, 260);
            label1.Name = "label1";
            label1.Size = new Size(43, 25);
            label1.TabIndex = 9;
            label1.Text = "CIN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.OldLace;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(335, 260);
            label2.Name = "label2";
            label2.Size = new Size(51, 25);
            label2.TabIndex = 10;
            label2.Text = "Nom";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.OldLace;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(587, 260);
            label3.Name = "label3";
            label3.Size = new Size(72, 25);
            label3.TabIndex = 11;
            label3.Text = "Prenom";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.OldLace;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(552, 520);
            label4.Name = "label4";
            label4.Size = new Size(140, 25);
            label4.TabIndex = 12;
            label4.Text = "Date Naissance ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.OldLace;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(104, 388);
            label5.Name = "label5";
            label5.Size = new Size(71, 25);
            label5.TabIndex = 13;
            label5.Text = "Adresse";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.OldLace;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(83, 520);
            label6.Name = "label6";
            label6.Size = new Size(129, 25);
            label6.TabIndex = 14;
            label6.Text = "Group Sanguin";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.OldLace;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(335, 388);
            label7.Name = "label7";
            label7.Size = new Size(54, 25);
            label7.TabIndex = 15;
            label7.Text = "Poids";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.OldLace;
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.Location = new Point(552, 388);
            label8.Name = "label8";
            label8.Size = new Size(187, 25);
            label8.TabIndex = 16;
            label8.Text = "Antecedents medicaux";
            // 
            // datepicker
            // 
            datepicker.Location = new Point(481, 549);
            datepicker.Name = "datepicker";
            datepicker.Size = new Size(272, 27);
            datepicker.TabIndex = 17;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" });
            comboBox1.Location = new Point(73, 548);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(140, 28);
            comboBox1.TabIndex = 18;
            // 
            // Err_Cin
            // 
            Err_Cin.AutoSize = true;
            Err_Cin.BackColor = SystemColors.Control;
            Err_Cin.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Err_Cin.ForeColor = Color.Red;
            Err_Cin.Location = new Point(93, 318);
            Err_Cin.Name = "Err_Cin";
            Err_Cin.Size = new Size(92, 20);
            Err_Cin.TabIndex = 19;
            Err_Cin.Text = "CIN Invalide";
            Err_Cin.Visible = false;
            // 
            // Err_Nom
            // 
            Err_Nom.AutoSize = true;
            Err_Nom.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Err_Nom.ForeColor = Color.Red;
            Err_Nom.Location = new Point(316, 318);
            Err_Nom.Name = "Err_Nom";
            Err_Nom.Size = new Size(101, 20);
            Err_Nom.TabIndex = 20;
            Err_Nom.Text = "Nom Invalide";
            Err_Nom.Visible = false;
            // 
            // Err_Prenom
            // 
            Err_Prenom.AutoSize = true;
            Err_Prenom.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Err_Prenom.ForeColor = Color.Red;
            Err_Prenom.Location = new Point(565, 318);
            Err_Prenom.Name = "Err_Prenom";
            Err_Prenom.Size = new Size(121, 20);
            Err_Prenom.TabIndex = 21;
            Err_Prenom.Text = "Prenom Invalide";
            Err_Prenom.Visible = false;
            // 
            // Err_Poids
            // 
            Err_Poids.AutoSize = true;
            Err_Poids.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Err_Poids.ForeColor = Color.Red;
            Err_Poids.Location = new Point(307, 448);
            Err_Poids.Name = "Err_Poids";
            Err_Poids.Size = new Size(103, 20);
            Err_Poids.TabIndex = 22;
            Err_Poids.Text = "Poids invalide";
            Err_Poids.Visible = false;
            // 
            // Err_adrr
            // 
            Err_adrr.AutoSize = true;
            Err_adrr.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Err_adrr.ForeColor = Color.Red;
            Err_adrr.Location = new Point(73, 446);
            Err_adrr.Name = "Err_adrr";
            Err_adrr.Size = new Size(120, 20);
            Err_adrr.TabIndex = 23;
            Err_adrr.Text = "Adresse invalide";
            Err_adrr.Visible = false;
            // 
            // boxtel
            // 
            boxtel.Location = new Point(295, 549);
            boxtel.Name = "boxtel";
            boxtel.Size = new Size(143, 27);
            boxtel.TabIndex = 24;
            boxtel.Enter += boxtel_Enter;
            boxtel.Leave += boxtel_Leave;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.OldLace;
            label9.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.Location = new Point(334, 520);
            label9.Name = "label9";
            label9.Size = new Size(76, 25);
            label9.TabIndex = 25;
            label9.Text = "Num tel";
            // 
            // errtel
            // 
            errtel.AutoSize = true;
            errtel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            errtel.ForeColor = Color.Red;
            errtel.Location = new Point(324, 579);
            errtel.Name = "errtel";
            errtel.Size = new Size(86, 20);
            errtel.TabIndex = 26;
            errtel.Text = "Tel invalide";
            errtel.Visible = false;
            // 
            // button1
            // 
            button1.Location = new Point(12, 633);
            button1.Name = "button1";
            button1.Size = new Size(157, 29);
            button1.TabIndex = 27;
            button1.Text = "Retourner au menu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Inscription
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(777, 679);
            Controls.Add(button1);
            Controls.Add(errtel);
            Controls.Add(label9);
            Controls.Add(boxtel);
            Controls.Add(Err_adrr);
            Controls.Add(Err_Poids);
            Controls.Add(Err_Prenom);
            Controls.Add(Err_Nom);
            Controls.Add(Err_Cin);
            Controls.Add(comboBox1);
            Controls.Add(datepicker);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textantecedents);
            Controls.Add(textpoids);
            Controls.Add(textadresse);
            Controls.Add(textprenom);
            Controls.Add(textnom);
            Controls.Add(textcin);
            Controls.Add(Btn_Ajouter);
            DoubleBuffered = true;
            Name = "Inscription";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btn_Ajouter;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private DateTimePicker dateTimePicker1;
        private TextBox textcin;
        private TextBox textnom;
        private TextBox textprenom;
        private TextBox textadresse;
        private TextBox textpoids;
        private TextBox textantecedents;
        private DateTimePicker datepicker;
        private ComboBox comboBox1;
        private Label Err_Cin;
        private Label Err_Nom;
        private Label Err_Prenom;
        private Label Err_Poids;
        private Label Err_adrr;
        private TextBox boxtel;
        private Label label9;
        private Label errtel;
        private Button button1;
    }
}