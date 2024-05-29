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

        private async void getUserBtn_Click(object sender, EventArgs e)
        {
            try
            {
                outputTxtBox.Clear();
                HttpResponseMessage response = await client.GetAsync("http://localhost/API/act8_API.php?type=user");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                // Deserialize the JSON response to a list of User objects
                List<User> users = JsonConvert.DeserializeObject<List<User>>(responseBody);

                // Format the data into a readable string
                StringBuilder sb = new StringBuilder();
                foreach (var user in users)
                {
                    sb.AppendLine($"User ID: {user.user_id}");
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

        private async void postUserBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameTxt.Text) ||
                string.IsNullOrEmpty(usernameTxt.Text) ||
                string.IsNullOrEmpty(emailTxt.Text) ||
                string.IsNullOrEmpty(passTxt.Text))
            {
                MessageBox.Show("Please fill in all fields before posting.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var userData = new { name = nameTxt.Text, username = usernameTxt.Text, password = passTxt.Text, email = emailTxt.Text };
            string json = JsonConvert.SerializeObject(userData);
            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                HttpResponseMessage response = await client.PostAsync("http://localhost/API/act8_API.php?type=user", content);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                outputTxtBox.Text = responseBody;

                string result = $"{responseBody}\r\n\r\n" +
                                $"Name: {userData.name}\r\n" +
                                $"Username: {userData.username}\r\n" +
                                $"Email: {userData.email}\r\n" +
                                $"Password: {userData.password}\r\n" +
                                "Message: User added successfully";

                outputTxtBox.Text = result;

                nameTxt.Clear();
                usernameTxt.Clear();
                passTxt.Clear();
                emailTxt.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            
        }

        private void bookBtn_Click(object sender, EventArgs e)
        {
            outputTxtBox.Clear();

            UserPanel.Visible = false;
            productPanel.Visible = true;
            getUserBtn.Visible = false;
            getBookBtn.Visible = true;


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void userBtn_Click(object sender, EventArgs e)
        {
            outputTxtBox.Clear();

            productPanel.Visible=false;
            UserPanel.Visible=true;
            getBookBtn.Visible=false;
            getUserBtn.Visible=true;
        }


        private async void getBookBtn_Click(object sender, EventArgs e)
        {
            try
            {
                outputTxtBox.Clear();
                HttpResponseMessage response = await client.GetAsync("http://localhost/API/act8_API.php?type=book");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                // Deserialize the JSON response to a list of Book objects
                List<Book> books = JsonConvert.DeserializeObject<List<Book>>(responseBody);

                // Format the data into a readable string
                StringBuilder sb = new StringBuilder();
                foreach (var book in books)
                {
                    sb.AppendLine($"Book ID: {book.book_id}");
                    sb.AppendLine($"Title: {book.title}");
                    sb.AppendLine($"Author: {book.author}");
                    sb.AppendLine($"Price: Php{book.price}");
                    sb.AppendLine($"Copies: {book.copies}");
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

        private async void postBookBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(titleTxt.Text) ||
                string.IsNullOrEmpty(authorTxt.Text) ||
                string.IsNullOrEmpty(priceTxt.Text) ||
                string.IsNullOrEmpty(copiesTxt.Text))
            {
                MessageBox.Show("Please fill in all fields before posting.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var bookData = new { title = titleTxt.Text, author = authorTxt.Text, price = priceTxt.Text, copies = copiesTxt.Text };
            string json = JsonConvert.SerializeObject(bookData);
            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                HttpResponseMessage response = await client.PostAsync("http://localhost/API/act8_API.php?type=book", content);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                outputTxtBox.Text = responseBody;

                string result = $"{responseBody}\r\n\r\n" +
                                $"Title: {bookData.title}\r\n" +
                                $"Author: {bookData.author}\r\n" +
                                $"Price: {bookData.price}\r\n" +
                                $"Copies: {bookData.copies}\r\n" +
                                "Message: Book added successfully";

                outputTxtBox.Text = result;

                titleTxt.Clear();
                authorTxt.Clear();
                priceTxt.Clear();
                copiesTxt.Clear();

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

    public class Book
    {
        public int book_id { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public string price { get; set; }
        public string copies { get; set; }
    }
}
