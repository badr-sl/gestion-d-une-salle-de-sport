using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet__gestion
{
    public partial class Form1 : Form
    {
        
        private string connectionString = @"Data Source= ..\..\gestion.db;Version=3;";
       

        public Form1()
        {
            InitializeComponent();

        }


        private void button2_Click(object sender, EventArgs e)
        {
            string username = user.Text.Trim();
            string password = this.password.Text.Trim();

            if (IsValid(username, password))
            {
                if (AuthenticateUser(username, password))
                {
                   
                    Form2 form2 = new Form2();
                    form2.Show();
                    this.Hide();
                    MessageBox.Show("Connexion réussie !");

                }
                else
                {
                    MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect.");
                }
            }
        }

        private bool IsValid(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Veuillez entrer un nom d'utilisateur et un mot de passe.");
                return false;
            }
            return true;
        }
       
        private bool AuthenticateUser(string username, string password)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM login_table WHERE nom = @username AND password = @password";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    connection.Open();
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count == 1;
                }
            }
        }
    }
}




