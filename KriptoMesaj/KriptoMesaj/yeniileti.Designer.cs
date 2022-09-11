namespace KriptoMesaj
{
    partial class yeniileti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(yeniileti));
            this.baglantiListesi = new System.Windows.Forms.ListView();
            this.bagName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bagSurname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // baglantiListesi
            // 
            this.baglantiListesi.BackColor = System.Drawing.Color.Aquamarine;
            this.baglantiListesi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.baglantiListesi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.bagName,
            this.bagSurname});
            this.baglantiListesi.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baglantiListesi.ForeColor = System.Drawing.SystemColors.Info;
            this.baglantiListesi.FullRowSelect = true;
            this.baglantiListesi.HideSelection = false;
            this.baglantiListesi.Location = new System.Drawing.Point(0, -27);
            this.baglantiListesi.Name = "baglantiListesi";
            this.baglantiListesi.Size = new System.Drawing.Size(294, 549);
            this.baglantiListesi.TabIndex = 0;
            this.baglantiListesi.UseCompatibleStateImageBehavior = false;
            this.baglantiListesi.View = System.Windows.Forms.View.Details;
            // 
            // bagName
            // 
            this.bagName.Text = "ADI";
            this.bagName.Width = 290;
            // 
            // bagSurname
            // 
            this.bagSurname.Text = "SOYADI";
            this.bagSurname.Width = 218;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Transparent;
            this.button3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button3.Location = new System.Drawing.Point(677, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(22, 30);
            this.button3.TabIndex = 19;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // yeniileti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(711, 506);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.baglantiListesi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "yeniileti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "yeniileti";
            this.Load += new System.EventHandler(this.yeniileti_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView baglantiListesi;
        private System.Windows.Forms.ColumnHeader bagName;
        private System.Windows.Forms.ColumnHeader bagSurname;
        private System.Windows.Forms.Button button3;
    }
}