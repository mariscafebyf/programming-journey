
namespace PROYEK_AKHIR_MARISCA_XPPLG2
{
    partial class tbKembalian
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tbKembalian));
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbMakanan = new Label();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            btnBayar = new Button();
            label10 = new Label();
            tbHarga = new Label();
            tbTotal = new TextBox();
            tbBayar = new TextBox();
            cbBayar = new Label();
            cbKembalian = new Label();
            txtKembalian = new TextBox();
            btnTotalHarga = new Button();
            cbMakanan = new ComboBox();
            tbMinuman = new Label();
            cbMinuman = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.ErrorImage = (Image)resources.GetObject("pictureBox2.ErrorImage");
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(435, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(355, 241);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Snap ITC", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(10, 22);
            label1.Name = "label1";
            label1.Size = new Size(377, 36);
            label1.TabIndex = 2;
            label1.Text = "ANGKRINGAN JOWO";
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Heavy", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(10, 95);
            label2.Name = "label2";
            label2.Size = new Size(0, 30);
            label2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(12, 136);
            label3.Name = "label3";
            label3.Size = new Size(0, 25);
            label3.TabIndex = 4;
            // 
            // tbMakanan
            // 
            tbMakanan.AutoSize = true;
            tbMakanan.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbMakanan.ForeColor = Color.Black;
            tbMakanan.Location = new Point(6, 95);
            tbMakanan.Name = "tbMakanan";
            tbMakanan.Size = new Size(180, 25);
            tbMakanan.TabIndex = 7;
            tbMakanan.Text = "JENIS MAKANAN :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(18, 142);
            label5.Name = "label5";
            label5.Size = new Size(17, 25);
            label5.TabIndex = 8;
            label5.Text = " ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 139);
            label6.Name = "label6";
            label6.Size = new Size(0, 25);
            label6.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(248, 235);
            label8.Name = "label8";
            label8.Size = new Size(0, 25);
            label8.TabIndex = 11;
            // 
            // btnBayar
            // 
            btnBayar.BackColor = SystemColors.ActiveBorder;
            btnBayar.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBayar.ForeColor = Color.Black;
            btnBayar.Location = new Point(238, 369);
            btnBayar.Name = "btnBayar";
            btnBayar.Size = new Size(112, 34);
            btnBayar.TabIndex = 14;
            btnBayar.Text = "Bayar";
            btnBayar.UseVisualStyleBackColor = false;
            btnBayar.Click += button1_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(149, 378);
            label10.Name = "label10";
            label10.Size = new Size(0, 25);
            label10.TabIndex = 15;
            // 
            // tbHarga
            // 
            tbHarga.AutoSize = true;
            tbHarga.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbHarga.ForeColor = Color.Black;
            tbHarga.Location = new Point(18, 195);
            tbHarga.Name = "tbHarga";
            tbHarga.Size = new Size(170, 25);
            tbHarga.TabIndex = 17;
            tbHarga.Text = "TOTAL HARGA    :";
            // 
            // tbTotal
            // 
            tbTotal.BackColor = Color.Gold;
            tbTotal.Location = new Point(200, 201);
            tbTotal.Name = "tbTotal";
            tbTotal.Size = new Size(150, 31);
            tbTotal.TabIndex = 18;
            // 
            // tbBayar
            // 
            tbBayar.BackColor = Color.LawnGreen;
            tbBayar.Location = new Point(200, 253);
            tbBayar.Name = "tbBayar";
            tbBayar.Size = new Size(150, 31);
            tbBayar.TabIndex = 19;
            tbBayar.TextChanged += textBox5_TextChanged;
            // 
            // cbBayar
            // 
            cbBayar.AutoSize = true;
            cbBayar.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbBayar.ForeColor = Color.Black;
            cbBayar.Location = new Point(18, 256);
            cbBayar.Name = "cbBayar";
            cbBayar.Size = new Size(157, 25);
            cbBayar.TabIndex = 22;
            cbBayar.Text = "TOTAL BAYAR  :";
            // 
            // cbKembalian
            // 
            cbKembalian.AutoSize = true;
            cbKembalian.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbKembalian.Location = new Point(21, 305);
            cbKembalian.Name = "cbKembalian";
            cbKembalian.Size = new Size(154, 25);
            cbKembalian.TabIndex = 23;
            cbKembalian.Text = "KEMBALIAN     :";
            // 
            // txtKembalian
            // 
            txtKembalian.BackColor = Color.Red;
            txtKembalian.Location = new Point(200, 305);
            txtKembalian.Name = "txtKembalian";
            txtKembalian.Size = new Size(150, 31);
            txtKembalian.TabIndex = 24;
            txtKembalian.TextChanged += txtKembalian_TextChanged;
            // 
            // btnTotalHarga
            // 
            btnTotalHarga.BackColor = SystemColors.ActiveBorder;
            btnTotalHarga.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTotalHarga.Location = new Point(63, 369);
            btnTotalHarga.Name = "btnTotalHarga";
            btnTotalHarga.Size = new Size(112, 34);
            btnTotalHarga.TabIndex = 25;
            btnTotalHarga.Text = "Total";
            btnTotalHarga.UseVisualStyleBackColor = false;
            btnTotalHarga.Click += button2_Click;
            // 
            // cbMakanan
            // 
            cbMakanan.FormattingEnabled = true;
            cbMakanan.Items.AddRange(new object[] { "Sego bakar\t : 12.000", "Sego rica ayam\t : 15.000", "Sate udang tepung\t: 5.000", "Sate cumi tepung\t: 5.000", "Tahu/tempe\t: 3.000", "Bakwan\t\t: 3.000", "", "", "     " });
            cbMakanan.Location = new Point(200, 95);
            cbMakanan.Name = "cbMakanan";
            cbMakanan.Size = new Size(150, 33);
            cbMakanan.TabIndex = 27;
            cbMakanan.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // tbMinuman
            // 
            tbMinuman.AutoSize = true;
            tbMinuman.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbMinuman.Location = new Point(10, 136);
            tbMinuman.Name = "tbMinuman";
            tbMinuman.Size = new Size(177, 25);
            tbMinuman.TabIndex = 29;
            tbMinuman.Text = "JENIS MINUMAN :";
            // 
            // cbMinuman
            // 
            cbMinuman.FormattingEnabled = true;
            cbMinuman.Items.AddRange(new object[] { "Wedang ronde\t\t: 10.000", "Wedang teh\t\t: 4.000", "Es jeruk\t\t\t: 5.000", "Es teh\t\t\t: 4.000" });
            cbMinuman.Location = new Point(200, 139);
            cbMinuman.Name = "cbMinuman";
            cbMinuman.Size = new Size(150, 33);
            cbMinuman.TabIndex = 30;
            cbMinuman.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // tbKembalian
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightYellow;
            ClientSize = new Size(802, 615);
            Controls.Add(cbMinuman);
            Controls.Add(tbMinuman);
            Controls.Add(cbMakanan);
            Controls.Add(btnTotalHarga);
            Controls.Add(txtKembalian);
            Controls.Add(cbKembalian);
            Controls.Add(cbBayar);
            Controls.Add(tbBayar);
            Controls.Add(tbTotal);
            Controls.Add(tbHarga);
            Controls.Add(label10);
            Controls.Add(btnBayar);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(tbMakanan);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            ForeColor = Color.Black;
            Name = "tbKembalian";
            Text = "from1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void txtKembalian_TextChanged(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        #endregion
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label tbMakanan;
        private Label label5;
        private Label label6;
        private Label label8;
        private Button btnBayar;
        private Label label10;
        private Label tbHarga;
        private TextBox tbTotal;
        private TextBox tbBayar;
        private Label cbBayar;
        private Label cbKembalian;
        private TextBox txtKembalian;
        private Button btnTotalHarga;
        private ComboBox cbMakanan;
        private Label tbMinuman;
        private ComboBox cbMinuman;
    }
}
