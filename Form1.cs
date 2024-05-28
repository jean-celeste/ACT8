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

namespace ACT8
{
    public partial class Form1 : Form
    {
        private static readonly HttpClient client = new HttpClient();
        public Form1()
        {
            InitializeComponent();
        }

        private async void getBtn_Click(object sender, EventArgs e)
        {
            try
            {
                outputTxtBox.Clear();
                HttpResponseMessage response = await client.GetAsync("http://localhost/API/user_api.php");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                // Deserialize the JSON response to a list of User objects
                List<User> users = JsonConvert.DeserializeObject<List<User>>(responseBody);

                // Format the data into a readable string
                StringBuilder sb = new StringBuilder();
                foreach (var user in users)
                {
                    sb.AppendLine($"ID: {user.user_id}");
                    sb.AppendLine($"Name: {user.name}");
                    sb.AppendLine($"Username: {user.username}");
                    sb.AppendLine($"Password: {user.password}");
                    sb.AppendLine($"Email: {user.email}");
                    sb.AppendLine();
                }

                // Display the formatted string in the TextBox
                outputTxtBox.Text = sb.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private async void postBtn_Click(object sender, EventArgs e)
        {
            var userData = new { name = nameTxt.Text, username = usernameTxt.Text, password = passTxt.Text, email = emailTxt.Text };
            string json = JsonConvert.SerializeObject(userData);
            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                HttpResponseMessage response = await client.PostAsync("http://localhost/API/user_api.php", content);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                outputTxtBox.Text = responseBody;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
    public class User
    {
        public int user_id { get; set; }
        public string name { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }
    }
}
