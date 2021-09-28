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
    public partial class Form3 : Form
    {
        HttpClient client = new HttpClient();
        public Form3()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void Form3_Load(object sender, EventArgs e)
        {
            Form3 programa = new Form3();
            await GetTodoItems();
        }
        private async Task GetTodoItems()
        {
            string response = await client.GetStringAsync("https://run.mocky.io/v3/1c3ae470-fca5-404e-922d-be70f41b7e67");
            Console.WriteLine(response);
            List<Todo> porhacer = JsonConvert.DeserializeObject<List<Todo>>(response);
            foreach (var item in porhacer)
            {
                
                string parsedPlaceName = item.PlaceName;
                string parsedAddress = item.Address;
                string parsedPhoneNumber = Convert.ToString(item.PhoneNumber);
                string parsedSite = Convert.ToString(item.Site);
                string[] row = {parsedPlaceName, parsedAddress,parsedPhoneNumber, parsedSite };
                var lisViewItems = new ListViewItem(row);
                listView1.Items.Add(lisViewItems);
            }
        }
        class Todo
        {
            
            public string PlaceName { get; set; }
            public string Address { get; set; }
            public string PhoneNumber { get; set; }
            public string Site { get; set; }

        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Dispose();
            
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
