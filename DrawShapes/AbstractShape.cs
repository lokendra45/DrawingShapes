using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawShapes
{
   public abstract class AbstractShape
    {
        /// <summary>
        /// Getter mehtod for ShapeType.
        /// </summary>
        /// <param name="shapeType"></param>
        /// <returns>returns string shapeTpye</returns>
        public abstract Shape getShape(String shapeType);
    }
}

