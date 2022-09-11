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
using CryptoMessageForm;
using CryptoMessageForm.Business;

namespace KriptoMesaj
{
    public partial class yeniileti : Form
    {
        public UserInfo UserInfo { get; set; }
        public string girenKisi;
        public yeniileti()
        {
            InitializeComponent();
        }



        public void Metod()
        {
            /* SqlCommand kommut1 = new SqlCommand(@"select bagid, bagName , bagSurname from baglantilar1 b 
                                                 inner join baglantiListesi bl on bl.bagid=b.baglantisi
                                                 where baglantiSahibi= " + girenKisi, baglanti);*/


        }
        private void yeniileti_Load(object sender, EventArgs e)
        {
            FillListView();
        }

        private void FillListView()
        {
            ConnectionsBusiness connectionsBusiness = new ConnectionsBusiness();
            var liste = connectionsBusiness.GetTheLinks(UserInfo.BagId.ToString());

            if (liste != null && liste.Count > 0)
            {
                foreach (var item in liste)
                {
                    baglantiListesi.Items.Add(new ListViewItem { Name = item.LinkId + "", Text = item.LinkName });
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            FrmMainNew frmMain = new FrmMainNew();
            frmMain.UserInfo = UserInfo;
            frmMain.Show();
            this.Hide();

        }
    }
}
