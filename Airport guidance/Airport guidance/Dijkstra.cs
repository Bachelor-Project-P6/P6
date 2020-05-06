using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AxMapWinGIS;
using MapWinGIS;

namespace Airport_guidance.Properties
{
    class Dijkstra
    {
        int s = SetLocationMap.Loc;
        string d = null;
        public void buildgraph()
        {
            Shapefile edge = new Shapefile();
            edge.Open("..\\..\\shapefiles\\navlines.shp");

            Shapefile vertex = new Shapefile();
            vertex.Open("..\\..\\shapefiles\\navnodes.shp");

            while (Destinations.Dest.Count != 0) ;

            //Making a graph to populate with vertices
            Graph<object> network = new Graph<object>();

            for (int i = 0; i < vertex.NumShapes; i++)
            {
                network.AddNode(vertex.get_CellValue(1, i));
            }
            for (int j = 0; j < edge.NumShapes; j++)
            {
                //Defines neighbors in the graph by generating new nodes (vertices) as new GraphNodes, and defines the "cost" of going between them as the Int. The cells loaded are "source", "target" and "length".
                { network.AddUndirectedEdge(new GraphNode<object>(edge.get_CellValue(1, j)), new GraphNode<object>(edge.get_CellValue(2, j)), Convert.ToInt32(edge.get_CellValue(3, j))); };
            }
            //With this the routing network has been represented in the graph.
        }

        //Method uses the graph defined above, a source (initially the device location) and destinations from the queue Dest.
        public void dijkstra(Graph<object> network, int s, string d)
        {
            //Loads a destination from the queue and creates an int to keep the actual node chosen as the endpoint of the route.
            d = Destinations.Dest.Dequeue();
            int end;

            double[] dist = new double[network.Count];
            SortedSet<int> Q = new SortedSet<int>();
            SortedSet<int> S = new SortedSet<int>();
            int[] prev = new int[network.Count];

            for (int i = 0; i < network.Count; i++)
            {
                dist[i] = int.MaxValue;
                Q.Add(Convert.ToInt32(network.Nodes.FindByValue(i)));
            }
            prev[0] = -1;
            dist[s] = 0;
            S.Add(s);

            for (int i = 0; i < network.Count; i++)
            {
                int u = Q.Min();
                foreach (NodeList<object> neighbors in )
                {

                }
            }

            s = end;
        }
    }
}
