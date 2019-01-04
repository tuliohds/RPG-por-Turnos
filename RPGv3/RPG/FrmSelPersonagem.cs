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
    public partial class FrmSelPersonagem : Form
    {

        public Jogo NovoJogo { get; set; }
        public int CountPersonagem = 0;
        public FrmSelPersonagem()
        {
            InitializeComponent();
        }
        
        public FrmSelPersonagem(Jogo jogo)
        {
            NovoJogo = jogo;
            InitializeComponent();
        }

        public void NovoPersonagem(Personagem personagem)
        {
            if (CountPersonagem == 0)
                NovoJogo.Player1.Personagem = personagem;
            else
                NovoJogo.Player2.Personagem = personagem;
            CountPersonagem++;
        }
        public void MudarDeTela()
        {
            if (CountPersonagem <= 1)
                this.Show();
            else
            {
                FrmPrecombate combate = new FrmPrecombate(NovoJogo);
                combate.Show();
                this.Hide();
            }
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnguerreiro_Click(object sender, EventArgs e)
        {
            this.NovoPersonagem(new Gerreiro());
            this.MudarDeTela();
        }

        private void btnladrao_Click(object sender, EventArgs e)
        {
            this.NovoPersonagem(new Ladrao());
            this.MudarDeTela();
        }

        private void btnmago_Click(object sender, EventArgs e)
        {

            this.NovoPersonagem(new Mago());
            this.MudarDeTela();
        }

        private void btnpaladino_Click(object sender, EventArgs e)
        {

            this.NovoPersonagem(new Paladino());
            this.MudarDeTela();
        }

        private void btnanimal_Click(object sender, EventArgs e)
        {
            this.NovoPersonagem(new Animal());
            this.MudarDeTela();
        }

        private void btnTroll_Click(object sender, EventArgs e)
        {
            this.NovoPersonagem(new Troll());
            this.MudarDeTela();
        }

        private void btndragao_Click(object sender, EventArgs e)
        {
            this.NovoPersonagem(new Dragao());
            this.MudarDeTela();
        }

        private void btnzumbi_Click(object sender, EventArgs e)
        {
            this.NovoPersonagem(new Zumbi());
            this.MudarDeTela();
        }
    }
}
