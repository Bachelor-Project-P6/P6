using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airport_guidance
{
    public partial class MapResult : Form
    {
        DateTime idleTimer;
        double routelength = new double();
        public MapResult()
        {
            InitializeComponent();
        }

        private void MapResult_Load(object sender, EventArgs e)
        {
            idleTimer = DateTime.Now;
            timer1.Start();
            timer1.Interval = 5000;

            int intHandler1;
            MapWinGIS.Shapefile shapefile1 = new MapWinGIS.Shapefile();
            shapefile1.Open("..\\..\\shapefiles\\Form.shp");
            intHandler1 = axMap1.AddLayer(shapefile1, true);

            int intHandler2;
            MapWinGIS.Shapefile shapefile2 = new MapWinGIS.Shapefile();
            shapefile2.Open("..\\..\\shapefiles\\gang.shp");
            intHandler2 = axMap1.AddLayer(shapefile2, true);

            int intHandler7;
            MapWinGIS.Shapefile shapefile7 = new MapWinGIS.Shapefile();
            shapefile7.Open("..\\..\\shapefiles\\Stairs.shp");
            intHandler7 = axMap1.AddLayer(shapefile7, true);

            int intHandler6;
            MapWinGIS.Shapefile shapefile6 = new MapWinGIS.Shapefile();
            shapefile6.Open("..\\..\\shapefiles\\Shape .shp");
            string myLabel;
            //define two double variables to use as a coordinates for label position
            double x, y;
            for (int i = 0; i < shapefile6.NumShapes - 1; i++)
            {
                //assign the value of the cells of the field number zero to the label
                myLabel = System.Convert.ToString(
                    shapefile6.get_CellValue(1, i));
                //Calculate the x position for the label
                x = shapefile6.get_Shape(i).Extents.xMin +
                    (shapefile6.get_Shape(i).Extents.xMax -
            shapefile6.get_Shape(i).Extents.xMin) / 2;
                //Calculate the y position for the label
                y = shapefile6.get_Shape(i).Extents.yMin +
                    (shapefile6.get_Shape(i).Extents.yMax -
            shapefile6.get_Shape(i).Extents.yMin) / 2;

                shapefile6.Labels.AddLabel(myLabel, x, y, 0, -1);
            }
            intHandler6 = axMap1.AddLayer(shapefile6, true);

            int intHandler3;
            MapWinGIS.Shapefile shapefile3 = new MapWinGIS.Shapefile();
            shapefile3.Open("..\\..\\shapefiles\\Indgang.shp");
            intHandler3 = axMap1.AddLayer(shapefile3, true);

            int intHandler8;
            MapWinGIS.Shapefile shapefile8 = new MapWinGIS.Shapefile();
            shapefile8.Open("..\\..\\shapefiles\\WC.shp");
            intHandler8 = axMap1.AddLayer(shapefile8, true);

            int intHandler9;
            MapWinGIS.Shapefile shapefile4 = new MapWinGIS.Shapefile();
            shapefile4.Open("..\\..\\shapefiles\\navlines.shp");
            shapefile4.DefaultDrawingOptions.LineWidth = 4;
            intHandler9 = axMap1.AddLayer(shapefile4, true);

            int intHandler5;
            MapWinGIS.Shapefile shapefile5 = new MapWinGIS.Shapefile();
            shapefile5.Open("..\\..\\shapefiles\\navnodes.shp");
            intHandler5 = axMap1.AddLayer(shapefile5, false);

            //Calls the Dijkstra algorithm
            Dijkstra.dijkstra(SetLocationMap.Loc, Destinations.Dest);

            //Makes all lines initially hidden.
            for (int i = 0; i < shapefile4.NumShapes; i++) { shapefile4.set_ShapeIsHidden(i, true); }

            routelength = 0;

            List<int> holder = new List<int>();
            //Moves the lines from the route to a list, since it needs to be accessed multiple times.
            for (int j = 0; j <= Dijkstra.Route.eroute.Count; j++) { holder.Add(Dijkstra.Route.eroute.Dequeue()); }


            foreach (int line in holder)
            {
                //Sets included lines from  the route to be shown rather than hidden.
                shapefile4.set_ShapeIsHidden(line, false);
                //Sums up the lengths of included lines.
                routelength += Convert.ToDouble(shapefile4.get_CellValue(3, line));
            }
            //Sets the label to show travel time. It is the sum of line lengths (so total route length) divided by 1.4 meters per second (average walking speed) divided by 60 seconds (to get minutes).
            timeest.Text = String.Format("Estimated time to reach destination: {0} minutes", Math.Round((routelength / 1.4) / 60, 1));
            holder.Clear();
        }

        private void MapResult_MouseMove(object sender, MouseEventArgs e)
        {
            idleTimer = DateTime.Now;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            DateTime checkTime = DateTime.Now;
            TimeSpan span = checkTime.Subtract(idleTimer);
            if (span.Seconds > 20)
            {
                MapWindow open = new MapWindow();
                timer1.Stop();
                Destinations.Dest.Clear();
                open.ShowDialog();
                Close();
                Dispose(true);
            }
        }

        private void btnSelectDest_Click(object sender, EventArgs e)
        {
            SelectDest open = new SelectDest();
            Destinations.Dest.Clear();
            timer1.Stop();
            open.ShowDialog();
            Close();
            Dispose(true);
        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            Password open = new Password();
            Destinations.Dest.Clear();
            timer1.Stop();
            open.ShowDialog();
            Close();
            Dispose(true);
        }

        private void axMap1_MouseDownEvent(object sender, AxMapWinGIS._DMapEvents_MouseDownEvent e)
        {
            
        }
    }
}
