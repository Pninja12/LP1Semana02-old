using System;

namespace ManipulaVar
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine(); //pede um número(tipo string) à consola
            int Number;

            bool NumberVerification= int.TryParse(str, out Number); //transforma essa número(tipo string) em um número inteiro

            Number++; //adiciona 1 ao número
            Console.WriteLine(Number); //foi adicionado fora porque adiciona 1 ao número mas não mostra de imediato
            --Number; //retira 1 ao número
            Console.WriteLine(--Number); //foi retirado uma segunda vez porque o número voltou ao normal, sendo assim para ser menor tive que retirar mais uma vez
        }
    }
}
