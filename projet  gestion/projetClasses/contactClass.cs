using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet__gestion.projetClasses
{
    internal class contactClass
    {
        private string connectionString = @"Data Source= ..\..\gestion.db;";
        public int Id { get; set; }
        public string Nombox { get; set; }
        public string Prenombox { get; set; }
        public string Tel { get; set; }
        public double Montantbox { get; set; }
        public DateTime Datedebutbox { get; set; }
        public DateTime Datefinbox { get; set; }
        public string Description { get; set; }
        public string Genrebox { get; set; }

        //static string Myconnstring = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

        public DataTable Select()
        {
            SQLiteConnection conn = new SQLiteConnection(connectionString);
            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT * FROM tbl_contact";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
                    {
                        conn.Open();
                        adapter.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                // Gérer les exceptions ici
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }


        public DataTable SelectNonPayé()
        {
            SQLiteConnection conn = new SQLiteConnection(connectionString);
            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT * FROM tbl_contact WHERE date_fin < date('now');";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@DateActuelle", DateTime.Now);

                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
                    {
                        conn.Open();
                        adapter.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }






        public bool Add(contactClass c)
        {
            // Création d'une valeur de retour par défaut et la définir sur false
            bool isSuccess = false;

            // Connexion à la base de données SQLite
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                try
                {
                    // Requête SQL pour insérer des données dans la table tbl_contact
                    string sql = "INSERT INTO tbl_contact (nom, prenom, tel, montant, date_debut, date_fin, description, genre) VALUES (@nom, @prenom, @tel, @montant, @dateDebut, @dateFin, @description, @genre)";

                    // Création de la commande SQL
                    using (SQLiteCommand command = new SQLiteCommand(sql, conn))
                    {
                        // Ajout des paramètres avec les valeurs correspondantes
                        command.Parameters.AddWithValue("@nom", c.Nombox);
                        command.Parameters.AddWithValue("@prenom", c.Prenombox);
                        command.Parameters.AddWithValue("@tel", c.Tel);
                        command.Parameters.AddWithValue("@montant", c.Montantbox);
                        command.Parameters.AddWithValue("@dateDebut", c.Datedebutbox);
                        command.Parameters.AddWithValue("@dateFin", c.Datefinbox);
                        command.Parameters.AddWithValue("@description", c.Description);
                        command.Parameters.AddWithValue("@genre", c.Genrebox);

                        // Ouverture de la connexion à la base de données
                        conn.Open();

                        // Exécution de la commande SQL et obtention du nombre de lignes affectées
                        int rows = command.ExecuteNonQuery();

                        // Si la requête s'exécute avec succès, le nombre de lignes affectées sera supérieur à zéro
                        if (rows > 0)
                        {
                            isSuccess = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Gestion des exceptions ici
                }
            }

            return isSuccess;
        }






        public bool Update(contactClass c)
        {
            bool isSuccess = false;
            SQLiteConnection conn = new SQLiteConnection(connectionString);

            try
            {
                string sql = "UPDATE tbl_contact SET nom=@nom, prenom=@prenom, tel=@tel, montant=@montant, date_debut=@dateDebut , date_fin=@dateFin , description=@description , genre=@genre WHERE id=@ID";

                using (SQLiteCommand command = new SQLiteCommand(sql, conn))
                {
                    command.Parameters.AddWithValue("@nom", c.Nombox);
                    command.Parameters.AddWithValue("@prenom", c.Prenombox);
                    command.Parameters.AddWithValue("@tel", c.Tel);
                    command.Parameters.AddWithValue("@montant", c.Montantbox);
                    command.Parameters.AddWithValue("@dateDebut", c.Datedebutbox);
                    command.Parameters.AddWithValue("@dateFin", c.Datefinbox);
                    command.Parameters.AddWithValue("@description", c.Description);
                    command.Parameters.AddWithValue("@genre", c.Genrebox);
                    command.Parameters.AddWithValue("@ID", c.Id);

                    conn.Open();

                    int rows = command.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        isSuccess = true;
                    }
                }
            }
            catch (Exception ex)
            {
                // Gérer les exceptions ici
            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }



        public bool Delete(contactClass c)
        {
            bool isSuccess = false;
            SQLiteConnection conn = new SQLiteConnection(connectionString);

            try
            {
                string sql = "DELETE FROM tbl_contact WHERE id = @ContactID";

                using (SQLiteCommand command = new SQLiteCommand(sql, conn))
                {
                    command.Parameters.AddWithValue("@ContactID", c.Id);

                    conn.Open();

                    int rows = command.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        isSuccess = true;
                    }
                }
            }
            catch (Exception ex)
            {
                // Gérer les exceptions ici
            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }



    }
}
