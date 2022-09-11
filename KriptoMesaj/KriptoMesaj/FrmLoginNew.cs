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
using CryptoMessageForm.Business;

namespace KriptoMesaj
{
    public partial class FrmLoginNew : Form
    {
        private object loginBusiness;

        public FrmLoginNew()
        {
            InitializeComponent();

        }


        private void girisekrani_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {



            try
            {
                var userId = txtUserId.Text;
                var pass = txtPassword.Text;
               // if (string.IsNullOrEmpty(userId)) 
                    

                /*FrmChat frmChat = new FrmChat();
                frmChat.Show();
                this.Hide();
                return;*/

                LoginBusiness loginBusiness = new LoginBusiness();

                var userInfo = loginBusiness.Login(userId, pass);

                if (userInfo != null)
                {
                    FrmMainNew frmMain = new FrmMainNew();
                    frmMain.UserInfo = userInfo;
                    frmMain.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı bilgilerinin doğru girildiğinden emin olunuz !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }







        }

        private void password_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void yeniKayit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            yeniKayıt kayıtOl = new yeniKayıt();
            kayıtOl.Show();


        }
    }
}

