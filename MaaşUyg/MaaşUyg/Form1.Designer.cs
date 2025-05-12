namespace Maaşuyg
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
            btnekle = new Button();
            btndusuk = new Button();
            btnyuksek = new Button();
            tbntoplam = new Button();
            lsbox1 = new ListBox();
            btntemizle2 = new Button();
            txtisim = new TextBox();
            txtmaas = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnlistele = new Button();
            SuspendLayout();
            // 
            // btnekle
            // 
            btnekle.Location = new Point(190, 186);
            btnekle.Name = "btnekle";
            btnekle.Size = new Size(150, 46);
            btnekle.TabIndex = 0;
            btnekle.Text = "Ekle";
            btnekle.UseVisualStyleBackColor = true;
            btnekle.Click += btnekle_Click;
            // 
            // btndusuk
            // 
            btndusuk.Location = new Point(328, 258);
            btndusuk.Name = "btndusuk";
            btndusuk.Size = new Size(186, 122);
            btndusuk.TabIndex = 1;
            btndusuk.Text = "En düşük maaş";
            btndusuk.UseVisualStyleBackColor = true;
            btndusuk.Click += btndusuk_Click;
            // 
            // btnyuksek
            // 
            btnyuksek.Location = new Point(328, 398);
            btnyuksek.Name = "btnyuksek";
            btnyuksek.Size = new Size(186, 122);
            btnyuksek.TabIndex = 2;
            btnyuksek.Text = "En yüksek maaş";
            btnyuksek.UseVisualStyleBackColor = true;
            btnyuksek.Click += btnyuksek_Click;
            // 
            // tbntoplam
            // 
            tbntoplam.Location = new Point(328, 544);
            tbntoplam.Name = "tbntoplam";
            tbntoplam.Size = new Size(186, 122);
            tbntoplam.TabIndex = 3;
            tbntoplam.Text = "Toplam maaş";
            tbntoplam.UseVisualStyleBackColor = true;
            tbntoplam.Click += tbntoplam_Click;
            // 
            // lsbox1
            // 
            lsbox1.FormattingEnabled = true;
            lsbox1.Location = new Point(989, 124);
            lsbox1.Name = "lsbox1";
            lsbox1.Size = new Size(307, 420);
            lsbox1.TabIndex = 6;
            // 
            // btntemizle2
            // 
            btntemizle2.Location = new Point(1069, 550);
            btntemizle2.Name = "btntemizle2";
            btntemizle2.Size = new Size(150, 46);
            btntemizle2.TabIndex = 7;
            btntemizle2.Text = "temizle";
            btntemizle2.UseVisualStyleBackColor = true;
            btntemizle2.Click += btntemizle2_Click;
            // 
            // txtisim
            // 
            txtisim.Location = new Point(169, 60);
            txtisim.Name = "txtisim";
            txtisim.Size = new Size(200, 39);
            txtisim.TabIndex = 8;
            // 
            // txtmaas
            // 
            txtmaas.Location = new Point(169, 141);
            txtmaas.Name = "txtmaas";
            txtmaas.Size = new Size(200, 39);
            txtmaas.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(64, 310);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(200, 39);
            textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(64, 440);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(200, 39);
            textBox4.TabIndex = 11;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(64, 586);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(200, 39);
            textBox5.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label1.Location = new Point(54, 53);
            label1.Name = "label1";
            label1.Size = new Size(101, 45);
            label1.TabIndex = 13;
            label1.Text = "İsim :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label2.Location = new Point(54, 135);
            label2.Name = "label2";
            label2.Size = new Size(118, 45);
            label2.TabIndex = 14;
            label2.Text = "Maaş :";
            // 
            // btnlistele
            // 
            btnlistele.Location = new Point(712, 236);
            btnlistele.Name = "btnlistele";
            btnlistele.Size = new Size(203, 123);
            btnlistele.TabIndex = 15;
            btnlistele.Text = "listele";
            btnlistele.UseVisualStyleBackColor = true;
            btnlistele.Click += btnlistele_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1521, 846);
            Controls.Add(btnlistele);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(txtmaas);
            Controls.Add(txtisim);
            Controls.Add(btntemizle2);
            Controls.Add(lsbox1);
            Controls.Add(tbntoplam);
            Controls.Add(btnyuksek);
            Controls.Add(btndusuk);
            Controls.Add(btnekle);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnekle;
        private Button btndusuk;
        private Button btnyuksek;
        private Button tbntoplam;
        private ListBox lsbox1;
        private Button btntemizle2;
        private TextBox txtisim;
        private TextBox txtmaas;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label1;
        private Label label2;
        private Button btnlistele;
    }
}
