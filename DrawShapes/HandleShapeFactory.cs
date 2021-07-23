using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawShapes
{
    class HandleShapeFactory
    {
        /// <summary>
        /// bool method to chake weahter the type is shape
        /// </summary>
        /// <param name="type">takes type as string</param>
        /// <returns>if not then null</returns>
        public bool isShape(string type)
        {
            if (type == "shape")
            {
                return true;
            }
            return false;
        }
    }
}
