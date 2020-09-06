using System;

namespace ClassLibrary_Homework8
{
    public class OrdinaryPlayer : BasePlayer
    {
        public override int GuessTheWeight()
        {
            Random random = new Random();
            return random.Next(40, 141);
        }
        public OrdinaryPlayer(string name)
        {
            Name = name;
        }
    }
}
