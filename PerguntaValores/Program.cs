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
            int.TryParse(raio_str, out raio);
            Console.Write("Escreve a altura -> ");
            string altura_str = Console.ReadLine();
            int altura;
            int.TryParse(altura_str, out altura);
            float pi = 3.1415926f;

            Console.WriteLine($"Volume = {pi * (raio * raio) * altura} \nÁrea de superfície = {2 * pi * raio *(raio + altura)}");

        }
    }
}
