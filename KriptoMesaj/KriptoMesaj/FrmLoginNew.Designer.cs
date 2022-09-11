namespace KriptoMesaj
{
    partial class FrmLoginNew
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
            this.button3 = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.MaskedTextBox();
            this.LogInButton = new System.Windows.Forms.Button();
            this.yeniKayit = new System.Windows.Forms.LinkLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::KriptoMesaj.Properties.Resources.cross_wrong_close_delete_icon_191608;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Transparent;
            this.button3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button3.Location = new System.Drawing.Point(321, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(37, 31);
            this.button3.TabIndex = 5;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPassword.Location = new System.Drawing.Point(91, 179);
            this.txtPassword.MaxLength = 16;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(172, 27);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.password_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(88, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Kullanıcı Kimliği";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(88, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Parola";
            // 
            // txtUserId
            // 
            this.txtUserId.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtUserId.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUserId.Location = new System.Drawing.Point(91, 126);
            this.txtUserId.Mask = "000000000";
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.PasswordChar = '*';
            this.txtUserId.Size = new System.Drawing.Size(172, 23);
            this.txtUserId.TabIndex = 10;
            this.txtUserId.ValidatingType = typeof(int);
            // 
            // LogInButton
            // 
            this.LogInButton.BackColor = System.Drawing.Color.Transparent;
            this.LogInButton.BackgroundImage = global::KriptoMesaj.Properties.Resources.in_door_communication_enter_log_in_login_icon_191647;
            this.LogInButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogInButton.FlatAppearance.BorderSize = 0;
            this.LogInButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.LogInButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.LogInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogInButton.ForeColor = System.Drawing.Color.Transparent;
            this.LogInButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LogInButton.Location = new System.Drawing.Point(226, 225);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(37, 31);
            this.LogInButton.TabIndex = 11;
            this.LogInButton.UseVisualStyleBackColor = false;
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // yeniKayit
            // 
            this.yeniKayit.ActiveLinkColor = System.Drawing.Color.White;
            this.yeniKayit.AutoSize = true;
            this.yeniKayit.BackColor = System.Drawing.Color.Transparent;
            this.yeniKayit.Location = new System.Drawing.Point(210, 290);
            this.yeniKayit.Name = "yeniKayit";
            this.yeniKayit.Size = new System.Drawing.Size(132, 13);
            this.yeniKayit.TabIndex = 12;
            this.yeniKayit.TabStop = true;
            this.yeniKayit.Text = "Kullanıcı olmak istiyorum ...";
            this.yeniKayit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.yeniKayit_LinkClicked);
            // 
            // FrmLoginNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = global::KriptoMesaj.Properties.Resources.giris;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(373, 312);
            this.Controls.Add(this.yeniKayit);
            this.Controls.Add(this.LogInButton);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.button3);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLoginNew";
            this.Opacity = 0.85D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "girisekrani";
            this.TransparencyKey = System.Drawing.Color.Gainsboro;
            this.Load += new System.EventHandler(this.girisekrani_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtUserId;
        private System.Windows.Forms.Button LogInButton;
        private System.Windows.Forms.LinkLabel yeniKayit;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
