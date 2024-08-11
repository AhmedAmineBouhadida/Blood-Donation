namespace Project_Donation
{
    partial class Suiv_Demandes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Suiv_Demandes));
            iddem = new TextBox();
            qte = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ajout_demande = new Button();
            comboBox1 = new ComboBox();
            combo2 = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // iddem
            // 
            iddem.Location = new Point(319, 205);
            iddem.Name = "iddem";
            iddem.Size = new Size(125, 27);
            iddem.TabIndex = 0;
            // 
            // qte
            // 
            qte.Location = new Point(319, 409);
            qte.Name = "qte";
            qte.Size = new Size(125, 27);
            qte.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.OldLace;
            label1.Location = new Point(92, 212);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 4;
            label1.Text = "Id Hop";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.OldLace;
            label2.Location = new Point(83, 334);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 5;
            label2.Text = "Type";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.OldLace;
            label3.Location = new Point(83, 416);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 6;
            label3.Text = "Quantité";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.OldLace;
            label4.Location = new Point(83, 497);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 7;
            label4.Text = "Urgence";
            // 
            // ajout_demande
            // 
            ajout_demande.Location = new Point(424, 624);
            ajout_demande.Name = "ajout_demande";
            ajout_demande.Size = new Size(157, 29);
            ajout_demande.TabIndex = 8;
            ajout_demande.Text = "Ajouter demande";
            ajout_demande.UseVisualStyleBackColor = true;
            ajout_demande.Click += ajout_demande_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" });
            comboBox1.Location = new Point(319, 326);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 9;
            // 
            // combo2
            // 
            combo2.FormattingEnabled = true;
            combo2.Items.AddRange(new object[] { "Vitale", "Grave", "Planifiée" });
            combo2.Location = new Point(319, 489);
            combo2.Name = "combo2";
            combo2.Size = new Size(151, 28);
            combo2.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(37, 624);
            button1.Name = "button1";
            button1.Size = new Size(157, 29);
            button1.TabIndex = 11;
            button1.Text = "retourner au menu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Suiv_Demandes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(777, 679);
            Controls.Add(button1);
            Controls.Add(combo2);
            Controls.Add(comboBox1);
            Controls.Add(ajout_demande);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(qte);
            Controls.Add(iddem);
            Name = "Suiv_Demandes";
            Text = "Suiv_Demandes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox iddem;
        private TextBox qte;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button ajout_demande;
        private ComboBox G_sang;
        private ComboBox comboBox1;
        private ComboBox combo2;
        private Button button1;
    }
}