namespace TrafficRacerGame
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btn1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblLambo = new System.Windows.Forms.Label();
            this.lblFerrari = new System.Windows.Forms.Label();
            this.lblMustang = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.radioYavas = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioHızlı = new System.Windows.Forms.RadioButton();
            this.radioOrta = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.btn1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn3)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 0;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.btn1.Image = ((System.Drawing.Image)(resources.GetObject("btn1.Image")));
            this.btn1.ImageActive = null;
            this.btn1.Location = new System.Drawing.Point(45, 140);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(68, 94);
            this.btn1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn1.TabIndex = 0;
            this.btn1.TabStop = false;
            this.btn1.Zoom = 10;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            this.btn1.MouseLeave += new System.EventHandler(this.bunifuImageButton1_MouseLeave);
            this.btn1.MouseHover += new System.EventHandler(this.bunifuImageButton1_MouseHover);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.btn2.Image = ((System.Drawing.Image)(resources.GetObject("btn2.Image")));
            this.btn2.ImageActive = null;
            this.btn2.Location = new System.Drawing.Point(156, 140);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(68, 94);
            this.btn2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn2.TabIndex = 1;
            this.btn2.TabStop = false;
            this.btn2.Zoom = 10;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            this.btn2.MouseLeave += new System.EventHandler(this.bunifuImageButton2_MouseLeave);
            this.btn2.MouseHover += new System.EventHandler(this.bunifuImageButton2_MouseHover);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.btn3.Image = ((System.Drawing.Image)(resources.GetObject("btn3.Image")));
            this.btn3.ImageActive = null;
            this.btn3.Location = new System.Drawing.Point(265, 140);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(68, 94);
            this.btn3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn3.TabIndex = 2;
            this.btn3.TabStop = false;
            this.btn3.Zoom = 10;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            this.btn3.MouseLeave += new System.EventHandler(this.bunifuImageButton3_MouseLeave);
            this.btn3.MouseHover += new System.EventHandler(this.bunifuImageButton3_MouseHover);
            // 
            // lblLambo
            // 
            this.lblLambo.AutoSize = true;
            this.lblLambo.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLambo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblLambo.Location = new System.Drawing.Point(116, 95);
            this.lblLambo.Name = "lblLambo";
            this.lblLambo.Size = new System.Drawing.Size(176, 30);
            this.lblLambo.TabIndex = 3;
            this.lblLambo.Text = "Lamborghini";
            this.lblLambo.Visible = false;
            // 
            // lblFerrari
            // 
            this.lblFerrari.AutoSize = true;
            this.lblFerrari.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFerrari.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblFerrari.Location = new System.Drawing.Point(40, 95);
            this.lblFerrari.Name = "lblFerrari";
            this.lblFerrari.Size = new System.Drawing.Size(104, 30);
            this.lblFerrari.TabIndex = 4;
            this.lblFerrari.Text = "Ferrari";
            this.lblFerrari.Visible = false;
            // 
            // lblMustang
            // 
            this.lblMustang.AutoSize = true;
            this.lblMustang.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMustang.ForeColor = System.Drawing.Color.Navy;
            this.lblMustang.Location = new System.Drawing.Point(250, 95);
            this.lblMustang.Name = "lblMustang";
            this.lblMustang.Size = new System.Drawing.Size(121, 30);
            this.lblMustang.TabIndex = 5;
            this.lblMustang.Text = "Mustang";
            this.lblMustang.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(37, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 45);
            this.label1.TabIndex = 6;
            this.label1.Text = "Bir araba seç";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Schoolbook", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(100, 569);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 64);
            this.button1.TabIndex = 7;
            this.button1.Text = "BAŞLA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(37, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 45);
            this.label2.TabIndex = 8;
            this.label2.Text = "Seviye";
            // 
            // radioYavas
            // 
            this.radioYavas.AutoSize = true;
            this.radioYavas.ForeColor = System.Drawing.Color.Purple;
            this.radioYavas.Location = new System.Drawing.Point(16, 4);
            this.radioYavas.Name = "radioYavas";
            this.radioYavas.Size = new System.Drawing.Size(144, 29);
            this.radioYavas.TabIndex = 9;
            this.radioYavas.TabStop = true;
            this.radioYavas.Text = "Yavaş Mod";
            this.radioYavas.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioHızlı);
            this.panel1.Controls.Add(this.radioOrta);
            this.panel1.Controls.Add(this.radioYavas);
            this.panel1.Location = new System.Drawing.Point(29, 348);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 139);
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // radioHızlı
            // 
            this.radioHızlı.AutoSize = true;
            this.radioHızlı.ForeColor = System.Drawing.Color.Purple;
            this.radioHızlı.Location = new System.Drawing.Point(16, 76);
            this.radioHızlı.Name = "radioHızlı";
            this.radioHızlı.Size = new System.Drawing.Size(133, 29);
            this.radioHızlı.TabIndex = 11;
            this.radioHızlı.TabStop = true;
            this.radioHızlı.Text = "Hızlı Mod";
            this.radioHızlı.UseVisualStyleBackColor = true;
            // 
            // radioOrta
            // 
            this.radioOrta.AutoSize = true;
            this.radioOrta.ForeColor = System.Drawing.Color.Purple;
            this.radioOrta.Location = new System.Drawing.Point(16, 41);
            this.radioOrta.Name = "radioOrta";
            this.radioOrta.Size = new System.Drawing.Size(132, 29);
            this.radioOrta.TabIndex = 10;
            this.radioOrta.TabStop = true;
            this.radioOrta.Text = "Orta Mod";
            this.radioOrta.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ClientSize = new System.Drawing.Size(386, 684);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMustang);
            this.Controls.Add(this.lblFerrari);
            this.Controls.Add(this.lblLambo);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuImageButton btn3;
        private Bunifu.Framework.UI.BunifuImageButton btn2;
        private Bunifu.Framework.UI.BunifuImageButton btn1;
        private System.Windows.Forms.Label lblMustang;
        private System.Windows.Forms.Label lblFerrari;
        private System.Windows.Forms.Label lblLambo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioHızlı;
        private System.Windows.Forms.RadioButton radioOrta;
        private System.Windows.Forms.RadioButton radioYavas;
        private System.Windows.Forms.Label label2;
    }
}

