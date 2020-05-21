using System;

namespace PifPafPloufProject
{
    public class PifPafPlouf
    {
        public string SuitElementFromNumber(int number)
        {
            if (number % 12 == 0)
                return "Plouf";
            if (number % 3 == 0)
                return "Pif";
            if (number % 4 == 0)
                return "Paf";

            return number.ToString();
        }

        public string SuitBetween2Number(int minNumber, int maxNumber)
        {
            string suit = "";
            for (int currentNumber = minNumber; currentNumber <= maxNumber; currentNumber++)
            {
                suit += SuitElementFromNumber(currentNumber);
            }
            return suit;
        }
    }
}