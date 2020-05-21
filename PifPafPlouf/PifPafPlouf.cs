using System;

namespace PifPafPloufProject
{
    public class PifPafPlouf
    {
        public string SuitElementFromNumber(int number)
        {

            if (number % 3 == 0)
                return "Pif";
            if (number % 4 == 0)
                return "Paf";
            if (number % 12 == 0)
                return "Plouf";
            return number.ToString();
        }


    }
}