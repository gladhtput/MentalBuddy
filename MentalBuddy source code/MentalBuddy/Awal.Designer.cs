namespace MentalBuddy
{
    partial class Awal
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
            this.btnCapas = new System.Windows.Forms.Button();
            this.btnPsi = new System.Windows.Forms.Button();
            this.lblExit = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCapas
            // 
            this.btnCapas.Location = new System.Drawing.Point(47, 62);
            this.btnCapas.Margin = new System.Windows.Forms.Padding(4);
            this.btnCapas.Name = "btnCapas";
            this.btnCapas.Size = new System.Drawing.Size(137, 28);
            this.btnCapas.TabIndex = 0;
            this.btnCapas.Text = "Calon Pasien";
            this.btnCapas.UseVisualStyleBackColor = true;
            this.btnCapas.Click += new System.EventHandler(this.btnCapas_Click);
            // 
            // btnPsi
            // 
            this.btnPsi.Location = new System.Drawing.Point(47, 97);
            this.btnPsi.Margin = new System.Windows.Forms.Padding(4);
            this.btnPsi.Name = "btnPsi";
            this.btnPsi.Size = new System.Drawing.Size(137, 28);
            this.btnPsi.TabIndex = 1;
            this.btnPsi.Text = "Psikolog/Psikiater";
            this.btnPsi.UseVisualStyleBackColor = true;
            this.btnPsi.Click += new System.EventHandler(this.btnPsi_Click);
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.Location = new System.Drawing.Point(91, 146);
            this.lblExit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(37, 20);
            this.lblExit.TabIndex = 2;
            this.lblExit.Text = "Exit";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Masuk Sebagai";
            // 
            // Awal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(220, 201);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.btnPsi);
            this.Controls.Add(this.btnCapas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Awal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCapas;
        private System.Windows.Forms.Button btnPsi;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Label label2;
    }
}

