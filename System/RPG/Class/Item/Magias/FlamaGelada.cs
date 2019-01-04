using System;

namespace RPG.Class.Item
{
    public class FlamaGelada :Magia
    {

        public override int Dano { get { return this.dano; } set { this.dano = value; } }
        private int dano;
        public override string Nome { get { return this.nome; } set { this.nome = value; } }
        private string nome;
        public override int Cura { get { return this.cura; } set { this.cura = value; } }
        private int cura;
        public override int GastoMana { get { return this.gastomana; } set { this.gastomana = value; } }
        private int gastomana;
        public override string EfeitoItem { get { return RPG.Class.Enum.EnumEfeitoItem.Dano.ToString(); } set { } }

        public FlamaGelada()
        {
            this.Nome = "Flama Gelada";
            this.Dano = 320;
            this.Cura = 0;
            this.GastoMana = 14;
        }
    }
}
