using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPG
{
    public partial class FrmPrecombate : Form
    {
        Jogo NovoJogo = new Jogo();
        public FrmPrecombate()
        {
            InitializeComponent();
        }
        public FrmPrecombate(Personagem[] personagem)
        {

        }
        public FrmPrecombate(Jogo jogo)
        {
            NovoJogo = jogo;
            InitializeComponent();
            LblNomePlay1.Text = NovoJogo.Player1.Nome;
            LblNomePlay2.Text = NovoJogo.Player2.Nome;
        }

        private void frmPrecombate_Load(object sender, EventArgs e)
        {
            string ImagePath = NovoJogo.EnderecoImagens + NovoJogo.Player1.Personagem.NomeImegem;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Image.FromFile(ImagePath);

            string ImagePath2 = NovoJogo.EnderecoImagens + NovoJogo.Player2.Personagem.NomeImegem;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Image = Image.FromFile(ImagePath2);

        }

        private void btnbegin_Click(object sender, EventArgs e)
        {
            FrmCombate combate = new FrmCombate(NovoJogo);
            this.Hide();
            combate.ShowDialog();
        }

        private void btnvoltar3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
