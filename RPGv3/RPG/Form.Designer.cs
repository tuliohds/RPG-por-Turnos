namespace RPG
{
    partial class frmRPG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRPG));
            this.btnjogar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnjogar
            // 
            this.btnjogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnjogar.Location = new System.Drawing.Point(210, 124);
            this.btnjogar.Name = "btnjogar";
            this.btnjogar.Size = new System.Drawing.Size(135, 26);
            this.btnjogar.TabIndex = 0;
            this.btnjogar.Text = "JOGAR";
            this.btnjogar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnjogar.UseVisualStyleBackColor = true;
            this.btnjogar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSair
            // 
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Location = new System.Drawing.Point(239, 165);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmRPG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(544, 371);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnjogar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRPG";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RPG";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnjogar;
        private System.Windows.Forms.Button btnSair;
    }
}

