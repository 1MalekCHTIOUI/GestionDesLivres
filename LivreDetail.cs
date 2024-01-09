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

namespace GestionDesLivres
{
    public partial class LivreDetail : Form
    {



     
        public LivreDetail()
        {
            InitializeComponent();
        }
        
        public void getLivre(Livre livre)
        {
            if (livre != null)
            {
                titreData.Text = livre.Titre;
                auteurData.Text = livre.Auteur;
                genreData.Text = livre.Genre;
                dateData.Text = livre.AnneeDePublication;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void AjoutForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {

        }

       

    }

}
