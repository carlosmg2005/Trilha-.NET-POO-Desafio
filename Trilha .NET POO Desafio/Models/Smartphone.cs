using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trilha.NET_POO_Desafio.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Modelo { get; set; }
        public string IMEI { get; set; }
        public int Memoria { get; set; }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo= modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...\n");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...\n");
        }

        public void MostrarDetalhes()
        {
            Console.WriteLine();
            Console.WriteLine(Numero);
            Console.WriteLine(Modelo);
            Console.WriteLine(IMEI);
            Console.WriteLine(Memoria);
            Console.WriteLine();
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}
