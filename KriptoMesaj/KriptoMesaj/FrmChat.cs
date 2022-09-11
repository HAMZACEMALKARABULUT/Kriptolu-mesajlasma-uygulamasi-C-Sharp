using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Shaping;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Reflection;
using CryptoMessageForm.Business;
using CryptoMessageForm.Entity;

namespace KriptoMesaj
{
    public partial class FrmChat : Form
    {
        public UserInfo UserInfo { get; set; }
        public UserInfo SelectedUserInfo { get; set; }

        private readonly ConnectionsBusiness _connectionsBusiness;
        public FrmChat()
        {
            InitializeComponent();
            _connectionsBusiness = new ConnectionsBusiness();
        }

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void OnSearchTextChanged(object sender, EventArgs e)
        {
            var searchBox = ((SearchBox)sender);

        }


        private void typingBox1_OnTypingTextChanged(string newVal)
        {
            // When you type something this fires... From 'typingBox11.OnTypingTextChanged'
            //'NewVal' is the new value... also can be gotten from 'typingBox1.Value'

        }

        private void typingBox1_OnHitEnter(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(typingBox1.Value))
            {
                if (SelectedUserInfo != null) { 
                var message = typingBox1.Value;
                _connectionsBusiness.SaveMessage(UserInfo.BagId, SelectedUserInfo.BagId, message);

                MeBubble bubble = new MeBubble();
                bubble.Dock = DockStyle.Bottom;//Dock to bottom  so that the bubbles can align themselves in a horizontal grid. You dont have to worry about responsiveness when window resizes.
                bubble.SendToBack();//Send back so that it will be lowest control... Use bubble.BringToFront() if u r docking up.

                bubble.Body = message;

                panel4.Controls.Add(bubble);

                typingBox1.Value = "";}

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void label2_Click(object sender, EventArgs e)
        {
            FrmMainNew frmMainNew =new  FrmMainNew();
            UserInfo.BagId= frmMainNew.UserInfo.BagId;
            this.Close();
            frmMainNew.Show();
            

            
        }

        private void OnUserClick(object sender, EventArgs e)
        {


            panel4.Controls.Clear();

            var ClickedUser = ((Users)sender);
            panel4.Refresh();

            string name = ClickedUser.Username;
            string statusText = ClickedUser.StatusMessage;
            Image profileImage = ClickedUser.UserImage;

            SelectedUserInfo = new UserInfo();
            SelectedUserInfo.BagId = Convert.ToInt32(ClickedUser.Name);
            SelectedUserInfo.Name = ClickedUser.Username;

            var sendedMessages = new List<int>();
            var conversationList = _connectionsBusiness.GetConversation(UserInfo.BagId, SelectedUserInfo.BagId);
            if (conversationList != null)
            {
                foreach (var conv in conversationList)
                {
                    if (conv.GonderenBagId == UserInfo.BagId)
                    {
                        AddMeBubble(conv);
                    }
                    else
                    {
                        AddYouBubble(conv);
                        sendedMessages.Add(conv.Id);
                    }
                }
            }

            _connectionsBusiness.SetOkundu(sendedMessages);

            this.KriptoMesajHeader1.UserTitle = name;
            this.KriptoMesajHeader1.UserStatusText = statusText;
            this.KriptoMesajHeader1.UserImage = profileImage;

            Timer timer = new Timer();
            timer.Interval = 1000; // 1 sn
            timer.Tick += new EventHandler(MyTimer_Tick);
            timer.Start();
        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            var conversationList = _connectionsBusiness.GetSendedNewMessages(UserInfo.BagId, SelectedUserInfo.BagId);
            if (conversationList != null)
            {
                var sendedMessages = new List<int>();
                foreach (var conv in conversationList)
                {
                    AddYouBubble(conv);
                    sendedMessages.Add(conv.Id);
                }

                _connectionsBusiness.SetOkundu(sendedMessages);
            }
        }

        private void AddUser(string userName, string Name)
        {

            var connUsers = new Users();
            connUsers.Name = userName;
            connUsers.Username = Name;
            
            connUsers.ProfileImageCursor = Cursors.Hand;
            connUsers.UserImage = Properties.Resources._4_32;
            connUsers.UserStatus = Status.Online;

            connUsers.BackColor = Color.Transparent;
            connUsers.Cursor = Cursors.Hand;
            connUsers.Dock = DockStyle.Top;
            connUsers.Location = new Point(0, pnlLastConnectionLocation);
            connUsers.Margin = new Padding(0);
            connUsers.Size = new Size(202, 49);

            connUsers.OnClick += this.OnUserClick;

            pnlConnections.Controls.Add(connUsers);

            pnlLastConnectionLocation += 50;
        }

        private void AddMeBubble(Conversation conversation)
        {
            var meBubble = new MeBubble();
            meBubble.AutoSize = true;
            meBubble.BackColor = System.Drawing.Color.Transparent;
            meBubble.Body = conversation.Message;
            meBubble.Dock = System.Windows.Forms.DockStyle.Bottom;
            meBubble.KriptoMesajImageCursor = System.Windows.Forms.Cursors.Default;
            meBubble.KriptoMesajTextCursor = System.Windows.Forms.Cursors.IBeam;
            meBubble.Location = new System.Drawing.Point(0, 338);
            meBubble.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            meBubble.MinimumSize = new System.Drawing.Size(0, 128);
            meBubble.MsgColor = System.Drawing.Color.DodgerBlue;
            meBubble.MsgTextColor = System.Drawing.SystemColors.ControlLightLight;
            meBubble.Name = "meBubble2";
            meBubble.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            meBubble.Size = new System.Drawing.Size(768, 128);
            meBubble.Status = KriptoMesaj.MessageStatus.Sent;
            meBubble.StatusImage = null;
            meBubble.TabIndex = panel4.Controls.Count;
            meBubble.Time = conversation.GonderimTarihi.ToString("HH:mm");
            meBubble.TimeColor = System.Drawing.Color.White;
            meBubble.UserImage = null;

            panel4.Controls.Add(meBubble);

        }

        private void AddYouBubble(Conversation conversation)
        {
            var youBubble = new YouBubble();
            youBubble.BackColor = System.Drawing.Color.Transparent;
            youBubble.Body = conversation.Message;
            youBubble.Dock = System.Windows.Forms.DockStyle.Bottom;
            youBubble.KriptoMesajImageCursor = System.Windows.Forms.Cursors.Default;
            youBubble.KriptoMesajTextCursor = System.Windows.Forms.Cursors.IBeam;
            youBubble.Location = new System.Drawing.Point(0, 466);
            youBubble.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            youBubble.MinimumSize = new System.Drawing.Size(0, 128);
            youBubble.MsgColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            youBubble.MsgTextColor = System.Drawing.SystemColors.ControlDarkDark;
            youBubble.Name = "youBubble1";
            youBubble.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            youBubble.Size = new System.Drawing.Size(768, 128);
            youBubble.Status = KriptoMesaj.MessageStatus.Sent;
            youBubble.StatusImage = null;
            youBubble.TabIndex = panel4.Controls.Count;
            youBubble.Time = conversation.GonderimTarihi.ToString("HH:mm");
            youBubble.TimeColor = System.Drawing.Color.White;
            youBubble.UserImage = global::KriptoMesaj.Properties.Resources._2_32;
            
            panel4.Controls.Add(youBubble);

        }

        int pnlLastConnectionLocation { get; set; }

        private void FrmChat_Load(object sender, EventArgs e)
        {
            pnlLastConnectionLocation = 5;

            ConnectionsBusiness connectionsBusiness = new ConnectionsBusiness();
            var liste = connectionsBusiness.GetTheLinks(UserInfo.BagId.ToString());
            if (liste != null && liste.Count > 0)
            {
                foreach (var item in liste)
                {
                    AddUser(item.LinkId + "", item.LinkName);

                }
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            FrmMainNew frmMainNew = new FrmMainNew();
            frmMainNew.UserInfo = UserInfo;
            this.Close();
            frmMainNew.Show();
        }
    

        }
    }
