using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawShapes
{
  public  class ShapeFactory
    {
        /// <summary>
        /// Factory class for different color and shape
        /// </summary>
        /// <param name="choice">this is for shape</param>
        /// <returns>returns shapeFactory if true else returns null</returns>
        public static AbstractShape getFactory(String choice)
        {
            if (choice.Equals("Shape"))
            {
                return new GetShapesFactory();
            }
            return null;
        }
    }
}
