using System.Net.Mail;
using System.Net;
using System.Text;
using System.ComponentModel;

namespace lab5
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }
        NetworkCredential login;
        SmtpClient smtp;
        MailMessage msg;


        private void SendButton_Click(object sender, EventArgs e)
        {
            login = new NetworkCredential(FromMailBox.Text, Password.Text);
            smtp = new SmtpClient("smtp.gmail.com");
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.Credentials = login;
            msg = new MailMessage { From = new MailAddress(FromMailBox.Text, UsernameBox.Text) };
            msg.To.Add(new MailAddress(ReceiveBox.Text));
            msg.Subject = SubjectBox.Text;
            msg.Body = MailBox.Text;
            msg.BodyEncoding = Encoding.UTF8;
            msg.IsBodyHtml = true;
            msg.Priority = MailPriority.Normal;
            msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
            smtp.SendCompleted += new SendCompletedEventHandler(SendCompletedCallback);
            smtp.SendAsync(msg, "Sending");


        }

        private static void SendCompletedCallback(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show(string.Format("{0} send canceled", e.UserState), "Message");
            }
            if (e.Error != null)
            {
                MessageBox.Show(string.Format("{0} {1}", e.UserState, e.Error), "Message");
            }
            else
                MessageBox.Show("Successful");
        }

        private void EnableShow_CheckedChanged(object sender, EventArgs e)
        {
            if (EnableShow.Checked == true)
            {
                Password.UseSystemPasswordChar = false;
            }
            else
            {
                Password.UseSystemPasswordChar = true;
            }
        }
    }
}