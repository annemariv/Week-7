using System;

namespace UserNameDataTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnime
            //programm küsib kasutajal sisestada numbrit 1-3
            //kntrollin, mis ta valis
            // 3 funktsiooni:
            //kui kasutaja sisestab '1', siis kuvatakse kasutaja eesnime tagurpidi 
            //kui kasutaja valib '2', siis kuvatakse eesnime esimest tähte
            //kui valib '3', siis kuvatakse kasutaja eesnime pikkust

            Console.WriteLine("Sisesta oma eesnimi:");
            string userName = Console.ReadLine();
            
            Console.WriteLine("Sisesta number 1-3.");
            char userNumber = Convert.ToChar(Console.ReadLine());


            switch (userNumber)
            {
                case '1':
                    UserNameReversed(userName);
                    break;

                case '2':
                    UserNameChar(userName);
                    break;

                case '3':
                    UserNameLength(userName);
                    break;
            }
        }


        public static void UserNameReversed(string userInput)
        {
            Console.Write("Sinu nimi tagurpidi: ");
            for (int i = userInput.Length - 1; i >= 0; i--)
            {

                Console.Write(userInput[i]);
            }
        }
            public static void UserNameChar(string userInput)
            {
                Console.WriteLine($"Sinu nime esimene täht on: {userInput[0]}");
            }

            public static void UserNameLength(string userInput)
            {
                Console.WriteLine($"Sinu nime pikkus on: {userInput.Length} sümbolit.");
            }

        

    }
}      