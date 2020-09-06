using System.Collections.Generic;

namespace ClassLibrary_Homework8
{
    public class UberCheaterPlayer : BasePlayer
    {
        private List<int> NotUsedNumbers;
        private int CurrentNumber = 40;
        public override int GuessTheWeight()
        {
            while (NotUsedNumbers.Contains(CurrentNumber))
            {              
                CurrentNumber += 1;
            }
            return CurrentNumber++;
        }
        public UberCheaterPlayer(string name, List<int> numbers)
        {
            Name = name;
            NotUsedNumbers = numbers;
        }
    }
}
