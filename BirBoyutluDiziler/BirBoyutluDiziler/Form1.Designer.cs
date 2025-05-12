namespace BirBoyutluDiziler
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtAdSoyad = new TextBox();
            txtEnYuksek = new TextBox();
            txtDersNotu = new TextBox();
            txtEnDusuk = new TextBox();
            txtOrtalama = new TextBox();
            lbListe = new ListBox();
            label1 = new Label();
            label2 = new Label();
            btnEkle = new Button();
            btndusuk = new Button();
            btnOrtalama = new Button();
            btnListele = new Button();
            btnEnYüksek = new Button();
            SuspendLayout();
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(227, 90);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(200, 39);
            txtAdSoyad.TabIndex = 0;
            txtAdSoyad.TextChanged += textBox1_TextChanged;
            // 
            // txtEnYuksek
            // 
            txtEnYuksek.Location = new Point(418, 570);
            txtEnYuksek.Name = "txtEnYuksek";
            txtEnYuksek.Size = new Size(200, 39);
            txtEnYuksek.TabIndex = 1;
            // 
            // txtDersNotu
            // 
            txtDersNotu.Location = new Point(227, 186);
            txtDersNotu.Name = "txtDersNotu";
            txtDersNotu.Size = new Size(200, 39);
            txtDersNotu.TabIndex = 2;
            // 
            // txtEnDusuk
            // 
            txtEnDusuk.Location = new Point(418, 486);
            txtEnDusuk.Name = "txtEnDusuk";
            txtEnDusuk.Size = new Size(200, 39);
            txtEnDusuk.TabIndex = 3;
            // 
            // txtOrtalama
            // 
            txtOrtalama.Location = new Point(418, 644);
            txtOrtalama.Name = "txtOrtalama";
            txtOrtalama.Size = new Size(200, 39);
            txtOrtalama.TabIndex = 4;
            // 
            // lbListe
            // 
            lbListe.FormattingEnabled = true;
            lbListe.Location = new Point(983, 208);
            lbListe.Name = "lbListe";
            lbListe.Size = new Size(240, 356);
            lbListe.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(67, 97);
            label1.Name = "label1";
            label1.Size = new Size(133, 32);
            label1.TabIndex = 6;
            label1.Text = "Ad Soyad:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(67, 186);
            label2.Name = "label2";
            label2.Size = new Size(141, 32);
            label2.TabIndex = 7;
            label2.Text = "Ders Notu:";
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(262, 401);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(150, 46);
            btnEkle.TabIndex = 20;
            btnEkle.Text = "ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btndusuk
            // 
            btndusuk.Location = new Point(262, 485);
            btndusuk.Name = "btndusuk";
            btndusuk.Size = new Size(150, 46);
            btndusuk.TabIndex = 21;
            btndusuk.Text = "en düşük";
            btndusuk.UseVisualStyleBackColor = true;
            btndusuk.Click += btndusuk_Click;
            // 
            // btnOrtalama
            // 
            btnOrtalama.Location = new Point(262, 640);
            btnOrtalama.Name = "btnOrtalama";
            btnOrtalama.Size = new Size(150, 46);
            btnOrtalama.TabIndex = 22;
            btnOrtalama.Text = "Ortalama";
            btnOrtalama.UseVisualStyleBackColor = true;
            btnOrtalama.Click += btnOrtalama_Click;
            // 
            // btnListele
            // 
            btnListele.Location = new Point(1272, 348);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(150, 46);
            btnListele.TabIndex = 23;
            btnListele.Text = "Listele";
            btnListele.UseVisualStyleBackColor = true;
            btnListele.Click += btnListele_Click;
            // 
            // btnEnYüksek
            // 
            btnEnYüksek.Location = new Point(262, 566);
            btnEnYüksek.Name = "btnEnYüksek";
            btnEnYüksek.Size = new Size(150, 46);
            btnEnYüksek.TabIndex = 25;
            btnEnYüksek.Text = "En yüksek";
            btnEnYüksek.UseVisualStyleBackColor = true;
            btnEnYüksek.Click += btnEnYüksek_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1508, 829);
            Controls.Add(btnEnYüksek);
            Controls.Add(btnListele);
            Controls.Add(btnOrtalama);
            Controls.Add(btndusuk);
            Controls.Add(btnEkle);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbListe);
            Controls.Add(txtOrtalama);
            Controls.Add(txtEnDusuk);
            Controls.Add(txtDersNotu);
            Controls.Add(txtEnYuksek);
            Controls.Add(txtAdSoyad);
            Name = "Form1";
            Text = "form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAdSoyad;
        private TextBox txtEnYuksek;
        private TextBox txtDersNotu;
        private TextBox txtEnDusuk;
        private TextBox txtOrtalama;
        private ListBox lbListe;
        private Label label1;
        private Label label2;
        private Button btnEkle;
        private Button btndusuk;
        private Button btnOrtalama;
        private Button btnListele;
        private Button btnEnYüksek;
    }
}
