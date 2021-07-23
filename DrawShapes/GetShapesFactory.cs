using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawShapes
{
   public class GetShapesFactory : AbstractShape
    {
        /// <summary>
        /// Getter which takes shape type as a String
        /// </summary>
        /// <param name="shapeType">ShapeType as paremeter</param>
        /// <returns></returns>
        public override Shape getShape(String shapeType)
        {
            if (shapeType == null)
            {
                return null;
            }

            if (shapeType.Equals("Circle"))
            {
                return new Circle(0, 0, 100);

            }
            else if (shapeType.Equals("Rectangle"))
            {
                return new RectangleShape(0, 0, 100, 50);
            }
            else if (shapeType.Equals("Trangle"))
            {
                return new TriangleShape(0, 0);
            }
            else if (shapeType.Equals("Polygon"))
            {
                return new PolygonShape(0, 0);
            }
            return null;
        }
    }
}
