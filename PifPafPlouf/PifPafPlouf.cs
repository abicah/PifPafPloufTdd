using System;

namespace PifPafPloufProject
{
    public class PifPafPlouf
    {
       public string SuitElementFromNumber(int number)
            => (number % 3, number % 4) switch
            {
            (0, 0) => "Plouf",
            (0, _) => "Pif",
            (_, 0) => "Paf",
            _ => number.ToString()
            };
                
                
        public string SuitBetween2Number(int minNumber, int maxNumber)
        {
            StringBuilder builder = new();
            foreach (var item in Enumerable.Range(minNumber, maxNumber - minNumber + 1))
              builder.Append(PifPafPlouf(item));
            
            return builder.ToString();
        }
    }
}
