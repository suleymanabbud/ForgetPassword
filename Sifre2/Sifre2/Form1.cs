using System;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace Sifre2
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        
        public Form1()
        {
            InitializeComponent();
        }

        public string Code;
        private void button1_Click(object sender, EventArgs e)
        {
            
            
        
            Code = rnd.Next(999999).ToString(); ;
            MailMessage mail = new MailMessage();
            SmtpClient smt = new SmtpClient();
            smt.Credentials = new System.Net.NetworkCredential("dasrfaws@hotmail.com", "12341234aa");
            smt.Port = 587;
            smt.Host = "smtp-mail.outlook.com";
            smt.EnableSsl = true;
            mail.To.Add(textBox1.Text);
            mail.From = new MailAddress("dasrfaws@hotmail.com");


            string konu = ("Doğrulama");
            mail.Subject = konu;
            const string p = "Şifreniz: ";
            mail.Body = p + Code.ToString();

            smt.Send(mail);
            MessageBox.Show("Doğrulama Kodu Gönderildi.");
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (textBox2.Text == Code)
            {
                MessageBox.Show("İşlem Başarlı");
            }
            else
            {
                MessageBox.Show("İşlem Hatalı");
            }
        }

        
    }
}