using System;

namespace ChatGPTMother
{
    class Program
    {
        static void Main(string[] args)
        {
            string question;
            do
            {
                Console.Write("Write something -> ");
                question = Console.ReadLine();


                string response = question switch
                {

                    "How are you?" => response = "I'm fine, thank you dear\n",

                    "What's your name?" => response = "Mum, mother of all moms\n",

                    "What's your mission?" => response = "Hug you until you sleep\n",

                    "What's your hobbies?" => response = "I love to cook delicious meals\n",

                    "EXIT" => response = "Goodbye sweetie\n",

                    _ => "Sorry dear, I'm not that fluent in english, could you repeat please?\n",
                };

                Console.Write(response);
            } while (question != "EXIT");
        }
    }
}
