namespace KriptoMesaj
{
    partial class NtwrkSet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NtwrkSet));
            this.label1 = new System.Windows.Forms.Label();
            this.silButon = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ekleButon = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.LogInPerson = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(75, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Silinecek bağlantınızı seçiniz , ardından siliniz...";
            // 
            // silButon
            // 
            this.silButon.BackColor = System.Drawing.Color.Transparent;
            this.silButon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.silButon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.silButon.FlatAppearance.BorderSize = 0;
            this.silButon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.silButon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.silButon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.silButon.Font = new System.Drawing.Font("Agency FB", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.silButon.ForeColor = System.Drawing.Color.Transparent;
            this.silButon.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.silButon.Location = new System.Drawing.Point(78, 72);
            this.silButon.Name = "silButon";
            this.silButon.Size = new System.Drawing.Size(295, 48);
            this.silButon.TabIndex = 14;
            this.silButon.Text = "SİL";
            this.silButon.UseVisualStyleBackColor = false;
            this.silButon.Click += new System.EventHandler(this.silButon_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedTextBox1.Location = new System.Drawing.Point(517, 20);
            this.maskedTextBox1.Mask = "000000000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(192, 28);
            this.maskedTextBox1.TabIndex = 15;
            this.maskedTextBox1.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(456, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(345, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Eklenecek bağlantınızın 9 haneli kimlik numarasını giriniz...";
            // 
            // ekleButon
            // 
            this.ekleButon.BackColor = System.Drawing.Color.Transparent;
            this.ekleButon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ekleButon.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.ekleButon.FlatAppearance.BorderSize = 0;
            this.ekleButon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ekleButon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ekleButon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ekleButon.Font = new System.Drawing.Font("Agency FB", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ekleButon.ForeColor = System.Drawing.Color.Transparent;
            this.ekleButon.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ekleButon.Location = new System.Drawing.Point(517, 72);
            this.ekleButon.Name = "ekleButon";
            this.ekleButon.Size = new System.Drawing.Size(192, 48);
            this.ekleButon.TabIndex = 17;
            this.ekleButon.Text = "EKLE";
            this.ekleButon.UseVisualStyleBackColor = false;
            this.ekleButon.Click += new System.EventHandler(this.ekleButon_Click);
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
            this.button3.Location = new System.Drawing.Point(764, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(22, 30);
            this.button3.TabIndex = 18;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // LogInPerson
            // 
            this.LogInPerson.AutoSize = true;
            this.LogInPerson.BackColor = System.Drawing.Color.Transparent;
            this.LogInPerson.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LogInPerson.ForeColor = System.Drawing.Color.Snow;
            this.LogInPerson.Location = new System.Drawing.Point(12, 219);
            this.LogInPerson.Name = "LogInPerson";
            this.LogInPerson.Size = new System.Drawing.Size(0, 25);
            this.LogInPerson.TabIndex = 19;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(78, 18);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(295, 30);
            this.comboBox1.TabIndex = 20;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            this.comboBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.comboBox1_MouseDown);
            // 
            // NtwrkSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(810, 255);
            this.ControlBox = false;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.LogInPerson);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ekleButon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.silButon);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NtwrkSet";
            this.Opacity = 0.85D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button silButon;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ekleButon;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label LogInPerson;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}