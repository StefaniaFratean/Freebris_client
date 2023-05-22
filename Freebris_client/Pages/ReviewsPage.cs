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
    public partial class ReviewsPage : Form
    {
        string typeAcc;
        string bookTitle;
        int userId;
        FreebrisServiceReference.FreebrisWebServiceSoapClient service = new FreebrisServiceReference.FreebrisWebServiceSoapClient();
        public ReviewsPage(string bookTitle, int userId, string typeAcc)
        {
            this.typeAcc = typeAcc;
            this.bookTitle = bookTitle;
            this.userId = userId;
            InitializeComponent();
        }

        private void ReviewsPage_Load(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.AutoScroll = true;
            ReviewsDisplay();
        }
        private void ReviewsDisplay()
        {
            panel1.Controls.Clear();
            panel1.AutoScroll = true;

            DataTable reviews = service.GetAllReviewForBook(bookTitle);

            int y = 0; 
            for(int i=0;i<reviews.Rows.Count;i++)
            {
                Label user = new Label();
                string username = service.GetUsername(int.Parse(reviews.Rows[i]["userId"].ToString()));
                user.Text = username;
                user.Location = new Point(0, y+20);
                user.Visible = true;

                Label reviewText = new Label();
                reviewText.Text = reviews.Rows[i]["text"].ToString();
                reviewText.Location = new Point(150, y);
                reviewText.Visible = true;
                reviewText.Size = new Size(400, 100);
                reviewText.BackColor = Color.White;

                if (service.IsAdmin(username))
                {
                    Button delete = new Button();
                    delete.Name = reviews.Rows[i]["id"].ToString();
                    delete.Size = new Size(80, 40);
                    delete.Text = "Delete";
                    delete.Visible = true;
                    delete.Location = new Point(0, y + 60);
                    delete.Click += new EventHandler(Delete_Click);
                    panel1.Controls.Add(delete);
                }
                else if (int.Parse(reviews.Rows[i]["userId"].ToString()) == userId)
                {
                    Button delete = new Button();
                    delete.Name = reviews.Rows[i]["id"].ToString();
                    delete.Size = new Size(80, 40);
                    delete.Text = "delete";
                    delete.Visible = true;
                    delete.Location = new Point(600, y );
                    delete.Click += new EventHandler(Delete_Click);
                    panel1.Controls.Add(delete);
                }

                panel1.Controls.Add(user);
                panel1.Controls.Add(reviewText);

                y = y + 120;

            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {

            Button btn = (Button)sender;
            service.DeleteReviewById(int.Parse(btn.Name));
            ReviewsDisplay();
        }

        private void addReviewButton_Click(object sender, EventArgs e)
        {
            int bookId = service.GetBookId(bookTitle);
            service.CreateReview(bookId, userId, textBox1.Text);
            ReviewsDisplay();
        }
    }
}
