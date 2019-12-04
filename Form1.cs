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
    public partial class Form1 : Form
    {
        MongoClient client;
        IMongoDatabase db;
        IMongoCollection<BsonDocument> collection;

        public Form1()
        {
            InitializeComponent();
            ConnectToDB();
        }

        private void ConnectToDB()
        {
            client = new MongoClient("mongodb://localhost:27017");
            db = client.GetDatabase("IU6");
            collection = db.GetCollection<BsonDocument>("IU612M");
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            Search searchForm = new Search();
            this.Hide();
            searchForm.Show();
        }
    }
}
