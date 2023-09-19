using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urna
{
    public class Candidato
    {
        //Atributos
        private int numero;
        private string nome;
        private int votos;

        //Propriedades
        public int Numero { get { return numero; } set { numero = value; } }
        public string Nome { get { return nome; } set { nome = value; } }
        public int Votos { get { return votos; } }

        public Candidato(int numero, string nome)
        {
            Numero = numero;
            Nome = nome;
            votos = 0;
        }
        public void AtribuirVoto()
        {
            votos++;
        }

        public void TotalizarVotos()
        {
            Console.WriteLine($"\nNúmero: {Numero}\nNome: {Nome}\nVotos: {Votos}");
        }
    }
}
