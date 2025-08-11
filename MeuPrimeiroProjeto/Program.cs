using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuPrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Olá, Mundo!");
            Console.WriteLine("meu nome é Edson");
            Console.WriteLine("Estou aprendendo C#");
            int idade=22;
            Console.WriteLine("minha idade é " + idade);
            Console.WriteLine("Estou animado para aprender mais!");
            string Linguagem = "C#";
            Console.WriteLine("Estou aprendendo a linguagem " + Linguagem);

            //double distancia = 10.5;
            //long volume = 1000000L;
            //Console.WriteLine(distancia + " Km do seu sonho!");
            //Console.WriteLine(volume + " que grande!");

            //Console.WriteLine("Essa é a primeira linha!");
            //Console.Write("Esta é a");
            //Console.Write(" ");
            //Console.Write("segunda Linha!");

            String nome;
            nome = "Edson";

            int qntMensagens;
            qntMensagens = 5;

            decimal temperatura;
            temperatura = 25.5M;

            string texto = "Olá," + nome + "! Você tem " + qntMensagens + " mensagens na sua caixa de entrada. " + "A temperatura está " + temperatura + " Graus Celsius";
            
            Console.WriteLine(texto);
        }
    }
}
