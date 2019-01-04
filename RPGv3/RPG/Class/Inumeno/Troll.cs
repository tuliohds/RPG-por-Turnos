
using RPG.Class.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Troll : Inumano
{
    public Troll()
    {
        this.Nome = "Troll";
        this.PontosdeVida = 2800;
        this.PontosdeMana = 20;
        this.ForcaFisica = 100;
        this.ForcaMagica = 20;
        this.PontoAmrmadura = 100;
        this.ResistenciaMagica = 20;
        this.Agilidade = 20;
        this.NomeImegem = "FtoTroll.jpg";

        VetItem[0] = new Porrete();
        VetItem[1] = new Cajado();
        VetItem[2] = new Intoxicacao();

        this.MenorArma();
    }
}

