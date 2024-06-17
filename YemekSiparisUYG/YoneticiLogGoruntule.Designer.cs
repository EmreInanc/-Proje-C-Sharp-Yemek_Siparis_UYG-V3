namespace YemekSiparisUYG
{
    partial class YoneticiLogGoruntule
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
            this.LogDataGridView1 = new System.Windows.Forms.DataGridView();
            this.GeriDonBTN = new System.Windows.Forms.Button();
            this.Yenile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LogDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // LogDataGridView1
            // 
            this.LogDataGridView1.AllowUserToAddRows = false;
            this.LogDataGridView1.AllowUserToDeleteRows = false;
            this.LogDataGridView1.AllowUserToOrderColumns = true;
            this.LogDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LogDataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.LogDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LogDataGridView1.Location = new System.Drawing.Point(6, 13);
            this.LogDataGridView1.Name = "LogDataGridView1";
            this.LogDataGridView1.ReadOnly = true;
            this.LogDataGridView1.Size = new System.Drawing.Size(1074, 575);
            this.LogDataGridView1.TabIndex = 0;
            // 
            // GeriDonBTN
            // 
            this.GeriDonBTN.Location = new System.Drawing.Point(29, 594);
            this.GeriDonBTN.Name = "GeriDonBTN";
            this.GeriDonBTN.Size = new System.Drawing.Size(75, 23);
            this.GeriDonBTN.TabIndex = 1;
            this.GeriDonBTN.Text = "Geri Dön";
            this.GeriDonBTN.UseVisualStyleBackColor = true;
            this.GeriDonBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // Yenile
            // 
            this.Yenile.Location = new System.Drawing.Point(978, 594);
            this.Yenile.Name = "Yenile";
            this.Yenile.Size = new System.Drawing.Size(90, 23);
            this.Yenile.TabIndex = 2;
            this.Yenile.Text = "Yenile";
            this.Yenile.UseVisualStyleBackColor = true;
            this.Yenile.Click += new System.EventHandler(this.Yenile_Click);
            // 
            // YoneticiLogGoruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 629);
            this.Controls.Add(this.Yenile);
            this.Controls.Add(this.GeriDonBTN);
            this.Controls.Add(this.LogDataGridView1);
            this.Name = "YoneticiLogGoruntule";
            this.Text = "YoneticiLogGoruntule";
            ((System.ComponentModel.ISupportInitialize)(this.LogDataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView LogDataGridView1;
        private System.Windows.Forms.Button GeriDonBTN;
        private System.Windows.Forms.Button Yenile;
    }
}