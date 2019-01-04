
using RPG.Class.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Paladino : Humano
{
    public Paladino()
    {
        this.Nome = "Paladino";
        this.PontosdeVida = 3200;
        this.PontosdeMana = 80;
        this.ForcaFisica = 60;
        this.ForcaMagica = 60;
        this.PontoAmrmadura = 60;
        this.ResistenciaMagica = 60;
        this.Agilidade = 60;
        this.NomeImegem = "FtoPaladino.jpg";


        VetItem[0] = new Porrete();
        VetItem[1] = new EspadaBarroca();
        VetItem[2] = new Tempestade();
   
        this.MenorArma();
    }
}

