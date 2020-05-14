using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MapWinGIS;

namespace Airport_guidance
{

    public partial class SetLocationMap : Form
    {
        //Will probably be converted to a cell value of the vertex.
        public static int Loc = 370;
        DateTime idleTimer;
        public SetLocationMap()
        {
            InitializeComponent();
        }

        private void btnCancelNode_Click(object sender, EventArgs e)
        {
            MapWindow open = new MapWindow();
            Destinations.Dest.Clear();
            open.ShowDialog();
            Close();
        }
        private void SetLocationMap_Load(object sender, EventArgs e)
        {
            idleTimer = DateTime.Now;
            Timer1.Start();
            Timer1.Interval = 5000;

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

            int intHandler4;
            MapWinGIS.Shapefile shapefile4 = new MapWinGIS.Shapefile();
            shapefile4.Open("..\\..\\shapefiles\\navlines.shp");
            intHandler4 = axMap1.AddLayer(shapefile4, false);

            int intHandler5;
            MapWinGIS.Shapefile shapefile5 = new MapWinGIS.Shapefile();
            shapefile5.Open("..\\..\\shapefiles\\navnodes.shp");
            intHandler5 = axMap1.AddLayer(shapefile5, true);

            axMap1.SendMouseDown = true;
            axMap1.MouseDownEvent += axMap1_MouseDownEvent;
            axMap1.CursorMode = tkCursorMode.cmNone;
        }
        

        private void SetLocationMap_MouseMove(object sender, MouseEventArgs e)
        {
            idleTimer = DateTime.Now;
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            DateTime checkTime = DateTime.Now;
            TimeSpan span = checkTime.Subtract(idleTimer);
            if (span.Seconds > 30)
            {
                MapWindow open = new MapWindow();
                Timer1.Stop();
                open.ShowDialog();
                Destinations.Dest.Clear();
                Close();
                Dispose(true);
            }
        }

        private void axMap1_MouseDownEvent(object sender, AxMapWinGIS._DMapEvents_MouseDownEvent e)
        {
            int layerHandler = axMap1.get_LayerHandle(7);
            Shapefile node = axMap1.get_Shapefile(layerHandler);
            if (node != null)
            {
                double projX = 0.0;
                double projY = 0.0;
                axMap1.PixelToProj(e.x, e.y, ref projX, ref projY);
                object result = null;
                Extents ext = new Extents();
                ext.SetBounds(projX, projY, 0.0, projX, projY, 0.0);
                if (node.SelectShapes(ext, 10.0, SelectMode.INCLUSION, ref result))
                {
                    int[] shapes = result as int[];
                    if (shapes == null) return;
                    if (shapes.Length > 1)
                    {
                        MessageBox.Show("Please select only one node for the device location.");
                    }
                    else
                    {
                        Loc = shapes[0];
                        MessageBox.Show("Device location was selected. Node number " + shapes[0]);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a node to set device location.");
                }
            }
        }
    }
}
