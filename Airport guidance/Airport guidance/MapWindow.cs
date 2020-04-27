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
    public partial class MapWindow : Form
    {
       
        public MapWindow()
        {
            InitializeComponent();
        }

        private void MapWindow_Load(object sender, EventArgs e)
        {
            int intHandler1;
            MapWinGIS.Shapefile shapefile1 = new MapWinGIS.Shapefile();
            shapefile1.Open(@"D:\C#补习\airport guidance 4_ny\Aalborg airport\Form.shp");
            intHandler1 = axMap1.AddLayer(shapefile1, true);

            int intHandler2;
            MapWinGIS.Shapefile shapefile2 = new MapWinGIS.Shapefile();
            shapefile2.Open(@"D:\C#补习\airport guidance 4_ny\Aalborg airport\gang.shp");
            intHandler2 = axMap1.AddLayer(shapefile2, true);

            int intHandler3;
            MapWinGIS.Shapefile shapefile3 = new MapWinGIS.Shapefile();
            shapefile3.Open(@"D:\C#补习\airport guidance 4_ny\Aalborg airport\Indgang.shp");
            intHandler3 = axMap1.AddLayer(shapefile3, true);

            int intHandler4;
            MapWinGIS.Shapefile shapefile4 = new MapWinGIS.Shapefile();
            shapefile4.Open(@"D:\C#补习\airport guidance 4_ny\Aalborg airport\Navlines.shp");
            intHandler4 = axMap1.AddLayer(shapefile4, true);

            int intHandler5;
            MapWinGIS.Shapefile shapefile5 = new MapWinGIS.Shapefile();
            shapefile5.Open(@"D:\C#补习\airport guidance 4_ny\Aalborg airport\Navnnodes.shp");
            intHandler5 = axMap1.AddLayer(shapefile5, true);

            int intHandler6;
            MapWinGIS.Shapefile shapefile6 = new MapWinGIS.Shapefile();
            shapefile6.Open(@"D:\C#补习\airport guidance 4_ny\Aalborg airport\Shape.shp");
            intHandler6 = axMap1.AddLayer(shapefile6, true);

            int intHandler7;
            MapWinGIS.Shapefile shapefile7 = new MapWinGIS.Shapefile();
            shapefile7.Open(@"D:\C#补习\airport guidance 4_ny\Aalborg airport\Stairs.shp");
            intHandler7 = axMap1.AddLayer(shapefile7, true);

            int intHandler8;
            MapWinGIS.Shapefile shapefile8 = new MapWinGIS.Shapefile();
            shapefile8.Open(@"D:\C#补习\airport guidance 4_ny\Aalborg airport\WC.shp");
            intHandler8 = axMap1.AddLayer(shapefile8, true);

        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            Password open = new Password();
            open.ShowDialog();
            Close();
        }

        private void btnSelectDest_Click(object sender, EventArgs e)
        {
            SelectDest open = new SelectDest();
            open.ShowDialog();
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
