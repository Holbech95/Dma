using System;
using System.Collections;
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

            List<string> set = new List<string>();
            set.Add("Basic");
            set.Add("Classic");
            set.Add("Naxxramas");
            set.Add("GoblinsVsGnomes");
            set.Add("BlackrockMountain");

            listCardSet.Items.AddRange(set.ToArray());
        }

        private void GetAllCards()
        {
            RestRequest request = new RestRequest("cards");
            IRestResponse<HearthStoneCards> response = client.Execute<HearthStoneCards>(request);
        }

        private void GetSetCards(string set)
        {
            RestRequest request = new RestRequest("cards/sets/{set}");
            request.AddUrlSegment("set",set);
            IRestResponse<List<HearthStoneCard>> response = client.Execute<List<HearthStoneCard>>(request);
            listCards.Items.AddRange(response.Data.ToArray());
        }

        private void listCardSet_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetSetCards(listCardSet.SelectedItem as string);
        }
    }
}
