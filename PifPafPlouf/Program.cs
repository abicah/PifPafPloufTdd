using System;

namespace PifPafPloufProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int minNumber = 1;
            int maxNumber = 180;
            PifPafPlouf pifPafplouf = new PifPafPlouf();
            string suit = pifPafplouf.SuitBetween2Number(minNumber, maxNumber);
            Console.WriteLine(suit);
        }
    }
}
