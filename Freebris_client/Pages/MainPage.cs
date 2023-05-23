using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Freebris_client.Pages
{
    public partial class MainPage : UserControl
    {
        string username;
        string typeAcc;
        FreebrisServiceReference.FreebrisWebServiceSoapClient service = new FreebrisServiceReference.FreebrisWebServiceSoapClient();
        public MainPage(string username, string typeAcc)
        {
            this.username = username;
            this.typeAcc = typeAcc;
            InitializeComponent();
            DataTable books = service.GetAllBooks();
            PrintBooks(books);
            points.Text = service.GetPoints(username).ToString();
            int idIcon = service.GetIconForUser(username);
            iconbox.ImageLocation = service.GetIcon(idIcon);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            // by author
            if(radioButton1.Checked)
            {
                DataTable books = service.GetBooksByAuthor(textBox1.Text);
                PrintBooks(books);
            }
            //by title
            else if (radioButton2.Checked)
            {
                DataTable books = service.GetBooksByTitle(textBox1.Text);
                PrintBooks(books);
            }
            // all
            else
            {
                DataTable books = service.GetAllBooks();
                PrintBooks(books);
            }
        }



        private void PrintBooks(DataTable books)
        {
            panel1.Controls.Clear();
            panel1.AutoScroll = true;
            int y=0;
            if(books.Rows.Count == 0)
            {
                Label message = new Label();
                message.Text = "No books to be shown!";
                message.Location = new Point(0, 100);
                message.Size = new Size(100, 30);
                message.Visible = true;

                panel1.Controls.Add(message);
                return;
            }
            for(int i=0; i<books.Rows.Count; i++)
            {
                Button book = new Button();
                book.Name = books.Rows[i]["name"].ToString();
                book.Size = new Size(200, 200);
                string file = service.GetIconBook(int.Parse(books.Rows[i]["idIconBook"].ToString()));
                book.BackgroundImage = Image.FromFile(file);
                book.BackgroundImageLayout = ImageLayout.Stretch;
                book.Visible = true;
                book.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                book.Location = new Point(120, y);
                book.Click += new EventHandler(Book_Click);

                Label tb = new Label();
                tb.Text = books.Rows[i]["name"].ToString();
                tb.Location = new Point(350, y);
                tb.Visible = true;
                tb.Size = new Size(200, 200);

                Label tb2 = new Label();
                string author = service.GetUsername(int.Parse(books.Rows[i]["idAuthor"].ToString()));
                if(author == null)
                {
                    author = "unknown";
                }
                tb2.Text = author;
                tb2.Location = new Point(590, y);
                tb2.Visible = true;

                Button download = new Button();
                download.Name = books.Rows[i]["name"].ToString();
                download.Size = new Size(80, 40);
                download.Text = "Get this book";
                download.Visible = true;
                download.Location = new Point(0, y);
                download.Click += new EventHandler(Download_Click);

                if (service.IsAdmin(username))
                {
                    Button delete = new Button();
                    delete.Name = books.Rows[i]["name"].ToString();
                    delete.Size = new Size(80, 40);
                    delete.Text = "Delete";
                    delete.Visible = true;
                    delete.Location = new Point(0, y + 120);
                    delete.Click += new EventHandler(Delete_Click);
                    panel1.Controls.Add(delete);
                }

                Label path = new Label();
                path.Name = books.Rows[i]["name"].ToString() + "label";
                path.Text = author;
                path.Location = new Point(620, y);
                path.Visible = false;

                Label points = new Label();
                points.Text = "Points required: 20";
                points.Location = new Point(0, y+60);
                points.Visible = true;

                panel1.Controls.Add(book);
                panel1.Controls.Add(tb);
                panel1.Controls.Add(tb2);
                panel1.Controls.Add(download); 
                panel1.Controls.Add(points); 
                panel1.Controls.Add(path); 

                 y += 250;
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete your book?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                Button btn = (Button)sender;
                int id = service.GetBookId(btn.Name);
                service.DeleteBook(id);
                MessageBox.Show("Your book had been deleted");

                DataTable books = service.GetBooksByAuthor(username);
                RefreshPage();
            }
        }
        private void Book_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int userId = service.GetId(username);
            ReviewsPage reviewsPage = new ReviewsPage(btn.Name, userId, typeAcc);
            reviewsPage.ShowDialog();
        }
        private void Download_Click(object sender, EventArgs e)
        {
            int idUser = service.GetId(username);
            Button btn = (Button)sender;
            int idBook = service.GetBookId(btn.Name);

            if (service.GetPoints(username) < 20)
            {
                MessageBox.Show("You don't have enough points to download this book! ");
                return;
            }
            string email = service.GetEmail(username);
            service.CreateDownload(idUser, idBook);
            string location = service.GetPath(idBook);
            service.SendEmail(email, "Your new book", location);
            service.AddPoints(idUser, -20);
            points.Text = service.GetPoints(username).ToString();

            MessageBox.Show("The book was sent on email!");
        }

        private void RefreshPage()
        {
            this.Show();
            this.Controls.Clear();
            InitializeComponent();
            points.Text = service.GetPoints(username).ToString();
            DataTable books = service.GetAllBooks();
            PrintBooks(books);
            int idIcon = service.GetIconForUser(username);
            iconbox.ImageLocation = service.GetIcon(idIcon);
        }
        private void LogoutButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        private void MainPage_Load(object sender, EventArgs e)
        {

        }

        private void points_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
