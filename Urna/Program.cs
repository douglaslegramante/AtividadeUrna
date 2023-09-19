using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urna
{
    public class Program
    {
        static void Main(string[] args)
        {
            Candidato marina = new Candidato(70, "Marina Silva");
            Candidato eneias = new Candidato(40, "Enéias Carneiro");
            Candidato ciro = new Candidato(12, "Ciro Gomes");
            Candidato padre = new Candidato(25, "Padre Kelmon");
            bool continua = true;
            int nulos = 0;
            do
            {
                Console.WriteLine("\t\t---Urna eletrônica--- Vota, vota e confia!");
                Console.WriteLine("\n[12] - Ciro Gomes" +
                    "\n[25] - Padre Kelmon" +
                    "\n[40] - Enéias Carneiro" +
                    "\n[70] - Marina Silva" +
                    "\n[0] - Branco/Nulo");
                Console.Write("\nEscolha uma opção: ");
                int op = int.Parse(Console.ReadLine());                

                switch (op)
                {
                    case 0:
                        nulos++;
                        Console.WriteLine("Voto depositado!");
                        break;
                    case 12:
                        ciro.AtribuirVoto();
                        Console.WriteLine("Voto depositado!");
                        break;
                    case 25:
                        padre.AtribuirVoto();
                        Console.WriteLine("Voto depositado!");
                        break;
                    case 40:
                        eneias.AtribuirVoto();
                        Console.WriteLine("Voto depositado!");
                        break;
                    case 70:
                        marina.AtribuirVoto();
                        Console.WriteLine("Voto depositado!");
                        break;
                    default:
                        Console.WriteLine("Opção Inválida");
                        break;
                }
                Console.Write("\nDigite [1] para realizar outro voto: ");
                char cond = char.Parse(Console.ReadLine());
                if (cond != '1')
                {
                    continua = false;
                }
                Console.Clear();

            }while(continua);
            Console.Clear();
            Console.WriteLine("\t\t---Totaliza Votos---");
            ciro.TotalizarVotos();
            eneias.TotalizarVotos();
            padre.TotalizarVotos();
            marina.TotalizarVotos();
            Console.WriteLine("\nVotos Brancos/Nulos: "+nulos);
        }
    }
}
