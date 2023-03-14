using System;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escreve a quantidade -> ");
            string quant_str = Console.ReadLine();
            int quant;
            int.TryParse(quant_str, out quant);

            Console.Write("Escreve o carácter -> ");
            string char_str = Console.ReadLine();

            for (int i = 1; i < (quant + 1); i ++) //corre em um loop que só acaba quando atingir o número dado pelo utilizador
            {
                for (int j = 0; j < i; j++)//corre em loop de forma a mostrar a variável "char_str" as vezes necessárias. 
                //quando acaba um loop, o próximo vai ser rodado mais uma vez que o anterior por causa do "j < i" já que "i" está sempre a crescer e o "j" volta sempre a zero
                {
                    Console.Write(char_str);
                }
                Console.Write("\n");
            }

        }
    }
}
