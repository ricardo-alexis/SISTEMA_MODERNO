using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;

namespace MENU_API_2._0
{
    public partial class Form6 : Form
    {
        HttpClient client = new HttpClient();
        public Form6()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void Form6_Load(object sender, EventArgs e)
        {
            Form6 programa = new Form6();
            await GetTodoItemsg1();
        }
        private async Task GetTodoItemsg1()
        {
            string response = await client.GetStringAsync("https://run.mocky.io/v3/1c3ae470-fca5-404e-922d-be70f41b7e67");
            Console.WriteLine(response);
            List<Todo> porhacer = JsonConvert.DeserializeObject<List<Todo>>(response);
            foreach (var item in porhacer)
            {
               
                string parsedPlaceName = item.PlaceName;
                
                string parsedCategory = Convert.ToString(item.Category);
                string parsedRating = Convert.ToString(item.Rating);
                
                string[] row = { parsedPlaceName,  parsedCategory, parsedRating };
                var lisViewItems = new ListViewItem(row);
                listView1.Items.Add(lisViewItems);
            }
        }
        class Todo
        {
            
            public string PlaceName { get; set; }
            public string Address { get; set; }
            public string Category { get; set; }
            public double Rating { get; set; }
           
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form4 menu = new Form4();
            menu.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
