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
        
        public void dijkstra(int s, string d)
        {
            //Loading the graph with vertices and edges.
            Shapefile edge = new Shapefile();
            edge.Open("..\\..\\shapefiles\\navlines.shp");
            Shapefile vertex = new Shapefile();
            vertex.Open("..\\..\\shapefiles\\navnodes.shp");

            //Loads a destination from the queue and creates an int to keep the actual node chosen as the endpoint of the route.
            d = Destinations.Dest.Dequeue();
            int end;

            //Array with shortest distance from source to every other node.
            double[] dist = new double[vertex.NumShapes];
            //Collection of nodes that need to be examined.
            List<int> Q = new List<int>();
            //Collection of nodes that has already been examined
            List<int> S = new List<int>();
            //Array pointing to the previous node on the route back to the source.
            int[] prev = new int[vertex.NumShapes];
            //Variable to identify the last examined node.
            int active = new int();

            //Setting the distance to all nodes to infinity and adding them all to Q.
            for (int i = 0; i < vertex.NumShapes; i++)
            {
                dist[i] = int.MaxValue;
                Q.Add(Convert.ToInt32(vertex.get_CellValue(1, i)));
            }

            //Making it so that there is to node before the source and the distance to the source is 0.
            prev[Convert.ToInt32(vertex.get_CellValue(1, s))] = -1;
            dist[Convert.ToInt32(vertex.get_CellValue(1, s))] = 0;
            active = Convert.ToInt32(vertex.get_CellValue(1, s));

            while (Q != null)
            {
                for (int v = 0; v < edge.NumShapes; v++) 
                {
                    //Finds neighbors of active node.
                    if ((Convert.ToInt32(edge.get_CellValue(1, v))) == active)
                    {
                        //Skal have Q til at returnere nabo til "active"
                        int u = Q.Min();

                        S.Add(Convert.ToInt32(vertex.get_CellValue(1, u)));
                        double alt = Convert.ToDouble(edge.get_CellValue(3, v)) + dist[u];
                        if (alt < dist[v])
                        {
                            dist[v] = alt;
                        }
                    } 
                    else if ((Convert.ToInt32(edge.get_CellValue(2, v))) == active)
                    {
                        int u = Q.Min();

                        S.Add(Convert.ToInt32(vertex.get_CellValue(1, u)));
                        double alt = Convert.ToDouble(edge.get_CellValue(3, v)) + dist[u];
                        if (alt < dist[v])
                        {
                            dist[v] = alt;
                        }
                    }
                }

                s = end;
                end = d;
            }
        }
    }
}
