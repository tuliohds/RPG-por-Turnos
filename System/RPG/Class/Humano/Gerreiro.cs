
using RPG.Class.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Gerreiro : Humano
{
    public Gerreiro()
    {
        this.Nome = "Guerreiro";
        this.PontosdeVida = 4000;
        this.PontosdeMana = 30;
        this.ForcaFisica = 100;
        this.ForcaMagica = 20;
        this.PontoAmrmadura = 80;
        this.ResistenciaMagica = 20;
        this.Agilidade = 50;
        this.NomeImegem = "FtoGuerreiro.jpg";




        VetItem[0] = new Porrete();
        VetItem[1] = new EspadaBarroca();
        VetItem[2] = new Tempestade();//Olhar nas especificações
        this.MenorArma();
    }
}

