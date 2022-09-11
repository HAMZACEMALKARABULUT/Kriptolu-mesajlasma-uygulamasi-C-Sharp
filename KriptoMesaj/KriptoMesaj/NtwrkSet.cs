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
using CryptoMessageForm.Entity;
using CryptoMessageForm.Business;



namespace KriptoMesaj
{
    public partial class NtwrkSet : Form
    {
        public UserInfo UserInfo { get; set; }

        //  public string girenKisi;

        /*  public string KullaniciIsmi(string ıd)
          {
              string donen = "";



              SqlCommand kisiyiBul = new SqlCommand("select bagName , bagSurname from baglantiListesi where bagid=@kisi", baglanti);

              kisiyiBul.Parameters.Add(new SqlParameter("@kisi", ıd));

              SqlDataReader kisiKontrol = kisiyiBul.ExecuteReader();

              while (kisiKontrol.Read())

              { donen = kisiKontrol["bagName"].ToString() + " " + kisiKontrol["bagSurname"].ToString(); }


              return donen;


          }
          public void Metod1()
          {*/
        /* var kommut1 = new SqlCommand(@"select bagid, bagName , bagSurname from baglantilar1 b 
                                             inner join baglantiListesi bl on bl.bagid=b.baglantisi
                                             where baglantiSahibi=@girenKisi", baglanti);

         kommut1.Parameters.AddWithValue("@girenKisi", girenKisi);

         var cevir = new SqlDataAdapter(kommut1);
         var dt = new DataTable();
         dt.Clear();
         cevir.Fill(dt);

         if (dt != null && dt.Rows.Count > 0)
         {
             comboBox1.DataSource = dt;
             comboBox1.ValueMember = "bagid";
             comboBox1.DisplayMember = "bagName";
         }
     }

     SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-PAM40PC\\SQLEXPRESS;Initial Catalog=mesajVeriTabani;Integrated Security=True");
*/


        public NtwrkSet()
        {
            InitializeComponent();

        }


        public void Form2_Load(object sender, EventArgs e)
        {
            string name = UserInfo.Name;
            string surname = UserInfo.Surname;
            LogInPerson.Text = name.TrimEnd() +" " + surname;

            // baglanti.Open();
            // Metod1();



            /* SqlCommand kommut1 = new SqlCommand("select count(*) from baglantilar1 where baglantiSahibi=" + girenKisi, baglanti);

             int kayitSayisi = Convert.ToInt32(kommut1.ExecuteScalar());



             String labelGiren = KullaniciIsmi(girenKisi);
             girenKisiLabel.Text = labelGiren;
             baglanti.Close();

             string arkadasId = "";*/


        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmMainNew acbakalım = new FrmMainNew();
            acbakalım.UserInfo = UserInfo;
            acbakalım.Show();
            this.Hide();

        }


        public void silKutusu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void silButon_Click(object sender, EventArgs e)
        {
            try
            {
                string baglantiSahibi = UserInfo.BagId.ToString();
                string baglantisi = comboBox1.SelectedValue.ToString();
                DialogResult durum1;
                if (baglantisi != null)
                {
                    string onayMetni = "Silme işlemini  onaylıyor musunuz?";
                    durum1 = MessageBox.Show(onayMetni, "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                    if (durum1 == DialogResult.Yes)
                    {
                        DeleteBusiness deleteBusiness = new DeleteBusiness();
                        deleteBusiness.DeleteTheLinks(baglantiSahibi, baglantisi);

                        

                    }
                }
            }

            catch
            {

                MessageBox.Show("Silinecek bağlantıyı seçiniz !");
            }


        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {



        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
        }

        private void ekleButon_Click(object sender, EventArgs e)
        { string davetEden = UserInfo.BagId.ToString();
            string davetEdilen = maskedTextBox1.Text.ToString();
            bool sonuc;
            ConnectionsBusiness connectionsBusiness = new ConnectionsBusiness();
            sonuc=connectionsBusiness.InsertTheLinks(davetEden, davetEdilen);
            if (sonuc == true)
            {
                MessageBox.Show("Bağlantı isteği gönderildi...", "Başarılı !");
            }

            else { MessageBox.Show("Bağlantı isteği gönderilemedi , bağlantı id'sini doğru girdiğinizden emin olunuz !", "Başarısız !", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            /*  try
              {
                  baglanti.Open();
                  string ekle = "insert into baglantilar1(baglantiSahibi , baglantisi) values (@girenKisi,@arkadasi)";

                  SqlCommand ekleKomut = new SqlCommand(ekle, baglanti);
                  ekleKomut.Parameters.AddWithValue("@girenKisi", girenKisi);
                  ekleKomut.Parameters.AddWithValue("@arkadasi", maskedTextBox1.Text);
                  ekleKomut.ExecuteNonQuery();
                  baglanti.Close();
                  MessageBox.Show("Baglanti eklendi...");
              }
              catch
              {
                  MessageBox.Show("Beklenmedik bir durumla karşılaşıldı");
              }

          }
          */

        }

        private void comboBox1_MouseDown(object sender, MouseEventArgs e)
        {


            

            ConnectionsBusiness connectionsBusiness = new ConnectionsBusiness();
            var links = connectionsBusiness.GetTheLinks(UserInfo.BagId.ToString());
            comboBox1.DataSource = links;
            comboBox1.DisplayMember = "LinkName";
            comboBox1.ValueMember = "LinkId";
        }
    }
}
