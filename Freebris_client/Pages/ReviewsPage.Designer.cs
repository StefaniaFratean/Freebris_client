
namespace Freebris_client.Pages
{
    partial class ReviewsPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.addReviewButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(61, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(991, 408);
            this.panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(61, 490);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(866, 139);
            this.textBox1.TabIndex = 1;
            // 
            // addReviewButton
            // 
            this.addReviewButton.Location = new System.Drawing.Point(945, 527);
            this.addReviewButton.Name = "addReviewButton";
            this.addReviewButton.Size = new System.Drawing.Size(107, 50);
            this.addReviewButton.TabIndex = 2;
            this.addReviewButton.Text = "Add review";
            this.addReviewButton.UseVisualStyleBackColor = true;
            this.addReviewButton.Click += new System.EventHandler(this.addReviewButton_Click);
            // 
            // ReviewsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 681);
            this.Controls.Add(this.addReviewButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Name = "ReviewsPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReviewsPage";
            this.Load += new System.EventHandler(this.ReviewsPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button addReviewButton;
    }
}