using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawShapes
{
    class Circle : Shape
    {
        
        int radius;

        /// <summary>
        /// Consturctor made for class Circle
        /// </summary>
        /// <param name="x">X cordintaes</param>
        /// <param name="y">Y cordinates</param>
        /// <param name="radius">Radius</param>
        /// 
        public Circle(int x, int y, int radius) : base(x, y)
        {
            this.radius = radius;

        }

        /// <summary>
        /// Default Constructor for circle
        /// </summary>
        public Circle()
        {

        }
        /// <summary>
        /// Consturctor made for class Circle
        /// </summary>
        /// <param name="radius">circle radius</param>
        public Circle(int radius)
        {
            this.radius = radius;
        }
        /// <summary>
        ///  Takes parameter for circle X and Y with base class which is Shape
        /// </summary>
        /// <param name="x">X parameter</param>
        /// <param name="y">Yparamater</param>
        public Circle(int x, int y) : base(x, y)
        {

        }

        /// <summary>
        /// Paint method called from Shape Class(Paint is the method on Shape Class)
        /// </summary>
        /// <param name="g">graphic libraryr</param>
        /// <param name="c">color</param>
        /// <param name="thickness"></param>
        /// 
        public override void Drawpaint(Graphics g, Color c, int thickness)
        {
            Pen p = new Pen(c, thickness);
            g.DrawEllipse(p, x, y, radius, radius);
        }
        /// <summary>
        /// Fill method called from Shape Class(Fill is the method on Shape Class)
        /// </summary>
        /// <param name="g">graphic library</param>
        /// <param name="c">color</param>
        public override void DrawFill(Graphics g, Color c)
        {
            SolidBrush fill = new SolidBrush(c);
            g.FillEllipse(fill, x, y, radius, radius);
        }

       
        /// </summary>
        /// <param name="radius">Radius</param>
        public void setRadius(int radius)
        {
            this.radius = radius;
        }

       
        /// </summary>
        /// <returns>radius</returns>
        public int getRadius()
        {
            return this.radius;
        }


    }

}

