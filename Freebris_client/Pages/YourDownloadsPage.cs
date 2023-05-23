using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Freebris_client.Pages
{
    public partial class YourDownloadsPage : UserControl
    {

        string username;
        string typeAcc;
        FreebrisServiceReference.FreebrisWebServiceSoapClient service = new FreebrisServiceReference.FreebrisWebServiceSoapClient();
        public YourDownloadsPage(string username, string typeAcc)
        {
            this.username = username;
            this.typeAcc = typeAcc;
            InitializeComponent();
            points.Text = service.GetPoints(username).ToString();
            int idIcon = service.GetIconForUser(username);
            iconbox.ImageLocation = service.GetIcon(idIcon);
        }

        private void YourDownloadsPage_Load(object sender, EventArgs e)
        {
            int id = service.GetId(username);
            DataTable books = service.GetDownloadedBooksByUser(id);
            PrintBooks(books);
            int idIcon = service.GetIconForUser(username);
            iconbox.ImageLocation = service.GetIcon(idIcon);
        }

        private void PrintBooks(DataTable books)
        {
            panel1.Controls.Clear();
            panel1.AutoScroll = true;

            int y = 0;
            if (books.Rows.Count == 0)
            {
                Label message = new Label();
                message.Text = "No books to be shown!";
                message.Location = new Point(0, 100);
                message.Size = new Size(100, 30);
                message.Visible = true;

                panel1.Controls.Add(message);
                return;
            }
            for (int i = 0; i < books.Rows.Count; i++)
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

                Label tb2 = new Label();
                string author = service.GetUsername(int.Parse(books.Rows[i]["idAuthor"].ToString()));
                if (author == null)
                {
                    author = "unknown";
                }
                tb2.Text = author;
                tb2.Location = new Point(620, y);
                tb2.Visible = true;

                Button download = new Button();
                download.Name = books.Rows[i]["name"].ToString();
                download.Size = new Size(80, 40);
                download.Text = "Get this book";
                download.Visible = true;
                download.Location = new Point(0, y + 20);
                download.Click += new EventHandler(Download_Click);

                Label path = new Label();
                path.Name = books.Rows[i]["name"].ToString() + "label";
                path.Text = author;
                path.Location = new Point(620, y);
                path.Visible = false;

                panel1.Controls.Add(book);
                panel1.Controls.Add(tb);
                panel1.Controls.Add(tb2);
                panel1.Controls.Add(download);
                panel1.Controls.Add(path);

                y += 250;
            }
        }

        private void Download_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int idBook = service.GetBookId(btn.Name);

            string email = service.GetEmail(username);
            string location = service.GetPath(idBook);
            service.SendEmail(email, "Your new book", location);

            MessageBox.Show("The book was sended on email!");
        }

        private void Book_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int userId = service.GetId(username);
            ReviewsPage reviewsPage = new ReviewsPage(btn.Name, userId, typeAcc);
            reviewsPage.ShowDialog();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
