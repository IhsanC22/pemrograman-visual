namespace WinFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            txtsuhu = new TextBox();
            button1 = new Button();
            btn_reset = new Button();
            tbhasil = new TextBox();
            cbsuhu = new ComboBox();
            cbsuhu2 = new ComboBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(147, 93);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 0;
            label1.Text = "Satuan Suhu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(147, 171);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 1;
            label2.Text = "Hasil konversi";
            label2.Click += label2_Click;
            // 
            // txtsuhu
            // 
            txtsuhu.Location = new Point(283, 89);
            txtsuhu.Name = "txtsuhu";
            txtsuhu.Size = new Size(100, 23);
            txtsuhu.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(283, 256);
            button1.Name = "button1";
            button1.Size = new Size(111, 23);
            button1.TabIndex = 3;
            button1.Text = "Konversi";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btn_reset
            // 
            btn_reset.BackColor = SystemColors.ActiveCaption;
            btn_reset.FlatStyle = FlatStyle.Popup;
            btn_reset.Location = new Point(486, 253);
            btn_reset.Name = "btn_reset";
            btn_reset.Size = new Size(73, 26);
            btn_reset.TabIndex = 4;
            btn_reset.Text = "Reset";
            btn_reset.UseVisualStyleBackColor = false;
            btn_reset.Click += button2_Click;
            // 
            // tbhasil
            // 
            tbhasil.Location = new Point(283, 168);
            tbhasil.Name = "tbhasil";
            tbhasil.Size = new Size(128, 23);
            tbhasil.TabIndex = 5;
            tbhasil.TextChanged += textBox2_TextChanged;
            // 
            // cbsuhu
            // 
            cbsuhu.AutoCompleteCustomSource.AddRange(new string[] { "celcius", "fahrenheit", "reamur" });
            cbsuhu.FormattingEnabled = true;
            cbsuhu.Location = new Point(441, 85);
            cbsuhu.Name = "cbsuhu";
            cbsuhu.Size = new Size(159, 23);
            cbsuhu.TabIndex = 6;
            // 
            // cbsuhu2
            // 
            cbsuhu2.AutoCompleteCustomSource.AddRange(new string[] { "celcius", "fahrenheit", "reamur" });
            cbsuhu2.FormattingEnabled = true;
            cbsuhu2.Location = new Point(441, 168);
            cbsuhu2.Name = "cbsuhu2";
            cbsuhu2.Size = new Size(159, 23);
            cbsuhu2.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 253);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(223, 396);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Red;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Yellow;
            label3.Location = new Point(17, 230);
            label3.Name = "label3";
            label3.Size = new Size(210, 20);
            label3.TabIndex = 9;
            label3.Text = "LIVE SUBWAY SURF REACTION";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(117, 9);
            label4.Name = "label4";
            label4.Size = new Size(559, 30);
            label4.TabIndex = 10;
            label4.Text = "PROGRAM KONVERSI SUHU MUHAMAD IHSAN";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(356, 48);
            label5.Name = "label5";
            label5.Size = new Size(112, 25);
            label5.TabIndex = 11;
            label5.Text = "2209106099";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(800, 661);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(cbsuhu2);
            Controls.Add(cbsuhu);
            Controls.Add(tbhasil);
            Controls.Add(btn_reset);
            Controls.Add(button1);
            Controls.Add(txtsuhu);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Konversi suhu sederhana /// Muhamad ihsan";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtsuhu;
        private Button button1;
        private Button btn_reset;
        private TextBox tbhasil;
        private ComboBox cbsuhu;
        private ComboBox cbsuhu2;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
