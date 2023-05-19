
namespace Freebris_client.Pages
{
    partial class SettingsPage
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
            this.ChangePassButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.DeleteAccountButton = new System.Windows.Forms.Button();
            this.tableLayoutPanelChangePass = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.tableLayoutPanelChangeEmail = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelChangePass.SuspendLayout();
            this.tableLayoutPanelChangeEmail.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChangePassButton
            // 
            this.ChangePassButton.Location = new System.Drawing.Point(225, 148);
            this.ChangePassButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChangePassButton.Name = "ChangePassButton";
            this.ChangePassButton.Size = new System.Drawing.Size(193, 75);
            this.ChangePassButton.TabIndex = 0;
            this.ChangePassButton.Text = "Change Password";
            this.ChangePassButton.UseVisualStyleBackColor = true;
            this.ChangePassButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(225, 286);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(193, 75);
            this.button2.TabIndex = 1;
            this.button2.Text = "Change email";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DeleteAccountButton
            // 
            this.DeleteAccountButton.Location = new System.Drawing.Point(225, 428);
            this.DeleteAccountButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteAccountButton.Name = "DeleteAccountButton";
            this.DeleteAccountButton.Size = new System.Drawing.Size(193, 75);
            this.DeleteAccountButton.TabIndex = 2;
            this.DeleteAccountButton.Text = "Delete account";
            this.DeleteAccountButton.UseVisualStyleBackColor = true;
            this.DeleteAccountButton.Click += new System.EventHandler(this.DeleteAccountButton_Click);
            // 
            // tableLayoutPanelChangePass
            // 
            this.tableLayoutPanelChangePass.ColumnCount = 2;
            this.tableLayoutPanelChangePass.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanelChangePass.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanelChangePass.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanelChangePass.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanelChangePass.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanelChangePass.Controls.Add(this.textBox1, 1, 0);
            this.tableLayoutPanelChangePass.Controls.Add(this.textBox2, 1, 1);
            this.tableLayoutPanelChangePass.Controls.Add(this.textBox3, 1, 2);
            this.tableLayoutPanelChangePass.Location = new System.Drawing.Point(601, 148);
            this.tableLayoutPanelChangePass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanelChangePass.Name = "tableLayoutPanelChangePass";
            this.tableLayoutPanelChangePass.RowCount = 3;
            this.tableLayoutPanelChangePass.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanelChangePass.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanelChangePass.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanelChangePass.Size = new System.Drawing.Size(661, 401);
            this.tableLayoutPanelChangePass.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Old password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "New password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirm new password";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(267, 2);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(313, 22);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(267, 134);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(313, 22);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(267, 266);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(313, 22);
            this.textBox3.TabIndex = 5;
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(766, 553);
            this.ConfirmButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(109, 39);
            this.ConfirmButton.TabIndex = 4;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // tableLayoutPanelChangeEmail
            // 
            this.tableLayoutPanelChangeEmail.ColumnCount = 2;
            this.tableLayoutPanelChangeEmail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanelChangeEmail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanelChangeEmail.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanelChangeEmail.Controls.Add(this.label5, 1, 0);
            this.tableLayoutPanelChangeEmail.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanelChangeEmail.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanelChangeEmail.Controls.Add(this.textBox4, 1, 1);
            this.tableLayoutPanelChangeEmail.Controls.Add(this.textBox5, 1, 2);
            this.tableLayoutPanelChangeEmail.Location = new System.Drawing.Point(76, 573);
            this.tableLayoutPanelChangeEmail.Name = "tableLayoutPanelChangeEmail";
            this.tableLayoutPanelChangeEmail.RowCount = 3;
            this.tableLayoutPanelChangeEmail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanelChangeEmail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanelChangeEmail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanelChangeEmail.Size = new System.Drawing.Size(661, 401);
            this.tableLayoutPanelChangeEmail.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Current email: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(267, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "your email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "New email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Confirm new email";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(267, 135);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(305, 22);
            this.textBox4.TabIndex = 4;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(267, 267);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(305, 22);
            this.textBox5.TabIndex = 5;
            // 
            // SettingsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanelChangeEmail);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.tableLayoutPanelChangePass);
            this.Controls.Add(this.DeleteAccountButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ChangePassButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SettingsPage";
            this.Size = new System.Drawing.Size(1423, 1038);
            this.tableLayoutPanelChangePass.ResumeLayout(false);
            this.tableLayoutPanelChangePass.PerformLayout();
            this.tableLayoutPanelChangeEmail.ResumeLayout(false);
            this.tableLayoutPanelChangeEmail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ChangePassButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button DeleteAccountButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelChangePass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelChangeEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
    }
}
