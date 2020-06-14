using System;
using System.IO;
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
    public partial class MapWindow : Form
    {
        public MapWindow()
        {
            InitializeComponent();
        }

        private void MapWindow_Load(object sender, EventArgs e)
        {
            int intHandler6;
            MapWinGIS.Shapefile shapefile6 = new MapWinGIS.Shapefile();
            shapefile6.Open("..\\..\\shapefiles\\air lvl 1.shp");
            string Label1;
            //define two double variables to use as a coordinates for label position
            double x, y;
            for (int i = 0; i < shapefile6.NumShapes - 1; i++)
            {
                //assign the value of the cells of the field number zero to the label
                Label1 = System.Convert.ToString(
                    shapefile6.get_CellValue(1, i));
                //Calculate the x position for the label
                x = shapefile6.get_Shape(i).Extents.xMin +
                    (shapefile6.get_Shape(i).Extents.xMax -
            shapefile6.get_Shape(i).Extents.xMin) / 2;
                //Calculate the y position for the label
                y = shapefile6.get_Shape(i).Extents.yMin +
                    (shapefile6.get_Shape(i).Extents.yMax -
            shapefile6.get_Shape(i).Extents.yMin) / 2;

                shapefile6.Labels.AddLabel(Label1, x, y, 0, -1);
            }
            intHandler6 = axMap1.AddLayer(shapefile6, true);

            int intHandler2;
            MapWinGIS.Shapefile shapefile2 = new MapWinGIS.Shapefile();
            shapefile2.Open("..\\..\\shapefiles\\air lvl 2.shp");
            string Label2;
            //define two double variables to use as a coordinates for label position
            for (int i = 0; i < shapefile2.NumShapes - 1; i++)
            {
                //assign the value of the cells of the field number zero to the label
                Label2 = System.Convert.ToString(
                    shapefile2.get_CellValue(1, i));
                //Calculate the x position for the label
                x = shapefile2.get_Shape(i).Extents.xMin +
                    (shapefile2.get_Shape(i).Extents.xMax -
            shapefile2.get_Shape(i).Extents.xMin) / 2;
                //Calculate the y position for the label
                y = shapefile2.get_Shape(i).Extents.yMin +
                    (shapefile2.get_Shape(i).Extents.yMax -
            shapefile2.get_Shape(i).Extents.yMin) / 2;

                shapefile2.Labels.AddLabel(Label2, x, y, 0, -1);
            }
            intHandler2 = axMap1.AddLayer(shapefile2, true);

            int intHandler3;
            MapWinGIS.Shapefile shapefile3 = new MapWinGIS.Shapefile();
            shapefile3.Open("..\\..\\shapefiles\\air lvl 3.shp");
            string Label3;
            //define two double variables to use as a coordinates for label position
            for (int i = 0; i < shapefile3.NumShapes - 1; i++)
            {
                //assign the value of the cells of the field number zero to the label
                Label3 = System.Convert.ToString(
                    shapefile3.get_CellValue(1, i));
                //Calculate the x position for the label
                x = shapefile3.get_Shape(i).Extents.xMin +
                    (shapefile3.get_Shape(i).Extents.xMax -
            shapefile3.get_Shape(i).Extents.xMin) / 2;
                //Calculate the y position for the label
                y = shapefile3.get_Shape(i).Extents.yMin +
                    (shapefile3.get_Shape(i).Extents.yMax -
            shapefile3.get_Shape(i).Extents.yMin) / 2;

                shapefile3.Labels.AddLabel(Label3, x, y, 0, -1);
            }
            intHandler3 = axMap1.AddLayer(shapefile3, true);

            int intHandler4;
            MapWinGIS.Shapefile shapefile4 = new MapWinGIS.Shapefile();
            shapefile4.Open("..\\..\\shapefiles\\navlines.shp");
            intHandler4 = axMap1.AddLayer(shapefile4, false);

            int intHandler5;
            MapWinGIS.Shapefile shapefile5 = new MapWinGIS.Shapefile();
            shapefile5.Open("..\\..\\shapefiles\\navnodes.shp");
            intHandler5 = axMap1.AddLayer(shapefile5, true);

            if (File.Exists("..\\..\\devloc.txt"))
            {
                SetLocationMap.Loc = Convert.ToInt32(File.ReadAllText("..\\..\\devloc.txt"));
            }

            for (int i = 0; i < shapefile4.NumShapes; i++) 
            {
                if (i == SetLocationMap.Loc) { shapefile5.set_ShapeIsHidden(i, false); }
                else { shapefile5.set_ShapeIsHidden(i, true); }
            }

        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            Password open = new Password();
            open.ShowDialog();
            Close();
            Dispose(true);
        }

        private void btnSelectDest_Click(object sender, EventArgs e)
        {
            SelectDest open = new SelectDest();
            open.ShowDialog();
            Close();
            Dispose(true);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void axMap2_MouseDownEvent(object sender, AxMapWinGIS._DMapEvents_MouseDownEvent e)
        {

        }

        private void axMap1_MouseDownEvent(object sender, AxMapWinGIS._DMapEvents_MouseDownEvent e)
        {

        }
    }
}
