using System;
using System.Collections.Generic;
using System.Text;

namespace ConnectFour
{
    public abstract class Player
    {
        public string Name { get; set; }
        public char Symbol { get; set; }

        public Player(string name, char symbol)
        {
            Name = name;
            Symbol = symbol;
        }

        // Each player must choose a column
        public abstract int ChooseColumn();
    }
}
