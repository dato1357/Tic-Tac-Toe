using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tictactoe.engine
{
    public static class Extensions
    {
        public static string AsString(this Cell cell)
        {
            if (cell == Cell.X) return "x";
            if (cell == Cell.O) return "O";
            return "_";
        }

        public static Cell Reverse(this Cell cell)
        {
            if (cell == Cell.X) return Cell.O;
            if (cell == Cell.O) return Cell.X;
            throw new Exception("shecdoma");
        }

      
    }
}
