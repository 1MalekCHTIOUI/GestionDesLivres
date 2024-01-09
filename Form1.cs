using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GestionDesLivres
{

    public partial class Form1 : Form
    {
        private DataGridViewRow selectedRow;
        public Form1()
        {
            InitializeComponent();
            
    }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateDB();

        }

        private void listviewBooks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void BooksDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRow = BooksDataGridView.Rows[e.RowIndex];
                Console.WriteLine(selectedRow);
                Console.WriteLine("aaaa");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Livre livre = new Livre(titre.Text, auteur.Text, genre.Text, datePub.Text);
            AddLivre(livre);
            LoadLivreDataGridView();
  
        }



        string dbPath = "F:/Developpement Web/C#/test/GestionDesLivres/projetcs.db";


        public void CreateDB()
        {
            Console.WriteLine("CREATING DB");
            if (!File.Exists(dbPath))
            {
                SQLiteConnection.CreateFile("Livres.db");
                using (SQLiteConnection con = new SQLiteConnection("Data Source=" + dbPath + ";Version=3;"))
                {

                    string sqlQuery = "CREATE TABLE IF NOT EXISTS Livres (" +
                                        "Id INTEGER PRIMARY KEY AUTOINCREMENT," +
                                        "Titre NVARCHAR(20)," +
                                        "Auteur NVARCHAR(20)," +
                                        "Genre NVARCHAR(20)," +
                                        "AnneeDePublication NVARCHAR(20))";
                    using (SQLiteCommand command = new SQLiteCommand(sqlQuery, con))
                    {
                        con.Open();
                        command.ExecuteNonQuery();
                    }
                }

            }
            else
            {
                LoadLivreDataGridView();

            }
        }


        public void LoadLivreDataGridView()
        {
            Console.WriteLine("LOADING DATA AGAIN");
            DataTable dataTable = GetAllLivres();
            BooksDataGridView.AutoGenerateColumns = false;
            BooksDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            BooksDataGridView.DataSource = dataTable;
            BooksDataGridView.Columns.Clear();
            BooksDataGridView.Columns.Add("Id", "Id");
            BooksDataGridView.Columns["Id"].DataPropertyName = "Id";
            BooksDataGridView.Columns["Id"].Visible = false;

            BooksDataGridView.Columns.Add("Genre", "Genre");
            BooksDataGridView.Columns["Genre"].DataPropertyName = "Genre";
            BooksDataGridView.Columns["Genre"].Visible = false;

            BooksDataGridView.Columns.Add("AnneeDePublication", "AnneeDePublication");
            BooksDataGridView.Columns["AnneeDePublication"].DataPropertyName = "AnneeDePublication";
            BooksDataGridView.Columns["AnneeDePublication"].Visible = false;

            BooksDataGridView.Columns.Add("Titre", "Titre");
            BooksDataGridView.Columns["Titre"].DataPropertyName = "Titre";

            BooksDataGridView.Columns.Add("Auteur", "Auteur");
            BooksDataGridView.Columns["Auteur"].DataPropertyName = "Auteur";
        }


        public DataTable GetAllLivres()
        {
            //List<Livre> livres = new List<Livre>();
            DataTable livres = new DataTable();

            using (SQLiteConnection con = new SQLiteConnection("Data Source=" + dbPath + ";Version=3;"))
            {
                string query = "SELECT * FROM Livres";

                using (SQLiteCommand command = new SQLiteCommand(query, con))
                {
                    con.Open();
                    SQLiteDataReader reader = command.ExecuteReader();
                    livres.Load(reader);
                }
            }

            return livres;
        }



        private void SetLivreParameters(SQLiteCommand command, Livre livre)
        {
            command.Parameters.AddWithValue("@Titre", livre.Titre);
            command.Parameters.AddWithValue("@Auteur", livre.Auteur);
            command.Parameters.AddWithValue("@Genre", livre.Genre);
            command.Parameters.AddWithValue("@AnneeDePublication", livre.AnneeDePublication);
        }


        public void AddLivre(Livre livre)
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection("Data Source=" + dbPath + ";Version=3;"))
                {

                    string sqlQuery = "INSERT INTO Livres (Titre, Auteur, Genre, AnneeDePublication) " +
                                      "VALUES (@Titre, @Auteur, @Genre, @AnneeDePublication)";

                    using (SQLiteCommand command = new SQLiteCommand(sqlQuery, con))
                    {
                        con.Open();
                        SetLivreParameters(command, livre);
                        command.ExecuteNonQuery();
                        Console.WriteLine(livre.Titre + " added");
                        resetForm();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error adding Livre: " + ex.Message);

            }
        }
        public void UpdateLivre(Livre livre)
        {


            string query = "UPDATE Livres SET Titre = @Titre, Auteur = @Auteur, " +
                            "Genre = @Genre, AnneeDePublication = @AnneeDePublication " +
                            "WHERE Id = @Id";

            SQLiteConnection con = new SQLiteConnection("Data Source=" + dbPath + ";Version=3;");
            try
            {
                using (SQLiteCommand command = new SQLiteCommand(query, con))
                {
                    con.Open();
                    SetLivreParameters(command, livre);
                    command.Parameters.AddWithValue("@Id", livre.Id);
                    command.ExecuteNonQuery();
                    resetForm();

                }
                
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        public void DeleteLivre(int livreId)
        {
            string query = "DELETE FROM Livres WHERE Id = @Id";
            SQLiteConnection con = new SQLiteConnection("Data Source=" + dbPath + ";Version=3;");


            using (SQLiteCommand command = new SQLiteCommand(query, con))
            {
                con.Open();
                command.Parameters.AddWithValue("@Id", livreId);
                command.ExecuteNonQuery();
                resetForm();
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedRow != null)
            {

                string title = selectedRow.Cells["Titre"].Value.ToString();
                string author = selectedRow.Cells["Auteur"].Value.ToString();
                string id = selectedRow.Cells["Id"].Value.ToString();
                string gr = selectedRow.Cells["Genre"].Value.ToString();
                string anneePub = selectedRow.Cells["AnneeDePublication"].Value.ToString();
                _id.Text = id;
                titre.Text = title;
                auteur.Text = author;
                genre.Text = gr;
                datePub.Text = anneePub;
            }

        }
        
        
        private void btnChar_Click(object sender, EventArgs e)
        {
            if (selectedRow != null)
            {

                string title = selectedRow.Cells["Titre"].Value.ToString();
                string author = selectedRow.Cells["Auteur"].Value.ToString();
                string id = selectedRow.Cells["Id"].Value.ToString();
                string gr = selectedRow.Cells["Genre"].Value.ToString();
                string anneePub = selectedRow.Cells["AnneeDePublication"].Value.ToString();
                Livre lv = new Livre(title, author, gr, anneePub);
                LivreDetail ld = new LivreDetail();
                ld.getLivre(lv);
                ld.Show();
            }
        }


        private void resetForm ()
        {
            titre.Text = string.Empty;
            auteur.Text = string.Empty;
            genre.Text = string.Empty;
            datePub.Text = string.Empty;
            _id.Text = string.Empty;
            selectedRow = null;
        }

        private void update2_Click(object sender, EventArgs e)
        {
            if(selectedRow != null) { 
            
                UpdateLivre(new Livre(int.Parse(_id.Text), titre.Text, auteur.Text, genre.Text, datePub.Text));
                LoadLivreDataGridView();
            }


        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (selectedRow != null)
            {

                int id = int.Parse(selectedRow.Cells["Id"].Value.ToString()); 
                Console.WriteLine(id);
                DeleteLivre(id);
                LoadLivreDataGridView();
                

            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    



}





public class Livre
    {
        private int _id;
        private string _titre;
        private string _auteur;
        private string _genre;
        private string _anneeDePublication;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Titre
        {
            get { return _titre; }
            set { _titre = value; }
        }

        public string Auteur
        {
            get { return _auteur; }
            set { _auteur = value; }
        }


        public string Genre
        {
            get { return _genre; }
            set { _genre = value; }
        }

        public string AnneeDePublication
        {
            get { return _anneeDePublication; }
            set { _anneeDePublication = value; }
        }

        public Livre()
        {
           
        }

        // Constructor with parameters
        public Livre(string titre, string auteur, string genre, string anneeDePublication)
        {

            _titre = titre;
            _auteur = auteur;
            _genre = genre;
            _anneeDePublication = anneeDePublication;
        }
        public Livre(int id,string titre, string auteur, string genre, string anneeDePublication)
        {
            _id = id;
            _titre = titre;
            _auteur = auteur;
            _genre = genre;
            _anneeDePublication = anneeDePublication;
        }
}


