namespace Project_Donation
{
    partial class GestStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestStock));
            Titre = new Label();
            label1 = new Label();
            label2 = new Label();
            cin = new TextBox();
            quantité = new TextBox();
            valider = new Button();
            errcin = new Label();
            errqté = new Label();
            errcin_indspo = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // Titre
            // 
            Titre.AutoSize = true;
            Titre.BackColor = Color.OldLace;
            Titre.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Titre.Location = new Point(303, 43);
            Titre.Name = "Titre";
            Titre.Size = new Size(148, 31);
            Titre.TabIndex = 0;
            Titre.Text = "Don de Sang";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.OldLace;
            label1.Location = new Point(203, 261);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 1;
            label1.Text = "CIN donneurs ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.OldLace;
            label2.Location = new Point(198, 420);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 2;
            label2.Text = "Quantité en ml";
            // 
            // cin
            // 
            cin.Location = new Point(409, 258);
            cin.Name = "cin";
            cin.PlaceholderText = "Donner le CIN ";
            cin.Size = new Size(154, 27);
            cin.TabIndex = 3;
            cin.Click += cin_Click;
            // 
            // quantité
            // 
            quantité.Location = new Point(399, 413);
            quantité.Name = "quantité";
            quantité.PlaceholderText = "Donner la quantité ";
            quantité.Size = new Size(154, 27);
            quantité.TabIndex = 4;
            // 
            // valider
            // 
            valider.Location = new Point(595, 602);
            valider.Name = "valider";
            valider.Size = new Size(157, 29);
            valider.TabIndex = 5;
            valider.Text = "valider";
            valider.UseVisualStyleBackColor = true;
            valider.Click += valider_Click;
            // 
            // errcin
            // 
            errcin.AutoSize = true;
            errcin.ForeColor = Color.Red;
            errcin.Location = new Point(435, 298);
            errcin.Name = "errcin";
            errcin.Size = new Size(89, 20);
            errcin.TabIndex = 6;
            errcin.Text = "CIN Invalide";
            errcin.Visible = false;
            // 
            // errqté
            // 
            errqté.AutoSize = true;
            errqté.ForeColor = Color.Red;
            errqté.Location = new Point(409, 454);
            errqté.Name = "errqté";
            errqté.Size = new Size(126, 20);
            errqté.TabIndex = 7;
            errqté.Text = "Quantité invalide ";
            errqté.Visible = false;
            // 
            // errcin_indspo
            // 
            errcin_indspo.AutoSize = true;
            errcin_indspo.ForeColor = Color.Red;
            errcin_indspo.Location = new Point(435, 327);
            errcin_indspo.Name = "errcin_indspo";
            errcin_indspo.Size = new Size(107, 20);
            errcin_indspo.TabIndex = 8;
            errcin_indspo.Text = "CIN intouvable";
            errcin_indspo.Visible = false;
            // 
            // button1
            // 
            button1.Location = new Point(421, 602);
            button1.Name = "button1";
            button1.Size = new Size(157, 29);
            button1.TabIndex = 9;
            button1.Text = "Retourner au menu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // GestStock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(777, 679);
            Controls.Add(button1);
            Controls.Add(errcin_indspo);
            Controls.Add(errqté);
            Controls.Add(errcin);
            Controls.Add(valider);
            Controls.Add(quantité);
            Controls.Add(cin);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Titre);
            DoubleBuffered = true;
            Name = "GestStock";
            Text = "GestStock";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Titre;
        private Label label1;
        private Label label2;
        private TextBox cin;
        private TextBox quantité;
        private Button valider;
        private Label errcin;
        private Label errqté;
        private Label errcin_indspo;
        private Button button1;
    }
}