using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alg
{
    struct Edge 
    {
        public int a, b, cost;
    }

    class Graphs
    {
        public static int[] FordBellman( Edge[] edges, int v, int n, ref int[] path )
        {
            int[] lengths = new int[n];
            for (int i = 0; i < n; i++)
                lengths[i] = int.MaxValue;
            lengths[v] = 0;

            for(int i = 0; i < n - 1; i++)
            {
                bool change = false;
                for(int j = 0; j < edges.Length; j++)
                    if( lengths[edges[j].b] > lengths[edges[j].a] + edges[j].cost )
                    {
                        change = true;
                        path[edges[j].b] = edges[j].a;
                        lengths[edges[j].b] = lengths[edges[j].a] + edges[j].cost;
                    }
                if(!change)
                    break;
            }

            return lengths;
        } 
    }
    
}
