using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace AskMeProject
{
    public partial class DestekMail : Form
    {
        public DestekMail()
        {
            InitializeComponent();
        }
        MailMessage eposta = new MailMessage();
        void mailGonder()
        {
            eposta.From = new MailAddress("username@hotmail.com");
            eposta.To.Add(textBoxEposta.Text.ToString());
            eposta.Subject = textBoxKonu.Text.ToString();
            eposta.Body = textBoxİcerik.Text.ToString();
            SmtpClient smtp = new SmtpClient();
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("username@hotmail.com", "123456");
            smtp.Host = "smtp.live.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;

            smtp.Send(eposta);
            MessageBox.Show("Mail gönderildi!");
            
        }
        private void buttonGonder_Click(object sender, EventArgs e)
        {
            mailGonder();
        }
    }
}
