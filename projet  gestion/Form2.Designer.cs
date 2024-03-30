namespace projet__gestion
{
    partial class Form2
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
            this.recherchebox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridbox = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ajouté = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.datefinbox = new System.Windows.Forms.DateTimePicker();
            this.datedebutbox = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.descriptionbox = new System.Windows.Forms.TextBox();
            this.genrebox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.montantbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.telbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.prenombox = new System.Windows.Forms.TextBox();
            this.nombox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.idbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridbox)).BeginInit();
            this.SuspendLayout();
            // 
            // recherchebox
            // 
            this.recherchebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recherchebox.Location = new System.Drawing.Point(940, 75);
            this.recherchebox.Name = "recherchebox";
            this.recherchebox.Size = new System.Drawing.Size(582, 30);
            this.recherchebox.TabIndex = 50;
            this.recherchebox.TextChanged += new System.EventHandler(this.recherchebox_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(797, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 25);
            this.label9.TabIndex = 49;
            this.label9.Text = "Rechercher :";
            // 
            // dataGridbox
            // 
            this.dataGridbox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridbox.Location = new System.Drawing.Point(567, 147);
            this.dataGridbox.Name = "dataGridbox";
            this.dataGridbox.RowHeadersWidth = 51;
            this.dataGridbox.RowTemplate.Height = 24;
            this.dataGridbox.Size = new System.Drawing.Size(942, 467);
            this.dataGridbox.TabIndex = 47;
            this.dataGridbox.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridbox_CellContentClick);
            this.dataGridbox.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridbox_RowHeaderMouseClick);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Orange;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(1239, 674);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 47);
            this.button3.TabIndex = 46;
            this.button3.Text = "Afficher";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Crimson;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(1039, 674);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 47);
            this.button4.TabIndex = 45;
            this.button4.Text = "Supprimer";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SteelBlue;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(847, 674);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 47);
            this.button2.TabIndex = 44;
            this.button2.Text = "Modifier";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ajouté
            // 
            this.ajouté.BackColor = System.Drawing.Color.ForestGreen;
            this.ajouté.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajouté.ForeColor = System.Drawing.Color.White;
            this.ajouté.Location = new System.Drawing.Point(650, 674);
            this.ajouté.Name = "ajouté";
            this.ajouté.Size = new System.Drawing.Size(133, 47);
            this.ajouté.TabIndex = 43;
            this.ajouté.Text = "Ajouter";
            this.ajouté.UseVisualStyleBackColor = false;
            this.ajouté.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 359);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 25);
            this.label8.TabIndex = 42;
            this.label8.Text = "Date fin :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 25);
            this.label7.TabIndex = 41;
            this.label7.Text = "Date début :";
            // 
            // datefinbox
            // 
            this.datefinbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datefinbox.Location = new System.Drawing.Point(198, 354);
            this.datefinbox.Name = "datefinbox";
            this.datefinbox.Size = new System.Drawing.Size(288, 30);
            this.datefinbox.TabIndex = 40;
            // 
            // datedebutbox
            // 
            this.datedebutbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datedebutbox.Location = new System.Drawing.Point(198, 285);
            this.datedebutbox.Name = "datedebutbox";
            this.datedebutbox.Size = new System.Drawing.Size(288, 30);
            this.datedebutbox.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 431);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 25);
            this.label6.TabIndex = 38;
            this.label6.Text = "Description :";
            // 
            // descriptionbox
            // 
            this.descriptionbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionbox.Location = new System.Drawing.Point(198, 428);
            this.descriptionbox.Multiline = true;
            this.descriptionbox.Name = "descriptionbox";
            this.descriptionbox.Size = new System.Drawing.Size(288, 106);
            this.descriptionbox.TabIndex = 37;
            // 
            // genrebox
            // 
            this.genrebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genrebox.FormattingEnabled = true;
            this.genrebox.Items.AddRange(new object[] {
            "Homme",
            "Femme"});
            this.genrebox.Location = new System.Drawing.Point(198, 581);
            this.genrebox.Name = "genrebox";
            this.genrebox.Size = new System.Drawing.Size(288, 33);
            this.genrebox.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 589);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 25);
            this.label5.TabIndex = 35;
            this.label5.Text = "Genre :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 25);
            this.label4.TabIndex = 34;
            this.label4.Text = "Montant payé :";
            // 
            // montantbox
            // 
            this.montantbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.montantbox.Location = new System.Drawing.Point(278, 214);
            this.montantbox.Name = "montantbox";
            this.montantbox.Size = new System.Drawing.Size(149, 30);
            this.montantbox.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 25);
            this.label3.TabIndex = 32;
            this.label3.Text = "Tel :";
            // 
            // telbox
            // 
            this.telbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telbox.Location = new System.Drawing.Point(198, 147);
            this.telbox.Name = "telbox";
            this.telbox.Size = new System.Drawing.Size(288, 30);
            this.telbox.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(336, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 30;
            this.label2.Text = "Prenom :";
            // 
            // prenombox
            // 
            this.prenombox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenombox.Location = new System.Drawing.Point(442, 75);
            this.prenombox.Name = "prenombox";
            this.prenombox.Size = new System.Drawing.Size(217, 30);
            this.prenombox.TabIndex = 29;
            // 
            // nombox
            // 
            this.nombox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombox.Location = new System.Drawing.Point(94, 77);
            this.nombox.Name = "nombox";
            this.nombox.Size = new System.Drawing.Size(212, 30);
            this.nombox.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "Nom :";
            // 
            // idbox
            // 
            this.idbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idbox.Location = new System.Drawing.Point(687, 75);
            this.idbox.Name = "idbox";
            this.idbox.ReadOnly = true;
            this.idbox.Size = new System.Drawing.Size(39, 30);
            this.idbox.TabIndex = 51;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1795, 744);
            this.Controls.Add(this.idbox);
            this.Controls.Add(this.recherchebox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridbox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ajouté);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.datefinbox);
            this.Controls.Add(this.datedebutbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.descriptionbox);
            this.Controls.Add(this.genrebox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.montantbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.telbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.prenombox);
            this.Controls.Add(this.nombox);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox recherchebox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridbox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button ajouté;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker datefinbox;
        private System.Windows.Forms.DateTimePicker datedebutbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox descriptionbox;
        private System.Windows.Forms.ComboBox genrebox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox montantbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox telbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox prenombox;
        private System.Windows.Forms.TextBox nombox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idbox;
    }
}