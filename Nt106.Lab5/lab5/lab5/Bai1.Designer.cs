namespace lab5
{
    partial class Bai1
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
            EnableShow = new CheckBox();
            label5 = new Label();
            UsernameBox = new TextBox();
            label4 = new Label();
            SubjectBox = new TextBox();
            label3 = new Label();
            Password = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ReceiveBox = new TextBox();
            FromMailBox = new TextBox();
            MailBox = new RichTextBox();
            SendButton = new Button();
            SuspendLayout();
            // 
            // EnableShow
            // 
            EnableShow.AutoSize = true;
            EnableShow.Location = new Point(536, 61);
            EnableShow.Name = "EnableShow";
            EnableShow.Size = new Size(67, 24);
            EnableShow.TabIndex = 25;
            EnableShow.Text = "Show";
            EnableShow.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(147, 16);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 24;
            label5.Text = "Username";
            // 
            // UsernameBox
            // 
            UsernameBox.Location = new Point(239, 16);
            UsernameBox.Name = "UsernameBox";
            UsernameBox.Size = new Size(291, 27);
            UsernameBox.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(147, 209);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 22;
            label4.Text = "Subject";
            // 
            // SubjectBox
            // 
            SubjectBox.Location = new Point(239, 202);
            SubjectBox.Name = "SubjectBox";
            SubjectBox.Size = new Size(438, 27);
            SubjectBox.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(147, 58);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 20;
            label3.Text = "Password";
            // 
            // Password
            // 
            Password.Location = new Point(239, 58);
            Password.Name = "Password";
            Password.Size = new Size(291, 27);
            Password.TabIndex = 19;
            Password.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(147, 167);
            label2.Name = "label2";
            label2.Size = new Size(25, 20);
            label2.TabIndex = 18;
            label2.Text = "To";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(147, 124);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 17;
            label1.Text = "From";
            // 
            // ReceiveBox
            // 
            ReceiveBox.Location = new Point(239, 160);
            ReceiveBox.Name = "ReceiveBox";
            ReceiveBox.Size = new Size(210, 27);
            ReceiveBox.TabIndex = 16;
            // 
            // FromMailBox
            // 
            FromMailBox.Location = new Point(239, 121);
            FromMailBox.Name = "FromMailBox";
            FromMailBox.Size = new Size(210, 27);
            FromMailBox.TabIndex = 15;
            // 
            // MailBox
            // 
            MailBox.Location = new Point(147, 304);
            MailBox.Name = "MailBox";
            MailBox.Size = new Size(746, 281);
            MailBox.TabIndex = 14;
            MailBox.Text = "";
            // 
            // SendButton
            // 
            SendButton.BackColor = SystemColors.ActiveCaption;
            SendButton.Location = new Point(147, 602);
            SendButton.Name = "SendButton";
            SendButton.Size = new Size(111, 39);
            SendButton.TabIndex = 13;
            SendButton.Text = "SEND";
            SendButton.UseVisualStyleBackColor = false;
            SendButton.Click += SendButton_Click;
            // 
            // Bai1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1096, 653);
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
            Name = "Bai1";
            Text = "Bai1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox EnableShow;
        private Label label5;
        private TextBox UsernameBox;
        private Label label4;
        private TextBox SubjectBox;
        private Label label3;
        private TextBox Password;
        private Label label2;
        private Label label1;
        private TextBox ReceiveBox;
        private TextBox FromMailBox;
        private RichTextBox MailBox;
        private Button SendButton;
    }
}