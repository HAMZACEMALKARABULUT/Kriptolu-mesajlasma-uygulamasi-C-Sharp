namespace KriptoMesaj
{
    partial class FrmChat
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.backButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.searchBox1 = new KriptoMesaj.SearchBox();
            this.pnlConnections = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.typingBox1 = new KriptoMesaj.TypingBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.KriptoMesajHeader1 = new KriptoMesaj.ChatHeader();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Turquoise;
            this.panel1.Controls.Add(this.backButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(974, 24);
            this.panel1.TabIndex = 0;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.BackgroundImage = global::KriptoMesaj.Properties.Resources._1486348529_back_backwards_repeat_arrows_arrow_80455;
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.backButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.ForeColor = System.Drawing.Color.Transparent;
            this.backButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.backButton.Location = new System.Drawing.Point(950, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(19, 19);
            this.backButton.TabIndex = 14;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label1
            // 
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(939, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label1.Size = new System.Drawing.Size(35, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.searchBox1);
            this.panel2.Controls.Add(this.pnlConnections);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(3, 27);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(2, 0, 2, 5);
            this.panel2.Size = new System.Drawing.Size(206, 674);
            this.panel2.TabIndex = 1;
            // 
            // searchBox1
            // 
            this.searchBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.searchBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.searchBox1.FocusedColor = System.Drawing.Color.WhiteSmoke;
            this.searchBox1.Location = new System.Drawing.Point(2, 640);
            this.searchBox1.Margin = new System.Windows.Forms.Padding(4);
            this.searchBox1.Name = "searchBox1";
            this.searchBox1.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.searchBox1.Size = new System.Drawing.Size(202, 29);
            this.searchBox1.TabIndex = 2;
            this.searchBox1.TextColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.searchBox1.UnFocusedColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.searchBox1.Value = "Search...";
            this.searchBox1.OnSearchTextChanged += new KriptoMesaj.SearchBox.SearchTextChanged(this.OnSearchTextChanged);
            // 
            // pnlConnections
            // 
            this.pnlConnections.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlConnections.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlConnections.Location = new System.Drawing.Point(2, 42);
            this.pnlConnections.Name = "pnlConnections";
            this.pnlConnections.Padding = new System.Windows.Forms.Padding(0, 5, 0, 10);
            this.pnlConnections.Size = new System.Drawing.Size(202, 578);
            this.pnlConnections.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Turquoise;
            this.label3.Location = new System.Drawing.Point(2, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.label3.Size = new System.Drawing.Size(202, 42);
            this.label3.TabIndex = 0;
            this.label3.Text = "Bağlantılar";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.typingBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(209, 663);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.panel3.Size = new System.Drawing.Size(768, 38);
            this.panel3.TabIndex = 3;
            // 
            // typingBox1
            // 
            this.typingBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.typingBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.typingBox1.Location = new System.Drawing.Point(5, 9);
            this.typingBox1.Margin = new System.Windows.Forms.Padding(4);
            this.typingBox1.Name = "typingBox1";
            this.typingBox1.Size = new System.Drawing.Size(758, 24);
            this.typingBox1.TabIndex = 0;
            this.typingBox1.Value = "Type here...";
            this.typingBox1.OnHitEnter += new KriptoMesaj.TypingBox.HitEnter(this.typingBox1_OnHitEnter);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel4.BackgroundImage = global::KriptoMesaj.Properties.Resources.giris1;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(209, 69);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(768, 594);
            this.panel4.TabIndex = 4;
            // 
            // KriptoMesajHeader1
            // 
            this.KriptoMesajHeader1.BackColor = System.Drawing.Color.White;
            this.KriptoMesajHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.KriptoMesajHeader1.ForeColor = System.Drawing.Color.Silver;
            this.KriptoMesajHeader1.Location = new System.Drawing.Point(209, 27);
            this.KriptoMesajHeader1.Margin = new System.Windows.Forms.Padding(4);
            this.KriptoMesajHeader1.Name = "KriptoMesajHeader1";
            this.KriptoMesajHeader1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.KriptoMesajHeader1.Size = new System.Drawing.Size(768, 42);
            this.KriptoMesajHeader1.TabIndex = 2;
            this.KriptoMesajHeader1.UserImage = global::KriptoMesaj.Properties.Resources._2_32;
            this.KriptoMesajHeader1.UserStatusText = "";
            this.KriptoMesajHeader1.UserTitle = "";
            // 
            // FrmChat
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(980, 704);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.KriptoMesajHeader1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmChat";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmChat_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private ChatHeader KriptoMesajHeader1;
        private System.Windows.Forms.Panel panel3;
        private TypingBox typingBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlConnections;
        private SearchBox searchBox1;
        private System.Windows.Forms.Button backButton;
    }
}
