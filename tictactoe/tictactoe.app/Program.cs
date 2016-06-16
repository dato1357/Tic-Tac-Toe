using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tictactoe.engine;

namespace tictactoe.app
{
    class Program
    {
        static void Main(string[] args)
        {
            var field = new Field();

            while (!field.GameOver)
            {
                Console.WriteLine(field.ToString());
                field.UserMove();
                field.CPUMove();
            }

            Console.WriteLine(field.ToString());
        }
    }
}
