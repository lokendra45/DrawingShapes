using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawShapes
{
    class RectangleShape : Shape
    {
        int height, width;


        /// <summary>
        /// Parameterized constructor declared
        /// </summary>
        /// <param name="x">X as paremeter</param>
        /// <param name="y">Y as paremeter</param>
        /// <param name="height">Height as paremeter</param>
        /// <param name="width">Width as paremeter</param>
        public RectangleShape(int x, int y, int height, int width) : base(x, y)
        {
            this.height = height;
            this.width = width;
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        public RectangleShape()
        {
        }

        /// <summary>
        /// Paint method called from Shape Class(Paint is the method on Shape Class) 
        /// </summary>
        /// <param name="g">Graphic</param>
        /// <param name="c">Color</param>
        /// <param name="thickness">Pen</param>
        public override void Drawpaint(Graphics g, Color c, int thickness)
        {
            Pen p = new Pen(c, thickness);
            g.DrawRectangle(p, x, y, height, width);
        }
        /// <summary>
        /// Fill method called from Shape Class(Fill is the method on Shape Class)
        /// </summary>
        /// <param name="g">Graphic</param>
        /// <param name="c">Color</param>
        public override void DrawFill(Graphics g, Color c)
        {
            SolidBrush fill = new SolidBrush(c);
            g.FillRectangle(fill, x, y, height, width);
        }
        /// <summary>
        /// Setter for Height
        /// </summary>
        /// <param name="height">Height</param>
        public void setHeight(int height)
        {
            this.height = height;
        }
        /// <summary>
        /// Getter method for height
        /// </summary>
        /// <returns>Returns Height</returns>
        public int getHeight()
        {
            return this.height;
        }
        /// <summary>
        /// Setter method for Width
        /// </summary>
        /// <param name="width">Wodth</param>
        public void setWidth(int width)
        {
            this.width = width;
        }
        /// <summary>
        /// get method for width
        /// </summary>
        /// <returns>Returns Height</returns>
        public int getWidth()
        {
            return this.width;
        }
    }
}
