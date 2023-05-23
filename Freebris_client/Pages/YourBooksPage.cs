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
    public partial class YourBooksPage : UserControl
    {

        string username;
        string typeAcc;
        FreebrisServiceReference.FreebrisWebServiceSoapClient service = new FreebrisServiceReference.FreebrisWebServiceSoapClient();
        public YourBooksPage(string username, string typeAcc)
        {
            this.username = username;
            this.typeAcc = typeAcc;
            InitializeComponent();
            int idIcon = service.GetIconForUser(username);
            iconbox.ImageLocation = service.GetIcon(idIcon);
        }
        private void RefreshPage()
        {
            this.Show();
            this.Controls.Clear();
            InitializeComponent();
            points.Text = service.GetPoints(username).ToString();
            DataTable books = service.GetAllBooks();
            PrintBooks(books);
        }
        private void YourBooksPage_Load(object sender, EventArgs e)
        {
            points.Text = service.GetPoints(username).ToString();
            DataTable books = service.GetBooksByAuthor(username);
            PrintBooks(books);
            points.Text = service.GetPoints(username).ToString();
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

                Button delete = new Button();
                delete.Name = books.Rows[i]["name"].ToString();
                delete.Size = new Size(80, 40);
                delete.Text = "Delete";
                delete.Visible = true;
                delete.Location = new Point(0, y + 20);
                delete.Click += new EventHandler(Delete_Click);

                Label path = new Label();
                path.Name = books.Rows[i]["name"].ToString() + "label";
                path.Text = author;
                path.Location = new Point(620, y);
                path.Visible = false;

                panel1.Controls.Add(book);
                panel1.Controls.Add(tb);
                panel1.Controls.Add(tb2);
                panel1.Controls.Add(delete);
                panel1.Controls.Add(path);

                y += 250;
            }
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete your book?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                Button btn = (Button)sender;    
                int id = service.GetBookId(btn.Name);
                service.DeleteBook(id);
                MessageBox.Show("Your book had been deleted");
                RefreshPage();

                DataTable books = service.GetBooksByAuthor(username);
                PrintBooks(books);
            }
        }

        // reviews: 
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
            int idIcon = service.GetIconForUser(username);
            iconbox.ImageLocation = service.GetIcon(idIcon);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
