using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;

namespace lab2
{
    public partial class addDocument : Form
    {
        MongoClient client;
        IMongoDatabase db;
        IMongoCollection<Search.Serial> collection;

        public addDocument()
        {
            InitializeComponent();
            ConnectToDB();
        }

        private void ConnectToDB()
        {
            client = new MongoClient("mongodb://localhost:27017");
            db = client.GetDatabase("seriesDB");
            collection = db.GetCollection<Search.Serial>("Series");
        }

        private void backToMenu_Click(object sender, EventArgs e)
        {
            Form1 mainForm = new Form1();
            this.Hide();
            mainForm.Show();
        }

        private void addSerial_Click(object sender, EventArgs e)
        {
            Search.Serial serialData = new Search.Serial
            {
                title = titleTextBox.Text,
                country = countryTextBox.Text,
                genre = genreTextBox.Text,
                ageLimits = ageTextBox.Text,
                startDate = Convert.ToDateTime(startDateTextBox.Text),
                releaseDate = Convert.ToDateTime(releaseDateTextBox.Text),
                rating = Convert.ToDouble(ratingTextBox.Text),
                trailer = trailerTextBox.Text,
                studio = studioTextBox.Text
            };

            collection.InsertOne(serialData);
            DialogResult res = MessageBox.Show(
                "Добавить еще один сериал?", 
                "Вопросик", 
                MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                titleTextBox.Clear();
                countryTextBox.Clear();
                genreTextBox.Clear();
                ageTextBox.Clear();
                startDateTextBox.Clear();
                releaseDateTextBox.Clear();
                ratingTextBox.Clear();
                trailerTextBox.Clear();
                studioTextBox.Clear();
            }
            else
            {
                Form1 mainForm = new Form1();
                this.Hide();
                mainForm.Show();
            }
        }
    }
}
