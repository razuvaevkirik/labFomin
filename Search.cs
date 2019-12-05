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
    public partial class Search : Form
    {
        MongoClient client;
        IMongoDatabase db;
        IMongoCollection<Serial> collection;

        public Search()
        {
            InitializeComponent();
            ConnectToDB();
        }

        private void ConnectToDB()
        {
            client = new MongoClient("mongodb://localhost:27017");
            db = client.GetDatabase("seriesDB");
            collection = db.GetCollection<Serial>("Series");
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Form1 mainForm = new Form1();
            this.Hide();
            mainForm.Show();
        }

        public class Serial
        {
            public ObjectId _id { get; set; }
            public string title { get; set; }
            public string country { get; set; }
            public string genre { get; set; }
            public string ageLimits { get; set; }
            public DateTime startDate { get; set; }
            public DateTime releaseDate { get; set; }
            public double rating { get; set; }
            public string trailer { get; set; }
            public string studio { get; set; }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            var filter = new BsonDocument("title", searchTextBox.Text.ToString());
            var serial = collection.Find(filter).ToList();

            foreach (var doc in serial)
            {
                nameLabel.Text = doc.title;
                countryLabel.Text = doc.country;
                genreLabel.Text = doc.genre;
                ageLabel.Text = doc.ageLimits;
                startDateLabel.Text = doc.startDate.ToShortDateString();
                releaseDateLabel.Text = doc.releaseDate.ToShortDateString();
                ratingLabel.Text = doc.rating.ToString();
                trailerLabel.Text = doc.trailer;
                studioLabel.Text = doc.studio;
            }
        }
    }
}
