using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawShapes
{
   public class PolygonShape : Shape
    {
        PointF[] points
           ;
        /// <summary>
        /// Default constructor
        /// </summary>
        public PolygonShape()
        {
        }
        /// <summary>
        /// Parameterized Constructor Created
        /// </summary>
        /// <param name="x">X</param>
        /// <param name="y">Y</param>
        public PolygonShape(int x, int y) : base(x, y)
        {

        }
        /// <summary>
        /// Constructor that takes points to create polygon
        /// </summary>
        /// <param name="points">points</param>
        public PolygonShape(PointF[] points)
        {
            this.points = points;
        }
        /// <summary>
        /// Setter method for points
        /// </summary>
        /// <param name="points">points</param>
        public void setPoints(PointF[] points)
        {
            this.points = points;
        }
        /// <summary>
        /// Getter method for points
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
        /// <param name="thickness">takes Thickness for pen</param>
        public override void Drawpaint(Graphics g, Color c, int thickness)
        {
            Pen p = new Pen(c);
            g.DrawPolygon(p, points);
        }
    }
}
