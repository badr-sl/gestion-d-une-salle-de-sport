using projet__gestion.projetClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet__gestion

{

    public partial class Form2 : Form
    {
        private string connectionString = @"Data Source= ..\..\gestion.db;Version=3;";
        public Form2()
        {
            InitializeComponent();
        }
        contactClass c = new contactClass();

        private void Form2_Load(object sender, EventArgs e)
        {
            DataTable dt = c.Select();
            dataGridbox.DataSource = dt;

        }
        public void Clear()
        {
            idbox.Text = "";
            nombox.Text = "";
            prenombox.Text = "";
            telbox.Text = "";
            montantbox.Text = "";
            datedebutbox.Text = "";
            datefinbox.Text = "";
            descriptionbox.Text = "";
            genrebox.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(nombox.Text) || string.IsNullOrEmpty(prenombox.Text) || string.IsNullOrEmpty(telbox.Text) || string.IsNullOrEmpty(montantbox.Text) || string.IsNullOrEmpty(datedebutbox.Text) || string.IsNullOrEmpty(datefinbox.Text) || string.IsNullOrEmpty(descriptionbox.Text) || string.IsNullOrEmpty(genrebox.Text))
                {
                    throw new Exception("Veuillez remplir tous les champs.");
                }

                double montant;
                if (!double.TryParse(montantbox.Text, out montant))
                {
                    throw new Exception("Veuillez saisir un montant valide.");
                }

                DateTime dateDebut;
                if (!DateTime.TryParse(datedebutbox.Text, out dateDebut))
                {
                    throw new Exception("Veuillez saisir une date de début valide.");
                }

                DateTime dateFin;
                if (!DateTime.TryParse(datefinbox.Text, out dateFin))
                {
                    throw new Exception("Veuillez saisir une date de fin valide.");
                }

                c.Nombox = nombox.Text;
                c.Prenombox = prenombox.Text;
                c.Tel = telbox.Text;
                c.Montantbox = montant;
                c.Datedebutbox = dateDebut;
                c.Datefinbox = dateFin;
                c.Description = descriptionbox.Text;
                c.Genrebox = genrebox.Text;

                bool success = c.Add(c);
                if (success)
                {
                    MessageBox.Show("Client ajouté avec succès.");
                    DataTable dt = c.Select();
                    dataGridbox.DataSource = dt;
                    Clear();
                }
                else
                {
                    MessageBox.Show("Erreur lors de l'ajout du client.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }


        private void dataGridbox_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void dataGridbox_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowindex = e.RowIndex;
            idbox.Text = dataGridbox.Rows[rowindex].Cells[0].Value.ToString();
            nombox.Text= dataGridbox.Rows[rowindex].Cells[1].Value.ToString();
            prenombox.Text = dataGridbox.Rows[rowindex].Cells[2].Value.ToString();
            telbox.Text = dataGridbox.Rows[rowindex].Cells[3].Value.ToString();
            montantbox.Text = dataGridbox.Rows[rowindex].Cells[4].Value.ToString();
            datedebutbox.Text = dataGridbox.Rows[rowindex].Cells[5].Value.ToString();
            datefinbox.Text = dataGridbox.Rows[rowindex].Cells[6].Value.ToString();
            descriptionbox.Text = dataGridbox.Rows[rowindex].Cells[7].Value.ToString();
            genrebox.Text = dataGridbox.Rows[rowindex].Cells[8].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(idbox.Text) || string.IsNullOrEmpty(nombox.Text) || string.IsNullOrEmpty(prenombox.Text) || string.IsNullOrEmpty(telbox.Text) || string.IsNullOrEmpty(montantbox.Text) || string.IsNullOrEmpty(datedebutbox.Text) || string.IsNullOrEmpty(datefinbox.Text) || string.IsNullOrEmpty(descriptionbox.Text) || string.IsNullOrEmpty(genrebox.Text))
                {
                    throw new Exception("Veuillez remplir tous les champs.");
                }

                c.Id = Convert.ToInt32(idbox.Text);
                c.Nombox = nombox.Text;
                c.Prenombox = prenombox.Text;
                c.Tel = telbox.Text;
                c.Montantbox = double.Parse(montantbox.Text);
                c.Datedebutbox = DateTime.Parse(datedebutbox.Text);
                c.Datefinbox = DateTime.Parse(datefinbox.Text);
                c.Description = descriptionbox.Text;
                c.Genrebox = genrebox.Text;

                bool success = c.Update(c);
                if (success)
                {
                    MessageBox.Show("Les informations du client ont été modifiées avec succès.");
                    DataTable dt = c.Select();
                    dataGridbox.DataSource = dt;
                    Clear();
                }
                else
                {
                    MessageBox.Show("Les informations du client n'ont pas été modifiées.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la modification des informations du client : " + ex.Message);
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(idbox.Text))
                {
                    throw new Exception("Veuillez spécifier l'ID du client à supprimer.");
                }

                c.Id = Convert.ToInt32(idbox.Text);

                bool success = c.Delete(c);
                if (success)
                {
                    MessageBox.Show("Le client a été supprimé avec succès.");
                    DataTable dt = c.Select();
                    dataGridbox.DataSource = dt;
                    Clear();
                }
                else
                {
                    MessageBox.Show("Échec de la suppression du client.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la suppression du client : " + ex.Message);
            }
        }


        private void recherchebox_TextChanged(object sender, EventArgs e)
        {
            string keyword = recherchebox.Text;

            SQLiteConnection conn = new SQLiteConnection(connectionString);
            SQLiteDataAdapter sda = new SQLiteDataAdapter("SELECT * FROM tbl_contact WHERE nom LIKE '%" + keyword + "%' OR prenom LIKE '%"+ @keyword +"%' OR tel LIKE '%"+ @keyword +"%'", conn);
            sda.SelectCommand.Parameters.AddWithValue("@keyword", keyword);

            DataTable dt = new DataTable();
            sda.Fill(dt);

            dataGridbox.DataSource = dt;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }
    }
}
