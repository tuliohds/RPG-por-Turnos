namespace RPG
{
    partial class FrmPrecombate
    {
      
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

     
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrecombate));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblversus = new System.Windows.Forms.Label();
            this.btnbegin = new System.Windows.Forms.Button();
            this.LblNomePlay1 = new System.Windows.Forms.Label();
            this.LblNomePlay2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(23, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 183);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(276, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(162, 183);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // lblversus
            // 
            this.lblversus.AutoSize = true;
            this.lblversus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblversus.Location = new System.Drawing.Point(216, 114);
            this.lblversus.Name = "lblversus";
            this.lblversus.Size = new System.Drawing.Size(25, 24);
            this.lblversus.TabIndex = 2;
            this.lblversus.Text = "X";
            // 
            // btnbegin
            // 
            this.btnbegin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbegin.Location = new System.Drawing.Point(164, 234);
            this.btnbegin.Name = "btnbegin";
            this.btnbegin.Size = new System.Drawing.Size(136, 23);
            this.btnbegin.TabIndex = 3;
            this.btnbegin.Text = "COMEÇAR BATALHA";
            this.btnbegin.UseVisualStyleBackColor = true;
            this.btnbegin.Click += new System.EventHandler(this.btnbegin_Click);
            // 
            // LblNomePlay1
            // 
            this.LblNomePlay1.AutoSize = true;
            this.LblNomePlay1.Location = new System.Drawing.Point(26, 12);
            this.LblNomePlay1.Name = "LblNomePlay1";
            this.LblNomePlay1.Size = new System.Drawing.Size(0, 13);
            this.LblNomePlay1.TabIndex = 5;
            // 
            // LblNomePlay2
            // 
            this.LblNomePlay2.AutoSize = true;
            this.LblNomePlay2.Location = new System.Drawing.Point(279, 12);
            this.LblNomePlay2.Name = "LblNomePlay2";
            this.LblNomePlay2.Size = new System.Drawing.Size(0, 13);
            this.LblNomePlay2.TabIndex = 6;
            // 
            // FrmPrecombate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(457, 320);
            this.ControlBox = false;
            this.Controls.Add(this.LblNomePlay2);
            this.Controls.Add(this.LblNomePlay1);
            this.Controls.Add(this.btnbegin);
            this.Controls.Add(this.lblversus);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrecombate";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pre Combate";
            this.Load += new System.EventHandler(this.frmPrecombate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblversus;
        private System.Windows.Forms.Button btnbegin;
        private System.Windows.Forms.Label LblNomePlay1;
        private System.Windows.Forms.Label LblNomePlay2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}