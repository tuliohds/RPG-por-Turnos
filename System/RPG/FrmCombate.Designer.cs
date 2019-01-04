namespace RPG
{
    partial class FrmCombate
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

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCombate));
            this.BntAtacar1 = new System.Windows.Forms.Button();
            this.GprPlay2 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Pbar_Mana2 = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.Pbar_pontosdeVida2 = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bntAtacar2 = new System.Windows.Forms.Button();
            this.BntTrocarArma = new System.Windows.Forms.Button();
            this.lblArmaAtual1 = new System.Windows.Forms.Label();
            this.lblArmaAtual2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.BntTrocarArma2 = new System.Windows.Forms.Button();
            this.btnespecial1 = new System.Windows.Forms.Button();
            this.btnespecial2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Pbar_pontosdeVida1 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.Pbar_Mana1 = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GprPlay1 = new System.Windows.Forms.GroupBox();
            this.GprPlay2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GprPlay1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BntAtacar1
            // 
            this.BntAtacar1.Location = new System.Drawing.Point(198, 398);
            this.BntAtacar1.Name = "BntAtacar1";
            this.BntAtacar1.Size = new System.Drawing.Size(68, 24);
            this.BntAtacar1.TabIndex = 0;
            this.BntAtacar1.Text = "Atacar";
            this.BntAtacar1.UseVisualStyleBackColor = true;
            this.BntAtacar1.Click += new System.EventHandler(this.BntAtacar1_Click_1);
            // 
            // GprPlay2
            // 
            this.GprPlay2.Controls.Add(this.pictureBox2);
            this.GprPlay2.Controls.Add(this.Pbar_Mana2);
            this.GprPlay2.Controls.Add(this.label3);
            this.GprPlay2.Controls.Add(this.Pbar_pontosdeVida2);
            this.GprPlay2.Controls.Add(this.label4);
            this.GprPlay2.Location = new System.Drawing.Point(338, 23);
            this.GprPlay2.Name = "GprPlay2";
            this.GprPlay2.Size = new System.Drawing.Size(279, 350);
            this.GprPlay2.TabIndex = 2;
            this.GprPlay2.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(50, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(183, 203);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // Pbar_Mana2
            // 
            this.Pbar_Mana2.Location = new System.Drawing.Point(61, 304);
            this.Pbar_Mana2.Name = "Pbar_Mana2";
            this.Pbar_Mana2.Size = new System.Drawing.Size(172, 23);
            this.Pbar_Mana2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mana";
            // 
            // Pbar_pontosdeVida2
            // 
            this.Pbar_pontosdeVida2.Location = new System.Drawing.Point(61, 259);
            this.Pbar_pontosdeVida2.Maximum = 4000;
            this.Pbar_pontosdeVida2.Name = "Pbar_pontosdeVida2";
            this.Pbar_pontosdeVida2.Size = new System.Drawing.Size(172, 23);
            this.Pbar_pontosdeVida2.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Pontos de Vida";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 403);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Arma Atual";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(343, 401);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Arma Atual";
            // 
            // bntAtacar2
            // 
            this.bntAtacar2.Location = new System.Drawing.Point(503, 398);
            this.bntAtacar2.Name = "bntAtacar2";
            this.bntAtacar2.Size = new System.Drawing.Size(68, 24);
            this.bntAtacar2.TabIndex = 8;
            this.bntAtacar2.Text = "Atacar";
            this.bntAtacar2.UseVisualStyleBackColor = true;
            this.bntAtacar2.Click += new System.EventHandler(this.bntAtacar2_Click_1);
            // 
            // BntTrocarArma
            // 
            this.BntTrocarArma.Location = new System.Drawing.Point(198, 434);
            this.BntTrocarArma.Name = "BntTrocarArma";
            this.BntTrocarArma.Size = new System.Drawing.Size(68, 24);
            this.BntTrocarArma.TabIndex = 11;
            this.BntTrocarArma.Text = "Trocar Arma";
            this.BntTrocarArma.UseVisualStyleBackColor = true;
            this.BntTrocarArma.Click += new System.EventHandler(this.BntTrocarArma_Click);
            // 
            // lblArmaAtual1
            // 
            this.lblArmaAtual1.AutoSize = true;
            this.lblArmaAtual1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArmaAtual1.Location = new System.Drawing.Point(107, 403);
            this.lblArmaAtual1.Name = "lblArmaAtual1";
            this.lblArmaAtual1.Size = new System.Drawing.Size(0, 15);
            this.lblArmaAtual1.TabIndex = 13;
            // 
            // lblArmaAtual2
            // 
            this.lblArmaAtual2.AutoSize = true;
            this.lblArmaAtual2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArmaAtual2.Location = new System.Drawing.Point(412, 400);
            this.lblArmaAtual2.Name = "lblArmaAtual2";
            this.lblArmaAtual2.Size = new System.Drawing.Size(0, 15);
            this.lblArmaAtual2.TabIndex = 14;
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "Nome";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(36, 437);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 21);
            this.comboBox1.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(37, 422);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Lista de Armas";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(339, 421);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "Lista de Armas";
            // 
            // comboBox2
            // 
            this.comboBox2.DisplayMember = "Nome";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(338, 437);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(150, 21);
            this.comboBox2.TabIndex = 18;
            // 
            // BntTrocarArma2
            // 
            this.BntTrocarArma2.Location = new System.Drawing.Point(503, 434);
            this.BntTrocarArma2.Name = "BntTrocarArma2";
            this.BntTrocarArma2.Size = new System.Drawing.Size(68, 24);
            this.BntTrocarArma2.TabIndex = 17;
            this.BntTrocarArma2.Text = "Trocar Arma";
            this.BntTrocarArma2.UseVisualStyleBackColor = true;
            this.BntTrocarArma2.Click += new System.EventHandler(this.BntTrocarArma2_Click);
            // 
            // btnespecial1
            // 
            this.btnespecial1.Location = new System.Drawing.Point(34, 464);
            this.btnespecial1.Name = "btnespecial1";
            this.btnespecial1.Size = new System.Drawing.Size(152, 21);
            this.btnespecial1.TabIndex = 20;
            this.btnespecial1.Text = "Ataque Especial";
            this.btnespecial1.UseVisualStyleBackColor = true;
            this.btnespecial1.Click += new System.EventHandler(this.btnespecial1_Click);
            // 
            // btnespecial2
            // 
            this.btnespecial2.Location = new System.Drawing.Point(338, 464);
            this.btnespecial2.Name = "btnespecial2";
            this.btnespecial2.Size = new System.Drawing.Size(150, 21);
            this.btnespecial2.TabIndex = 21;
            this.btnespecial2.Text = "Ataque Especial";
            this.btnespecial2.UseVisualStyleBackColor = true;
            this.btnespecial2.Click += new System.EventHandler(this.btnespecial2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pontos de Vida";
            // 
            // Pbar_pontosdeVida1
            // 
            this.Pbar_pontosdeVida1.Location = new System.Drawing.Point(48, 259);
            this.Pbar_pontosdeVida1.Maximum = 4000;
            this.Pbar_pontosdeVida1.Name = "Pbar_pontosdeVida1";
            this.Pbar_pontosdeVida1.Size = new System.Drawing.Size(172, 23);
            this.Pbar_pontosdeVida1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mana";
            // 
            // Pbar_Mana1
            // 
            this.Pbar_Mana1.Location = new System.Drawing.Point(48, 304);
            this.Pbar_Mana1.Name = "Pbar_Mana1";
            this.Pbar_Mana1.Size = new System.Drawing.Size(172, 23);
            this.Pbar_Mana1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(37, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 203);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // GprPlay1
            // 
            this.GprPlay1.Controls.Add(this.pictureBox1);
            this.GprPlay1.Controls.Add(this.Pbar_Mana1);
            this.GprPlay1.Controls.Add(this.label2);
            this.GprPlay1.Controls.Add(this.Pbar_pontosdeVida1);
            this.GprPlay1.Controls.Add(this.label1);
            this.GprPlay1.Location = new System.Drawing.Point(27, 23);
            this.GprPlay1.Name = "GprPlay1";
            this.GprPlay1.Size = new System.Drawing.Size(265, 350);
            this.GprPlay1.TabIndex = 1;
            this.GprPlay1.TabStop = false;
            // 
            // FrmCombate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(644, 497);
            this.ControlBox = false;
            this.Controls.Add(this.btnespecial2);
            this.Controls.Add(this.btnespecial1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.BntTrocarArma2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblArmaAtual2);
            this.Controls.Add(this.lblArmaAtual1);
            this.Controls.Add(this.BntTrocarArma);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bntAtacar2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.GprPlay2);
            this.Controls.Add(this.GprPlay1);
            this.Controls.Add(this.BntAtacar1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCombate";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Combate";
            this.Load += new System.EventHandler(this.FrmCombate_Load);
            this.GprPlay2.ResumeLayout(false);
            this.GprPlay2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GprPlay1.ResumeLayout(false);
            this.GprPlay1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private System.Windows.Forms.Button BntAtacar1;
        private System.Windows.Forms.GroupBox GprPlay2;
        private System.Windows.Forms.ProgressBar Pbar_Mana2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar Pbar_pontosdeVida2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bntAtacar2;
        private System.Windows.Forms.Button BntTrocarArma;
        private System.Windows.Forms.Label lblArmaAtual1;
        private System.Windows.Forms.Label lblArmaAtual2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button BntTrocarArma2;
        private System.Windows.Forms.Button btnespecial1;
        private System.Windows.Forms.Button btnespecial2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar Pbar_pontosdeVida1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar Pbar_Mana1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox GprPlay1;
    }
}