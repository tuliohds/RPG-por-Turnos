
using System;

namespace RPG.Class.Item
{
    public abstract class Item
    {
        public abstract string Nome { get; set; }
        public abstract int Dano { get; set; }
        public abstract int Cura { get; set; }
        public abstract int GastoMana { get; set; }
        
        public abstract string TipoItem { get; set; }
        public abstract string EfeitoItem { get; set; }
      
    }
}

