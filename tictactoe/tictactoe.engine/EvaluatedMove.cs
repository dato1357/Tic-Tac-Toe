using System;
using System.Diagnostics;

namespace tictactoe.engine
{
    [DebuggerDisplay("Move{Move}, Score:{Score}")]
    public class EvaluatedMove : IComparable<EvaluatedMove>
    {
        public int Move { get; set; }

        public int Score { get; set; }

        public int CompareTo(EvaluatedMove other)
        {
            if (other.Score > Score) return -1;
            if (other.Score == Score) return 0;
            return 1;
        }
    }
}
