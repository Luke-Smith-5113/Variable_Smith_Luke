using System;

namespace Variables_Smith_Luke
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring and initializing variables
            int faveNumber;
            bool isJumping = false, isRunning = false;
            float importantFloat;
            faveNumber = 6;
            importantFloat = 729.21f;
            const double finalGrade = 100.00;

            //printing all variables in seperate lines
            Console.WriteLine(faveNumber);
            Console.WriteLine(isJumping);
            Console.WriteLine(isRunning);
            Console.WriteLine(importantFloat);
            Console.WriteLine(finalGrade);
        }
    }
}
