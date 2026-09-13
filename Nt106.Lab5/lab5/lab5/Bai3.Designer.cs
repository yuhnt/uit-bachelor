namespace lab5
{
    partial class Bai3
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SendButton = new Button();
            MailBox = new RichTextBox();
            FromMailBox = new TextBox();
            ReceiveBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Password = new TextBox();
            label3 = new Label();
            SubjectBox = new TextBox();
            label4 = new Label();
            label5 = new Label();
            UsernameBox = new TextBox();
            EnableShow = new CheckBox();
            SuspendLayout();
            // 
            // SendButton
            // 
            SendButton.Location = new Point(903, 556);
            SendButton.Name = "SendButton";
            SendButton.Size = new Size(94, 29);
            SendButton.TabIndex = 0;
            SendButton.Text = "SEND";
            SendButton.UseVisualStyleBackColor = true;
            SendButton.Click += SendButton_Click;
            // 
            // MailBox
            // 
            MailBox.Location = new Point(89, 304);
            MailBox.Name = "MailBox";
            MailBox.Size = new Size(746, 281);
            MailBox.TabIndex = 1;
            MailBox.Text = "";
            // 
            // FromMailBox
            // 
            FromMailBox.Location = new Point(181, 168);
            FromMailBox.Name = "FromMailBox";
            FromMailBox.Size = new Size(210, 27);
            FromMailBox.TabIndex = 2;
            // 
            // ReceiveBox
            // 
            ReceiveBox.Location = new Point(181, 207);
            ReceiveBox.Name = "ReceiveBox";
            ReceiveBox.Size = new Size(210, 27);
            ReceiveBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 171);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 4;
            label1.Text = "From";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(89, 214);
            label2.Name = "label2";
            label2.Size = new Size(25, 20);
            label2.TabIndex = 5;
            label2.Text = "To";
            // 
            // Password
            // 
            Password.Location = new Point(181, 105);
            Password.Name = "Password";
            Password.Size = new Size(291, 27);
            Password.TabIndex = 6;
            Password.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(89, 105);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 7;
            label3.Text = "Password";
            // 
            // SubjectBox
            // 
            SubjectBox.Location = new Point(181, 249);
            SubjectBox.Name = "SubjectBox";
            SubjectBox.Size = new Size(438, 27);
            SubjectBox.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(89, 256);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 9;
            label4.Text = "Subject";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(89, 63);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 11;
            label5.Text = "Username";
            // 
            // UsernameBox
            // 
            UsernameBox.Location = new Point(181, 63);
            UsernameBox.Name = "UsernameBox";
            UsernameBox.Size = new Size(291, 27);
            UsernameBox.TabIndex = 10;
            // 
            // EnableShow
            // 
            EnableShow.AutoSize = true;
            EnableShow.Location = new Point(478, 108);
            EnableShow.Name = "EnableShow";
            EnableShow.Size = new Size(67, 24);
            EnableShow.TabIndex = 12;
            EnableShow.Text = "Show";
            EnableShow.UseVisualStyleBackColor = true;
            EnableShow.CheckedChanged += EnableShow_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1009, 615);
            Controls.Add(EnableShow);
            Controls.Add(label5);
            Controls.Add(UsernameBox);
            Controls.Add(label4);
            Controls.Add(SubjectBox);
            Controls.Add(label3);
            Controls.Add(Password);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ReceiveBox);
            Controls.Add(FromMailBox);
            Controls.Add(MailBox);
            Controls.Add(SendButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SendButton;
        private RichTextBox MailBox;
        private TextBox FromMailBox;
        private TextBox ReceiveBox;
        private Label label1;
        private Label label2;
        private TextBox Password;
        private Label label3;
        private TextBox SubjectBox;
        private Label label4;
        private Label label5;
        private TextBox UsernameBox;
        private CheckBox EnableShow;
    }
}