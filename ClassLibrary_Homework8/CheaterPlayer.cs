using System;
using System.Collections.Generic;

namespace ClassLibrary_Homework8
{
    public class CheaterPlayer : BasePlayer
    {
        private List<int> NotUsedNumbers;
        public override int GuessTheWeight()
        {
            Random random = new Random();
            int result = random.Next(40, 141);
            while (NotUsedNumbers.Contains(result))
            {
                result = random.Next(40, 141);
            }
            return result;
        }
        public CheaterPlayer(string name,List<int> numbers)
        {
            Name = name;
            NotUsedNumbers = numbers;
        }
    }
}
