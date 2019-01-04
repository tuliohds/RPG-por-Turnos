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
    public partial class frmRPG : Form
    {
        public Jogo jogo { get; set; }
        public frmRPG()
        {
            InitializeComponent();
            jogo = new Jogo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmSelPersonagem SelPersonagem = new FrmSelPersonagem(jogo);
            this.Hide();
            SelPersonagem.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BntOpcoes_Click(object sender, EventArgs e)
        {

        }
    }
}
