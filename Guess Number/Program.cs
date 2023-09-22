namespace Guess_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int number = rnd.Next(1, 101);
            bool correct = false;
            int attempt = 0;
            int versuch = 0;
            for (int i = 0; i < 5; i++) ;
            Console.WriteLine("Pick a number between 1 and 100");
            string guess = Console.ReadLine();
            while (!correct && versuch < 1)
            {
                if (!int.TryParse(guess, out attempt))
                { continue; }

                if (attempt > number)  {
                    Console.WriteLine("zu hoch");
                    versuch++;
                    
                }
                if (attempt < number)
                {
                    Console.WriteLine("zu tief");
                    versuch++;
                    
                {
                if (attempt == number) 
                            Console.WriteLine("Dieser Versuch stimmt");
                }
               
                }
            }

        }
    }
}