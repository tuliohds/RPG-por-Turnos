
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG.Class.Item
{
    public abstract class Arma : Item
    {
        public override int Cura { get { return 0; } }
        public override int GastoMana { get { return 0; } }
        public override string TipoItem { get { return RPG.Class.Enum.EnumTipoItem.Arma.ToString(); } set { } }
        public override string EfeitoItem { get { return RPG.Class.Enum.EnumEfeitoItem.Dano.ToString(); } set { } }
    }
}

