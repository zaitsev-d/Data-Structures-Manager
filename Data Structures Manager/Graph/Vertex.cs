using System;
using System.Collections.Generic;

namespace Graphs.Structure
{
    class Vertex
    {
        public int Number { get; set; }

        public Vertex(int number)
        {
            Number = number;
        }

        public override string ToString()
        {
            return Number.ToString();
        }
    }
}
