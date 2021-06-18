using Bic_Grafite;
using System;

namespace Bic_Canetas
{
    class Program
    {
        static void Main(string[] args)
        {
            Lápis pencil = new Lápis();
            pencil.Modelo = "Infantil";
            pencil.TemBorracha = true;
            pencil.TamanhoEmCm = 15;
            pencil.ÉEstampada = true;

            Lapiseira pTool = new Lapiseira();
            pTool.CalibreGrafite = 1.7f;
            pTool.ComBorracha = true;
            pTool.Estampada = true;
            pTool.Estampa = "Bic - Edição Especial 50 Anos";
            pTool.TamanhoGrafite = 5;

            Caneta pen = new Caneta();
            pen.Cor = "Preto";
            pen.DuasCores = false;
            pen.EspessuraPonta = 0.2M;
            pen.NumeroCargas = 1;

            Console.WriteLine(pTool.Estampa);

        }
    }
}
