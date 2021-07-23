using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawShapes
{
   public abstract class Shape
    {
        

        protected int x = 0, y = 0, z = 0;


        public Shape(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

         Shape(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public Shape()
        {
        }


        public void setX(int x)
        {
            this.x = x;
        }


        /// <summary>
        /// Getter for X
        /// </summary>
        /// <returns>Returns itself X</returns>
        public int getX()
        {
            return x;
        }

        /// <summary>
        /// Setter method for Y
        /// </summary>
        /// <param name="y">Y as paremeter</param>
        public void setY(int y)
        {
            this.y = y;
        }
        
        /// </summary>
        /// <returns>Returns Y</returns>
        public int getY()
        {
            return y;
        }
        public abstract void Drawpaint(Graphics g, Color c, int thickness);
        public abstract void DrawFill(Graphics g, Color c);




    }
}
