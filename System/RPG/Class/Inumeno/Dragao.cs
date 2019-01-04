
using RPG.Class.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Dragao : Inumano
{
    public Dragao()
    {
        this.Nome = "Dragão";
        this.PontosdeVida = 3000;
        this.PontosdeMana = 40;
        this.ForcaFisica = 100;
        this.ForcaMagica = 20;
        this.PontoAmrmadura = 100;
        this.ResistenciaMagica = 50;
        this.Agilidade = 80;
        this.NomeImegem = "FtoDragao.jpg";
        VetItem[0] = new HalitoDeFogo();
        VetItem[1] = new GarraLetal();

        this.MenorArma();
    }
}

