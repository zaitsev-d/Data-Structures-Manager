using System;
using System.Collections.Generic;

namespace Graphs.Structure
{
    class Graph
    {
        List<Vertex> V = new List<Vertex>();
        List<Edge> E = new List<Edge>();

        public int VertexCount => V.Count;
        public int EdgeCount => E.Count;

        public void Add_Vertex(Vertex vertex)
        {
            V.Add(vertex);
        }

        public void Add_Edge(Vertex from, Vertex to)
        {
            var edge = new Edge(from, to);
            E.Add(edge);
        }

        public int[,] GetMatrix()
        {
            var matrix = new int[V.Count, E.Count];

            foreach(var edge in E)
            {
                var row = edge.From.Number - 1;
                var column = edge.To.Number - 1;

                matrix[row, column] = edge.Weight;
            }

            return matrix;
        }

        public List<Vertex> GetVertexList(Vertex vertex)
        {
            var result = new List<Vertex>();

            foreach(var edge in E)
            {
                if(edge.From == vertex)
                {
                    result.Add(edge.To);
                }
            }

            return result;
        }
    }
}
