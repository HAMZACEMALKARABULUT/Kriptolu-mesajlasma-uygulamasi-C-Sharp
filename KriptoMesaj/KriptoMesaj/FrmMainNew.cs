using CryptoMessageForm.Business;
using CryptoMessageForm.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KriptoMesaj
{
    public partial class FrmMainNew : Form
    {
        public UserInfo UserInfo { get; set; }

        public FrmMainNew()
        {
            InitializeComponent();
        }


        private void FrmMainNew_Load(object sender, EventArgs e)
        {
            IstekDoldur();
            //comboBox1.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NtwrkSet kisiEkle = new NtwrkSet();
            kisiEkle.UserInfo = UserInfo;
            kisiEkle.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //yeniileti iletigonder = new yeniileti();
            //iletigonder.UserInfo = UserInfo;
            //iletigonder.Show();
            FrmChat frmChat = new FrmChat();
            frmChat.UserInfo = UserInfo;
            frmChat.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void friendRequests_Click(object sender, EventArgs e)
        {
            

            var seciliId = comboBox1.SelectedValue.ToString();
            if (string.IsNullOrEmpty(seciliId)) return;

            DialogResult durum;

            string onayMetni = "Bağlantı isteğini kabul etmek  istiyor musunuz?";
            durum = MessageBox.Show(onayMetni, "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            bool basari;
            if (durum == DialogResult.Yes)
            {
                ConnectionsBusiness connectionsBusiness = new ConnectionsBusiness();
                basari = connectionsBusiness.FriendRequestSave(seciliId, UserInfo.BagId.ToString(), true);
            }
            else if (durum == DialogResult.No)
            {
                ConnectionsBusiness connectionsBusiness = new ConnectionsBusiness();
                basari = connectionsBusiness.FriendRequestSave(seciliId, UserInfo.BagId.ToString(), false);
            }

            IstekDoldur();
        }

        public void IstekDoldur()
        {

            ConnectionsBusiness connectionBusiness = new ConnectionsBusiness();
            var liste = connectionBusiness.friendRequest(UserInfo.BagId.ToString());
            if (liste != null && liste.Count > 0)
            {
                comboBox1.DataSource = liste;
                comboBox1.DisplayMember = "LinkName";
                comboBox1.ValueMember = "LinkId";

            }
            else
            {
                comboBox1.Hide();
                friendRequests.Hide();
                baglantiIstekSayisi.Hide();
            }

        }
    }
}
