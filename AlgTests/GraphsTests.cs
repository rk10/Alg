using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Alg;

namespace AlgTests
{
    [TestClass]
    public class GraphsTests
    {
        public ArcInfo[][] GetTestGraph() 
        {
            return new ArcInfo[5][5]
            {
                { new ArcInfo(1, 1), new ArcInfo(1, 1), new ArcInfo(1, 1), new ArcInfo(1, 1), new ArcInfo(1, 1) },
                { new ArcInfo(1, 1), new ArcInfo(1, 1), new ArcInfo(1, 1), new ArcInfo(1, 1), new ArcInfo(1, 1) },
                { new ArcInfo(1, 1), new ArcInfo(1, 1), new ArcInfo(1, 1), new ArcInfo(1, 1), new ArcInfo(1, 1) },
                { new ArcInfo(1, 1), new ArcInfo(1, 1), new ArcInfo(1, 1), new ArcInfo(1, 1), new ArcInfo(1, 1) },
                { new ArcInfo(1, 1), new ArcInfo(1, 1), new ArcInfo(1, 1), new ArcInfo(1, 1), new ArcInfo(1, 1) }
            }; 
        }

        [TestMethod]
        public void FordFalkersonTest()
        {
            
        }
    }
}
