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

            //Array with shortest distance from source to every other node.
            double[] dist = new double[vertex.NumShapes];
            //Collection of nodes that need to be examined.
            bool[] Q = new bool[vertex.NumShapes];
            //Array pointing to the previous node on the route back to the source.
            int[] prev = new int[vertex.NumShapes];
            //Variable to identify the last examined node.
            int active = new int();
            int pos = new int();
            int checker = new int();
            //A list to keep the stops on the final route.
            List<int> route = new List<int>();

            //Loop to make the entire algorithm run until the queue of destinations is empty.
            while (Destinations.Dest != null)
            {
                //Loads a destination from the queue and creates an int to keep the actual node chosen as the endpoint of the route.
                d = Destinations.Dest.Dequeue();

                //Setting the distance to all nodes to infinity and adding them all to Q.
                for (int i = 0; i < vertex.NumShapes; i++)
                {
                    //Sets distance to all nodes to infinity.
                    dist[i] = int.MaxValue;
                    //Equivalent to putting all nodes in Q.
                    Q[i] = false;
                }

                //Making it so that there is to node before the source and the distance to the source is 0.
                prev[Convert.ToInt32(vertex.get_CellValue(1, s))] = -1;
                dist[Convert.ToInt32(vertex.get_CellValue(1, s))] = 0;
                Q[Convert.ToInt32(vertex.get_CellValue(1, s))] = true;
                //Sets the first node to check as the source.
                active = s;

                //Loop that runs until it checks a node that has the desired "desttype".
                while (Convert.ToString(vertex.get_CellValue(2, active)) != d)
                {
                    for (int v = 0; v < edge.NumShapes; v++)
                    {
                        //Checks whether nodes are at the edge of our shortest spanning tree by checking if source and target are in Q.
                        if (Q[Convert.ToInt32(edge.get_CellValue(1, v))] == true && Q[Convert.ToInt32(edge.get_CellValue(2, v))] == false)
                        {
                            //Compares new distance to visited nodes to previous shortest distance, and updates if the new one is shorter.
                            if (Convert.ToDouble(edge.get_CellValue(3, v)) + dist[Convert.ToInt32(edge.get_CellValue(1, v))] < dist[Convert.ToInt32(edge.get_CellValue(2, v))])
                            {
                                dist[Convert.ToInt32(edge.get_CellValue(2, v))] = Convert.ToDouble(edge.get_CellValue(3, v)) + dist[Convert.ToInt32(edge.get_CellValue(1, v))];
                            }
                        }
                        //Same as the above, only with source and target switched.
                        if (Q[Convert.ToInt32(edge.get_CellValue(2, v))] == true && Q[Convert.ToInt32(edge.get_CellValue(1, v))] == false)
                        {
                            //Compares new distance to visited nodes to previous shortest distance, and updates if the new one is shorter.
                            if (Convert.ToDouble(edge.get_CellValue(3, v)) + dist[Convert.ToInt32(edge.get_CellValue(2, v))] < dist[Convert.ToInt32(edge.get_CellValue(1, v))])
                            {
                                dist[Convert.ToInt32(edge.get_CellValue(1, v))] = Convert.ToDouble(edge.get_CellValue(3, v)) + dist[Convert.ToInt32(edge.get_CellValue(2, v))];
                            }
                        }
                    }

                    pos = 0;
                    for (int j = 0; j < dist.Length; j++)
                    {
                        //Finds next node to check by finding the shorest distance.
                        if (dist[Convert.ToInt32(vertex.get_CellValue(1, j))] < dist[pos] && Q[Convert.ToInt32(vertex.get_CellValue(1, j))] != true) { pos = j; }
                    }
                    active = pos;
                    //"Removes the checked node from Q" by switching the bool, adding it to the shortest spanning tree.
                    Q[Convert.ToInt32(vertex.get_CellValue(1, active))] = true;
                    //Sets pointer from new node to the previous one.
                    pos = 0;
                    for (int l = 0; l < dist.Length; l++)
                    {
                        //Gets previous node by finding the one nearest the active node. This finds the smallest 
                        if (dist[Convert.ToInt32(vertex.get_CellValue(1, l))] - Convert.ToInt32(vertex.get_CellValue(1, active)) < dist[pos] && l != active)
                        {
                            if (Convert.ToInt32(edge.get_CellValue(1, l)) == active || Convert.ToInt32(edge.get_CellValue(2, l)) == active) { pos = l; }
                        }
                    }

                    checker = active;
                    if (Convert.ToString(vertex.get_CellValue(2, active)) == d) 
                    { 
                        while(Convert.ToInt32(vertex.get_CellValue(1, checker)) != s)
                        {
                            for (int k = 0; k < prev.Length; k++)
                            {
                                if (prev[k] == prev[Convert.ToInt32(vertex.get_CellValue(1, checker))])
                                {
                                    route.Add(prev[k]);
                                    checker = prev[k]; //Forkert! Det giver id, skal bruge index.
                                }
                            }
                        }
                        s = active; 
                    }
                }
            }
        }
    }
}
