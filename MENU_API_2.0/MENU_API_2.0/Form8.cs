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
    public partial class Form8 : Form
    {
        HttpClient client = new HttpClient();
        public Form8()
        {
            InitializeComponent();
        }

        private async void Form8_Load(object sender, EventArgs e)
        {
            Form7 programa = new Form7();
            await GetTodoItemsg3();
        }
        private async Task GetTodoItemsg3()
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
                string[] row = { parsedPlaceName, parsedAddress,  parsedPhoneNumber, parsedSite };
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
