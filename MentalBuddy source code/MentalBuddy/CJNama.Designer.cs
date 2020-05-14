namespace MentalBuddy
{
    partial class CJNama
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_back1 = new System.Windows.Forms.Button();
            this.btn_cari1 = new System.Windows.Forms.Button();
            this.tb_nama = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "psikolog",
            "psikiater"});
            this.comboBox1.Location = new System.Drawing.Point(209, 122);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(309, 24);
            this.comboBox1.TabIndex = 48;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btn_back1
            // 
            this.btn_back1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back1.Location = new System.Drawing.Point(125, 185);
            this.btn_back1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_back1.Name = "btn_back1";
            this.btn_back1.Size = new System.Drawing.Size(116, 43);
            this.btn_back1.TabIndex = 47;
            this.btn_back1.Text = "Kembali";
            this.btn_back1.UseVisualStyleBackColor = true;
            this.btn_back1.Click += new System.EventHandler(this.btn_back1_Click);
            // 
            // btn_cari1
            // 
            this.btn_cari1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cari1.Location = new System.Drawing.Point(404, 185);
            this.btn_cari1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cari1.Name = "btn_cari1";
            this.btn_cari1.Size = new System.Drawing.Size(116, 43);
            this.btn_cari1.TabIndex = 46;
            this.btn_cari1.Text = "Cari";
            this.btn_cari1.UseVisualStyleBackColor = true;
            this.btn_cari1.Click += new System.EventHandler(this.btn_cari1_Click);
            // 
            // tb_nama
            // 
            this.tb_nama.Location = new System.Drawing.Point(209, 66);
            this.tb_nama.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_nama.Name = "tb_nama";
            this.tb_nama.Size = new System.Drawing.Size(309, 22);
            this.tb_nama.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(120, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 25);
            this.label4.TabIndex = 44;
            this.label4.Text = "Profesi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(120, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 43;
            this.label3.Text = "Nama";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(548, 25);
            this.label1.TabIndex = 40;
            this.label1.Text = "Silahkan Masukkan Nama dan Profesi Yang Ingin Dicari";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CJNama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 251);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_back1);
            this.Controls.Add(this.btn_cari1);
            this.Controls.Add(this.tb_nama);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CJNama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CJNama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_back1;
        private System.Windows.Forms.Button btn_cari1;
        private System.Windows.Forms.TextBox tb_nama;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}