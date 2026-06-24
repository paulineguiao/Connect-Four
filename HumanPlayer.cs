using System;
using System.Collections.Generic;
using System.Text;

namespace ConnectFour
{
    public class HumanPlayer : Player
    {
        public HumanPlayer(string name, char symbol) : base(name, symbol) { }

        public override int ChooseColumn()
        {
            while (true)
            {
                Console.Write($"{Name} ({Symbol}), enter column (1-7): ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int column) && column >= 1 && column <= 7)
                {
                    return column - 1;
                }
                Console.WriteLine("Invalid entry. Please pick a number from 1 to 7.");
            }
        }
    }
}
