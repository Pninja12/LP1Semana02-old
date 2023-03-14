using System;

namespace PerguntaValores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escreve o raio -> ");
            string raio_str = Console.ReadLine();
            int raio;
            int.TryParse(raio_str, out raio);////tenta transformar a "raio_str" numa variável de tipo inteiro e dar o volar a "raio"
            Console.Write("Escreve a altura -> ");
            string altura_str = Console.ReadLine();
            int altura;
            int.TryParse(altura_str, out altura);//tenta transformar a "altura_str" numa variável de tipo inteiro e dar o volar a "altura"
            //float pi = 3.1415926f;

            Console.WriteLine($"Volume = {Math.PI  *  Math.Pow(raio,2) * altura} \nÁrea de superfície = {2 * Math.PI * raio *(raio + altura)}");
            //                           Vai buscar     Vais buscar a 
            //                           o número       variável "raio"
            //                           de Pi          e a multiplica 2 vezes

        }
    }
}
