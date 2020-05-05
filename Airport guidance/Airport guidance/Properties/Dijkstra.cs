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
        public void buildgraph()
        {
            //int intHandler1;
            //MapWinGIS.Shapefile shapefile1 = new MapWinGIS.Shapefile();
            //shapefile1.Open("..\\..\\shapefiles\\navlines.shp");

            //int intHandlder2;
            //MapWinGIS.Shapefile shapefile2 = new MapWinGIS.Shapefile();
            //shapefile2.Open("..\\..\\shapefiles\\navnodes.shp");

            int s = SetLocationMap.Loc;

            while (Destinations.Dest.Count != 0);
                Shapefile edge = new Shapefile();
                edge.Open("..\\..\\shapefiles\\navlines.shp");

                Shapefile vertex = new Shapefile();
                vertex.Open("..\\..\\shapefiles\\navnodes.shp");
                
                //Making a graph to populate with vertices
                Graph<object> network = new Graph<object>();

            for (int i = 0; i < vertex.NumShapes; i++)
            {
                network.AddNode(vertex.get_CellValue(1, i));
                for (int j = 0; j < edge.NumShapes; j++)
                {
                    if (edge.get_CellValue(1, j) == vertex.get_CellValue(1, i) || edge.get_CellValue(2, j) == vertex.get_CellValue(1, i))
                    { network.AddUndirectedEdge(edge.get_CellValue(1, j), edge.get_CellValue(2, j), Convert.ToInt32(edge.get_CellValue(3, j))); };
                }
            }
        }
    }
}
