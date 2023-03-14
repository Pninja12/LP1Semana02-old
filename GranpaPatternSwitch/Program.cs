using System;

namespace GranpaPatternSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write something -> ");
            string question = Console.ReadLine();


            string response = question switch
            {
                "How are you?" => response = "I'm fine, thank you",

                "What's your name?" => response = "Gran'pa",

                "What's your mission?" => response = "Give love to everyone",

                _ => "Carambolas, ainda não sei essa(s) palavra(s)",
            };

            Console.Write(response);
        }
    }
}
