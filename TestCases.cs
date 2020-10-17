using System;
using System.Collections.Generic;
using System.Text;

namespace ReversePolishNotation
{
    class TestCases
    {
        private string[] Cases = {
            "→r", "sp", "∨q", "p", "q→r", "r∨s"
        };

        public string randomCase()
        {
            Random rng = new Random();
            return Cases[rng.Next(0, Cases.Length)];
        }
    }
}