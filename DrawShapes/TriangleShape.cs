using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawShapes
{
   public class TriangleShape : Shape
    {

        PointF[] points
            ;
        /// <summary>
        /// default constructor
        /// </summary>
        public TriangleShape()
        {

        }
        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="points">Points as paremeter</param>
        public TriangleShape(PointF[] points)
        {
            this.points = points;
        }
        /// <summary>
        ///Pparemeterized constructor which is extending base class which is Shape
        /// </summary>
        /// <param name="x">takes x as paremeter</param>
        /// <param name="y">takes y as paremeter</param>
        public TriangleShape(int x, int y) : base(x, y)
        {

        }
        /// <summary>
        /// Setter for points
        /// </summary>
        /// <param name="points">Points as paremeter</param>
        public void setPoints(PointF[] points)
        {
            this.points = points;
        }
        /// <summary>
        /// Getter method for Points
        /// </summary>
        /// <returns></returns>
        public PointF[] getPoint()
        {
            return this.points;
        }
        /// <summary>
        /// Fill method called from Shape Class(Fill is the method on Shape Class)
        /// </summary>
        /// <param name="g">Graphic</param>
        /// <param name="c">Color</param>
        public override void DrawFill(Graphics g, Color c)
        {
            SolidBrush fill = new SolidBrush(c);
            g.FillPolygon(fill, points);
        }
        /// <summary>
        /// Paint method called from Shape Class(Paint is the method on Shape Class)
        /// </summary>
        /// <param name="g">Graphic</param>
        /// <param name="c">Color</param>
        /// <param name="thickness">Thickness as pen</param>
        public override void Drawpaint(Graphics g, Color c, int thickness)
        {
            Pen p = new Pen(c);
            g.DrawPolygon(p, points);
        }

    }
}
