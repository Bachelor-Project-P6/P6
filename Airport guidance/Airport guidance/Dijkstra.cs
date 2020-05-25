using System;
using System.Collections.Generic;
using MapWinGIS;

namespace Airport_guidance
{
    public class Dijkstra
    {
        public static string d = null;

        public static class Route
        {
            public static Queue<int> eroute { get; set; } = new Queue<int>();
        }
        public static void dijkstra(int s, Queue<string> dest)
        {
            //Loading the graph with vertices and edges.
            Shapefile edge = new Shapefile();
            edge.Open("..\\..\\shapefiles\\navlines.shp");
            Shapefile vertex = new Shapefile();
            vertex.Open("..\\..\\shapefiles\\navnodes.shp");

            //To facilitate faster processing by accessing the shapefile databases as few times as possible,
            //all required values are loaded into arrays.
            int[] vid = new int[vertex.NumShapes + 1]; //Vertex id
            for (int i = 0; i < vid.Length; i++) { vid[i] = Convert.ToInt32(vertex.get_CellValue(1, i)); }
            int[] eid = new int[edge.NumShapes + 1]; //Edge id
            for(int i = 0; i < eid.Length; i++) { eid[i] = Convert.ToInt32(edge.get_CellValue(0, i)); }
            double[] length = new double[eid.Length]; //Edge length
            for (int i = 0; i < length.Length; i++) { length[i] = Convert.ToDouble(edge.get_CellValue(3, i)); }
            string[] type = new string[vid.Length]; //Vertex desttype
            for (int i = 0; i < type.Length; i++) { type[i] = Convert.ToString(vertex.get_CellValue(7, i)); }    

            //Source and target pairs are stored as a two-tuple.
            Tuple<int, int>[] terminals = new Tuple<int, int>[eid.Length]; //Edge source and target
            for (int i = 0; i < eid.Length; i++) { terminals[i] = new Tuple<int, int>
                    (Convert.ToInt32(edge.get_CellValue(1, i)), Convert.ToInt32(edge.get_CellValue(2, i))); }

            //Array with shortest distance from source to every other node.
            double[] dist = new double[vid.Length];
            //Collection of nodes that need to be examined.
            bool[] Q = new bool[vid.Length];
            //Array pointing to the previous node on the route back to the source.
            int[] prev = new int[vid.Length];
            //Stack for reversing the order of stops on the route, since they will initially be ordered end to start.
            Stack<int> temp = new Stack<int>();
            //A list to keep the stops on the final route.
            List<int> vroute = new List<int>();
            //A queue for the lines of the route.

            //Loop to make the entire algorithm run until the queue of destinations is empty.
            while (Destinations.Dest.Count != 0)
            {
                //Loads a destination from the queue.
                d = Destinations.Dest.Dequeue();

                //Setting the distance to all nodes to infinity and adding them all to Q.
                for (int i = 0; i < vid.Length; i++)
                {
                    //Reset the shortest spanning tree.
                    prev[i] = 0;
                    //Sets distance to all nodes to infinity.
                    dist[i] = double.MaxValue;
                    //Equivalent to putting all nodes in Q.
                    Q[i] = false;
                }

                //Making it so that there is to node before the source and the distance to the source is 0.
                dist[vid[s]] = 0;
                Q[vid[s]] = true;
                //Variable to identify the last examined node.
                //Sets the first node to check as the source.
                int active = s;

                //Loop that runs until it checks a node that has the desired "desttype".
                while (type[active] != d)
                {
                    for (int v = 0; v < eid.Length; v++)
                    {
                        //Checks whether nodes are at the edge of our shortest spanning tree by checking if source is in Q.
                        if (!Q[terminals[v].Item1] && terminals[v].Item2 == vid[active] && 
                            length[v] + dist[vid[active]] < dist[terminals[v].Item1])
                        {
                            //Compares new distance to visited nodes to previous shortest distance, and updates if the new one is shorter.
                            dist[terminals[v].Item1] = length[v] + dist[vid[active]];
                            prev[terminals[v].Item1] = vid[active];
                        }
                        //Same as the above, only with the source and target switched.
                        if (!Q[terminals[v].Item2] && terminals[v].Item1 == vid[active] && 
                            length[v] + dist[vid[active]] < dist[terminals[v].Item2])
                        {
                            //Compares new distance to visited nodes to previous shortest distance, and updates if the new one is shorter.
                                dist[terminals[v].Item2] = length[v] + dist[vid[active]];
                                prev[terminals[v].Item2] = vid[active];
                        }
                    }
                    int pos = vid.Length - 1;
                    if (type[active] != d)
                    {
                        for (int j = 0; j < dist.Length; j++)
                        {
                            //Finds next node to check by finding the shortest distance that is not in Q.
                            if (dist[vid[j]] < dist[vid[pos]] && !Q[vid[j]]) { pos = j; }
                        }
                        active = pos;
                        //"Removes the checked node from Q" by switching the bool, adding it to the shortest spanning tree.
                        Q[vid[active]] = true;
                    }
                }
                int checker = vid[active];
                if (type[active] == d)
                {
                    while (checker != vid[s])
                    {
                        temp.Push(prev[checker]);
                        checker = prev[checker];
                    }
                    for (int p = 0; p <= temp.Count; p++) { vroute.Add(temp.Pop()); }
                    s = active;
                }
            }
            for (int i = 1; i < vroute.Count; i++)
            {
                for (int j = 0; j < terminals.Length; j++)
                {
                    if ((vroute[i] == terminals[j].Item1 &&
                        vroute[i - 1] == terminals[j].Item2) || (vroute[i] == terminals[j].Item2 &&
                        vroute[i - 1] == terminals[j].Item1))
                    { Route.eroute.Enqueue(j); }
                }
            }
            vroute.Clear();
        }
    }
}