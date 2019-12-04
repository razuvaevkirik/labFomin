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
        IMongoCollection<BsonDocument> collection;

        public Search()
        {
            InitializeComponent();
            ConnectToDB();
        }

        private void ConnectToDB()
        {
            client = new MongoClient("mongodb://localhost:27017");
            db = client.GetDatabase("seriesDB");
            collection = db.GetCollection<BsonDocument>("Series");
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Form1 mainForm = new Form1();
            this.Hide();
            mainForm.Show();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            //Тут будет код поиска 
        }
    }
}
