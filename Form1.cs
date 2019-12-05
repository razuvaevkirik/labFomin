using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

        private void AddSeries_Click(object sender, EventArgs e)
        {
            addDocument addDocument = new addDocument();
            this.Hide();
            addDocument.Show();
        }
    }
}
