using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movies
{
    public partial class SearchResults : Form
    {
        public SearchResults()
        {
            InitializeComponent();
        }

        private void SearchResults_Load(object sender, EventArgs e)
        {
            var result = Repository.GetAllMovies();

            //TODO: FILTER !!!
            
            lstResults.DataSource = result.ToArray();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //1. Visa alla filmer som släpptes någon gång under 90-talet.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Visa alla filmer vars Actor-lista innehåller tre skådespelare  (tips: för detta kan du behöva använda metoden Count)
        }


        private void button3_Click(object sender, EventArgs e)
        {
            /// Visa alla filmer som där någon av skådespelarna i filmen var äldre än 40 år när filmen gjordes

        }


        private void button4_Click(object sender, EventArgs e)
        {
            //Visa alla skådespelare som är äldre än 50 år. Sortera skådespelarna på namn.

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Visa alla skådespelare som har bokstaven "g" eller ”G” i sitt namn. Det skall inte spela
            //någon roll om det är med stor eller liten bokstav alla skall visas.

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Visa för alla skådespelare bara deras namn och ålder.

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Visa en lista innehållande filmtitel, regissör och antal skådespelare för alla filmer.


        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Visa för alla filmer filmens titel, samt genomsnittliga åldern för skådespelarna i filmen

        }

        private void button9_Click(object sender, EventArgs e)
        {
            //ta fram alla filmer som gjordes under 2000-talet och där regissören heter Martin
            //Scorsese.Visa bara Titel, release år och regissör.

        }

        private void button10_Click(object sender, EventArgs e)
        {
            // Visa alla skådespelare som är med i mer än en film. Visa också hur många filmer de är med i.

        }

        private void button11_Click(object sender, EventArgs e)
        {
            // visa alla filmer vars årtal är senare än det genomsnittliga årtalet för alla filmer.Sortera resultatet på årtalet i stigande ordning(ascending).
        }
    }
}
