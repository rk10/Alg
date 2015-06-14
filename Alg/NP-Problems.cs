using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alg
{
    public struct Thing 
    {
        public int cost;
        public int volume;
    }

    public class HaversackTask 
    {
        int[,] CostGraph;
        Thing[] Things;

        public void InitCostGraph(Thing[] things, int haversackVolume) 
        {
            CostGraph = new int[haversackVolume + 1, things.Length + 1];
            Things = things;

            for(int i = 0; i < things.Length + 1; i++)
                CostGraph[i,0] = 0;
            for(int i = 0; i < haversackVolume + 1; i++)
                CostGraph[0,i] = 0;

            for (int n = 0; n < things.Length + 1; ++n)
                for (int v = 0; v < haversackVolume + 1; ++v)
                    if (v >= things[n - 1].volume)
                        CostGraph[v, n] = 
                            Math.Max(CostGraph[v, n - 1], CostGraph[v - things[n - 1].volume, n - 1] + things[n - 1].cost); 
        }

        public List<Thing> findThingsSet() 
        {
            if (CostGraph == null)
                return null;

            int maxVolumeIndex = 0;
            int maxNumThingIndex = 0;

            for(int i = 0; i < CostGraph.GetLength(0); i++)
                for (int j = 0; j < CostGraph.GetLength(1); j++)
                    if(CostGraph[i,j] > CostGraph[maxVolumeIndex, maxNumThingIndex]) 
                    {
                        maxVolumeIndex = i;
                        maxNumThingIndex = j;
                    }

            var path = new List<Thing>();
            findThingsSet(path, maxVolumeIndex, maxNumThingIndex);
            return path;
        }

        private void findThingsSet(List<Thing> path, int maxVolumeIndex, int maxNumThingIndex) 
        {
            if (CostGraph[maxNumThingIndex, maxVolumeIndex] == 0)
                return;

            if (CostGraph[maxNumThingIndex - 1, maxVolumeIndex] == CostGraph[maxNumThingIndex, maxVolumeIndex])
                findThingsSet(path, maxVolumeIndex, maxNumThingIndex - 1);
            else 
            {
                path.Add(Things[maxNumThingIndex - 1]);
                findThingsSet(path, maxVolumeIndex - Things[maxNumThingIndex - 1].volume, maxNumThingIndex - 1);
            }
        } 
    }
}
