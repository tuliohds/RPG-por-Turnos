using RPG.Class.Item;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static RPG.Class.Enum;

namespace RPG
{
    public partial class FrmCombate : Form
    {
        Jogo NovoJogo = new Jogo();
        public string lblvencedor;
        public int CoutTurno { get; set; }
        public bool Turno { get; set; }
        public FrmCombate()
        {
            InitializeComponent();

        }
        public FrmCombate(Jogo jogo)
        {
            this.NovoJogo = jogo;
            this.Turno = true;
            InitializeComponent();
            AtualizarTela();

        }

        public void TrocaTurno()
        {

            if (this.Turno)
            {
                this.Turno = false;
            }
            else
            {
                this.Turno = true;
            }

        }

        public void TurnoTela()
        {

            if (Turno)
            {
                lblArmaAtual1.Enabled = true;
                BntAtacar1.Enabled = true;
                BntTrocarArma.Enabled = true;
                comboBox1.Enabled = true;
                btnespecial1.Enabled = false;


                lblArmaAtual2.Enabled = false;
                bntAtacar2.Enabled = false;
                BntTrocarArma2.Enabled = false;
                comboBox2.Enabled = true;
                btnespecial2.Enabled = false;
                if (NovoJogo.Player1.CoutTurno >= 10)
                    btnespecial1.Enabled = true;
                else
                    btnespecial1.Enabled = false;

            }
            else
            {
                lblArmaAtual1.Enabled = false;
                BntAtacar1.Enabled = false;
                BntTrocarArma.Enabled = false;
                comboBox2.Enabled = false;
                btnespecial1.Enabled = false;

                lblArmaAtual2.Enabled = true;
                bntAtacar2.Enabled = true;
                BntTrocarArma2.Enabled = true;
                comboBox2.Enabled = true;
                btnespecial2.Enabled = false;
                if (NovoJogo.Player2.CoutTurno >= 10)
                    btnespecial2.Enabled = true;
                else
                    btnespecial2.Enabled = false;

            }
        }
        public void AtualizarTela()
        {
            lblArmaAtual1.Text = NovoJogo.Player1.Personagem.ArmaAtual.Nome;
            lblArmaAtual2.Text = NovoJogo.Player2.Personagem.ArmaAtual.Nome;
            try
            {
                Pbar_pontosdeVida1.Value = NovoJogo.Player1.Personagem.PontosdeVida;
            }
            catch (Exception)
            {
                if (Pbar_pontosdeVida1.Value == 0)
                {
                    FrmTerminaLuta fimcombate = new FrmTerminaLuta();
                    this.Hide();
                    fimcombate.Show(Pbar_pontosdeVida2);
                }
            }
            finally
            {
                if (Pbar_pontosdeVida1.Value == 0)
                {
                    FrmTerminaLuta fimcombate = new FrmTerminaLuta();
                    this.Hide();
                    fimcombate.Show(Pbar_pontosdeVida2);
                }
            }

            try
            {
                Pbar_pontosdeVida2.Value = NovoJogo.Player2.Personagem.PontosdeVida;
            }
            catch (Exception)
            {


                if (NovoJogo.Player1.Personagem.PontosdeVida <= 0)
                {
                    FrmTerminaLuta fimcombate = new FrmTerminaLuta(NovoJogo.Player2, NovoJogo.EnderecoImagens);
                    this.Hide();
                    fimcombate.Show();
                }
            }
            finally
            {
                if (NovoJogo.Player2.Personagem.PontosdeVida <= 0)
                {
                    FrmTerminaLuta fimcombate = new FrmTerminaLuta(NovoJogo.Player1, NovoJogo.EnderecoImagens);
                    this.Hide();
                    fimcombate.Show();
                }
            }


            Pbar_Mana1.Value = NovoJogo.Player1.Personagem.PontosdeMana;
            Pbar_Mana2.Value = NovoJogo.Player2.Personagem.PontosdeMana;
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            foreach (var item in NovoJogo.Player1.Personagem.VetItem)
                if (item != null)
                    comboBox1.Items.Add(item);

            foreach (var item in NovoJogo.Player2.Personagem.VetItem)
                if (item != null)
                    comboBox2.Items.Add(item);


            TurnoTela();

        }
       
