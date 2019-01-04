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
    public partial class FrmTerminaLuta : Form
    {
        public FrmTerminaLuta()
        {
            InitializeComponent();
        }
        public FrmTerminaLuta(Jogador jogador, string enderecoImagem)
        {
            InitializeComponent();
            lblvencedor.Text = jogador.Personagem.Nome;
            string ImagePath = enderecoImagem + jogador.Personagem.NomeImegem;
            ptbVencedor.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbVencedor.Image = Image.FromFile(ImagePath);

        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
