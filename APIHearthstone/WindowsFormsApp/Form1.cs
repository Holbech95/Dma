using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;
using Models;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        private const string APIKey = "EPpYkCwt4AmshFZkgXjaOCyk7J0tp1mbp6djsnDGJz2hKgxxCw";
        private RestClient client = new RestClient("https://omgvamp-hearthstone-v1.p.mashape.com/");

        public Form1()
        {
            InitializeComponent();
            client.AddDefaultHeader("X-Mashape-Key", APIKey);

            GetAllCards();
            GetSetCards();
        }

        private void GetAllCards()
        {
            RestRequest request = new RestRequest("cards");
            IRestResponse<HearthStoneCards> response = client.Execute<HearthStoneCards>(request);
        }

        private void GetSetCards()
        {
            RestRequest request = new RestRequest("cards/sets/{set}");
            IRestResponse<HearthStoneCards> response = client.Execute<HearthStoneCards>(request);
            listCardSet.Items.AddRange(response.Data.Basic.ToArray());
        }

        private void listCardSet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