        private void BntAtacar1_Click_1(object sender, EventArgs e)
        {
            if (NovoJogo.Player1.Personagem.ArmaAtual.EfeitoItem == EnumEfeitoItem.Cura.ToString())
            {
                NovoJogo.Player1.Personagem.CurarPersonagem(NovoJogo.Player1.Personagem.ArmaAtual);
                NovoJogo.Player1.Personagem.RemovePontosMana(NovoJogo.Player1.Personagem.ArmaAtual);
            }
            else
            {
                if (NovoJogo.Player1.Personagem.ArmaAtual.TipoItem == EnumTipoItem.Arma.ToString())
                    NovoJogo.Player1.Personagem.AddPontosMana();
                else
                    NovoJogo.Player1.Personagem.RemovePontosMana(NovoJogo.Player1.Personagem.ArmaAtual);
                NovoJogo.Player2.Personagem.ReceberAtaque(NovoJogo.Player1.Personagem.ArmaAtual);

            }
            if (NovoJogo.Player2.Personagem.PontosdeVida <= 0)
            {
                FrmTerminaLuta terminaluta = new FrmTerminaLuta(NovoJogo.Player1, NovoJogo.EnderecoImagens);
                terminaluta.Show();
            }
            TrocaTurno();
            NovoJogo.Player1.CoutTurno++;
            AtualizarTela();
        }
        private void bntAtacar2_Click_1(object sender, EventArgs e)
        {
            if (NovoJogo.Player2.Personagem.ArmaAtual.EfeitoItem == EnumEfeitoItem.Cura.ToString())
            {
                NovoJogo.Player2.Personagem.CurarPersonagem(NovoJogo.Player2.Personagem.ArmaAtual);
                NovoJogo.Player2.Personagem.RemovePontosMana(NovoJogo.Player2.Personagem.ArmaAtual);
            }
            else
            {
                if (NovoJogo.Player2.Personagem.ArmaAtual.TipoItem == EnumTipoItem.Arma.ToString())
                    NovoJogo.Player2.Personagem.AddPontosMana();
                else
                    NovoJogo.Player2.Personagem.RemovePontosMana(NovoJogo.Player2.Personagem.ArmaAtual);
                NovoJogo.Player1.Personagem.ReceberAtaque(NovoJogo.Player2.Personagem.ArmaAtual);

            }
            if (NovoJogo.Player1.Personagem.PontosdeVida <= 0)
            {
                FrmTerminaLuta terminaluta = new FrmTerminaLuta(NovoJogo.Player2, NovoJogo.EnderecoImagens);
                terminaluta.Show();

            }
            TrocaTurno();
            NovoJogo.Player2.CoutTurno++;
            AtualizarTela();
        }

        private void BntTrocarArma_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
                NovoJogo.Player1.Personagem.ArmaAtual = (Item)comboBox1.SelectedItem;
            TrocaTurno();
            AtualizarTela();
        }

        private void BntTrocarArma2_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem != null)
                NovoJogo.Player2.Personagem.ArmaAtual = (Item)comboBox2.SelectedItem;
            TrocaTurno();
            AtualizarTela();
        }

        private void FrmCombate_Load(object sender, EventArgs e)
        {
            string ImagePath = NovoJogo.EnderecoImagens + NovoJogo.Player1.Personagem.NomeImegem;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Image.FromFile(ImagePath);

            string ImagePath2 = NovoJogo.EnderecoImagens + NovoJogo.Player2.Personagem.NomeImegem;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Image = Image.FromFile(ImagePath2);

        }
        private void btnespecial1_Click(object sender, EventArgs e)
        {
            NovoJogo.Player2.Personagem.ReceberAtaqueEspecial(NovoJogo.Player1.Personagem.ArmaAtual);
            TrocaTurno();
            NovoJogo.Player1.CoutTurno -= 10;
            AtualizarTela();
        }

        private void btnespecial2_Click(object sender, EventArgs e)
        {
            NovoJogo.Player1.Personagem.ReceberAtaqueEspecial(NovoJogo.Player2.Personagem.ArmaAtual);
            TrocaTurno();
            NovoJogo.Player2.CoutTurno -= 10;

            AtualizarTela();
        }
    }
}
