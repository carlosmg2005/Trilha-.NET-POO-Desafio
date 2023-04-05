using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Trilha.NET_POO_Desafio.Models;

namespace Trilha.NET_POO_Desafio
{
    public class Program
    {
        static void Main(string[] args)
        {
            Nokia nokia = new Nokia("Nokia", "Lumia 950", "12456789", 128);
            nokia.MostrarDetalhes();
            nokia.ReceberLigacao();
            nokia.Ligar();
            nokia.InstalarAplicativo("Instagram");

            Iphone iphone = new Iphone("Iphone", "8 Plus", "987654321", 256);
            Console.WriteLine("---------------------------------------------");
            iphone.MostrarDetalhes();
            iphone.ReceberLigacao();
            iphone.Ligar();
            iphone.InstalarAplicativo("WhatsApp");

            Console.ReadKey();

        }
    }
}
