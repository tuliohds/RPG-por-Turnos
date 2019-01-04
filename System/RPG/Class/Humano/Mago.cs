
using RPG.Class.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Mago : Humano
{
    public Mago()
    {
        this.Nome = "Mago";
        this.PontosdeVida = 2500;
        this.PontosdeMana = 100;
        this.ForcaFisica = 40;
        this.ForcaMagica = 100;
        this.PontoAmrmadura = 30;
        this.ResistenciaMagica = 100;
        this.Agilidade = 40;
        this.NomeImegem = "FtoMago.jpg";
        VetItem[0] = new TridenteSagrado();
        VetItem[1] = new Cajado();
        VetItem[3] = new MagiaCura();
        VetItem[4] = new Bio();
        VetItem[5] = new FlamaGelada();
        VetItem[6] = new Intoxicacao();
        VetItem[7] = new Tempestade();
        this.MenorArma();
    }
}

