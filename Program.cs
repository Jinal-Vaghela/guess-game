using System.ComponentModel.Design;

namespace jinal
{
    class jill
    {
        static void Main(string[] args)
        {
            string guess = "";
            string sword = "swapnil";
            int guessnumber = 0;
            int guesslimit = 5;
            bool gusscount = false;
            
            while(guess!=sword && !gusscount)
            { if (guessnumber < guesslimit )
            {
                Console.WriteLine("Enter the squad member");
                guess =Console.ReadLine();
                guessnumber++;

            }
            else
                {
                    gusscount = true;
                }
            }
            if (gusscount)
            {
                Console.WriteLine("You fucked upp!");
            }
            else
            {
                Console.WriteLine("You win!");
            }
        }

    }
}