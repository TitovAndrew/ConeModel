using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KGLaba5
{
    class Polygons
    {
        private double z0;
        public double Z0
        {
            get { return z0; }
            set { z0 = value; }
        }  
        
        public PointF[] Plgn = new PointF[50];      

        public Polygons (double z0, PointF[] array)
        {
            Z0 = z0;
            Plgn = array;
        } 
    }
}
