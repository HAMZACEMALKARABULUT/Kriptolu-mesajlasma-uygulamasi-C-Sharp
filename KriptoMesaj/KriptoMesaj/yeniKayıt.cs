using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Net;



namespace KriptoMesaj
{
    public partial class yeniKayıt : Form
    {

        public static int IdVer()
        {
            Random rastgele = new Random();
            Int32 id = rastgele.Next(100000000, 999999999);
            return id;
        }


        public yeniKayıt()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-PAM40PC\SQLEXPRESS; Initial Catalog=mesajVeriTabani; Integrated Security=True");


        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {

                MessageBox.Show("Lütfen bilgilerinizi eksiksiz giriniz !");



            }

            else
            {
                int kimlik = IdVer();
                baglanti.Open();
                string kayit = "insert into baglantiListesi(bagName,bagSurname,bagMail,bagPassword,bagid) values (@isim,@soyisim,@mail,@sifre,@id)";

                SqlCommand komut = new SqlCommand(kayit, baglanti);
                komut.Parameters.AddWithValue("@isim", textBox1.Text);
                komut.Parameters.AddWithValue("@soyisim", textBox2.Text);
                komut.Parameters.AddWithValue("@mail", textBox3.Text);
                komut.Parameters.AddWithValue("@sifre", textBox4.Text);
                komut.Parameters.AddWithValue("@id", kimlik);
                komut.ExecuteNonQuery();
                baglanti.Close();

                try
                {

                    SmtpClient sc = new SmtpClient();
                    sc.Port = 587;
                    sc.Host = "smtp.gmail.com";
                    sc.EnableSsl = true;

                    sc.Credentials = new NetworkCredential("blablabla@gmail.com", "blablabla");

                    MailMessage mail = new MailMessage();

                    mail.From = new MailAddress("blablabla@gmail.com", "Şifreli İleti");

                    mail.To.Add(textBox3.Text);


                    mail.Subject = "Hesap Onayı"; mail.IsBodyHtml = true; mail.Body = "Sayın " + textBox1.Text + " " + textBox2.Text + " Hoşgeldiniz !!! Şifreli ileti uygulamasına girmek için kullanacağınız  Kullanıcı kimlik numaranız : " + kimlik;



                    sc.Send(mail);


                    MessageBox.Show("Mail adresinize, giriş yapmanız için gerekli olan kullanıcı kimlik numaranız gönderildi.");
                }


                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLoginNew girBakalim = new FrmLoginNew();
            girBakalim.Show();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                  && !char.IsSeparator(e.KeyChar);
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                  && !char.IsSeparator(e.KeyChar);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void yeniKayıt_Load(object sender, EventArgs e)
        {

        }
    }
}



