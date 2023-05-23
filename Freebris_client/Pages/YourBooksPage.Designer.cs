
namespace Freebris_client.Pages
{
    partial class YourBooksPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YourBooksPage));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.points = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.iconbox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconbox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Here you can find your work of art!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(29, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(995, 728);
            this.panel1.TabIndex = 9;
            // 
            // points
            // 
            this.points.AutoSize = true;
            this.points.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.points.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.points.Location = new System.Drawing.Point(971, 21);
            this.points.Name = "points";
            this.points.Size = new System.Drawing.Size(53, 20);
            this.points.TabIndex = 13;
            this.points.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.label4.Location = new System.Drawing.Point(858, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "Your points:";
            // 
            // LogoutButton
            // 
            this.LogoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.LogoutButton.FlatAppearance.BorderSize = 0;
            this.LogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.LogoutButton.Location = new System.Drawing.Point(914, 846);
            this.LogoutButton.MaximumSize = new System.Drawing.Size(110, 44);
            this.LogoutButton.MinimumSize = new System.Drawing.Size(110, 44);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(110, 44);
            this.LogoutButton.TabIndex = 16;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = false;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // iconbox
            // 
            this.iconbox.InitialImage = ((System.Drawing.Image)(resources.GetObject("iconbox.InitialImage")));
            this.iconbox.Location = new System.Drawing.Point(765, 13);
            this.iconbox.Name = "iconbox";
            this.iconbox.Size = new System.Drawing.Size(75, 60);
            this.iconbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconbox.TabIndex = 17;
            this.iconbox.TabStop = false;
            // 
            // YourBooksPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.Controls.Add(this.iconbox);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.points);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "YourBooksPage";
            this.Size = new System.Drawing.Size(1049, 924);
            this.Load += new System.EventHandler(this.YourBooksPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label points;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.PictureBox iconbox;
    }
}
