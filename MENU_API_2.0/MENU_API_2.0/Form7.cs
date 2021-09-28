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
    public partial class Form7 : Form
    {
        HttpClient client = new HttpClient();
        public Form7()
        {
            InitializeComponent();
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

        private async void Form7_Load(object sender, EventArgs e)
        {
            Form7 programa = new Form7();
            await GetTodoItemsg2();
        }
        private async Task GetTodoItemsg2()
        {
            string response = await client.GetStringAsync("https://run.mocky.io/v3/1c3ae470-fca5-404e-922d-be70f41b7e67");
            Console.WriteLine(response);
            List<Todo> porhacer = JsonConvert.DeserializeObject<List<Todo>>(response);
            foreach (var item in porhacer)
            {
               
                string parsedPlaceName = item.PlaceName;
             
                string parsedCategory = Convert.ToString(item.Category);
                
                string parsedIsPetFriendly = Convert.ToString(item.IsPetFriendly);
                
                string[] row = { parsedPlaceName, parsedCategory, parsedIsPetFriendly };
                var lisViewItems = new ListViewItem(row);
                listView1.Items.Add(lisViewItems);
            }
        }
        class Todo
        {
           
            public string PlaceName { get; set; }
           
            public string Category { get; set; }
           
            public bool IsPetFriendly { get; set; }
            

        }
    }
}
