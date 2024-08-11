namespace Project_Donation
{
    partial class utilisateurs_cas_vitale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(utilisateurs_cas_vitale));
            button1 = new Button();
            listView1 = new ListView();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(305, 621);
            button1.Name = "button1";
            button1.Size = new Size(153, 29);
            button1.TabIndex = 1;
            button1.Text = "retourner au menu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listView1
            // 
            listView1.Location = new Point(115, 229);
            listView1.Name = "listView1";
            listView1.Size = new Size(557, 350);
            listView1.TabIndex = 4;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // utilisateurs_cas_vitale
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(777, 679);
            Controls.Add(listView1);
            Controls.Add(button1);
            DoubleBuffered = true;
            Name = "utilisateurs_cas_vitale";
            Text = "Utilisateurs Cas Vitale";
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private ListView listView1;
    }
}