namespace RPG
{
    partial class FrmTerminaLuta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTerminaLuta));
            this.btnsair = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblvencedor = new System.Windows.Forms.Label();
            this.ptbVencedor = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbVencedor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsair
            // 
            this.btnsair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsair.Location = new System.Drawing.Point(93, 370);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(104, 41);
            this.btnsair.TabIndex = 1;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(72, 49);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(149, 20);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "LUTA TERMINADA";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblvencedor
            // 
            this.lblvencedor.AutoSize = true;
            this.lblvencedor.Location = new System.Drawing.Point(96, 89);
            this.lblvencedor.Name = "lblvencedor";
            this.lblvencedor.Size = new System.Drawing.Size(101, 13);
            this.lblvencedor.TabIndex = 3;
            this.lblvencedor.Text = " O VENCEDOR FOI";
            // 
            // ptbVencedor
            // 
            this.ptbVencedor.Location = new System.Drawing.Point(57, 132);
            this.ptbVencedor.Name = "ptbVencedor";
            this.ptbVencedor.Size = new System.Drawing.Size(183, 203);
            this.ptbVencedor.TabIndex = 4;
            this.ptbVencedor.TabStop = false;
            // 
            // FrmTerminaLuta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(293, 455);
            this.Controls.Add(this.ptbVencedor);
            this.Controls.Add(this.lblvencedor);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnsair);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTerminaLuta";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fim do Combate";
            ((System.ComponentModel.ISupportInitialize)(this.ptbVencedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblvencedor;
        private System.Windows.Forms.PictureBox ptbVencedor;
    }
}