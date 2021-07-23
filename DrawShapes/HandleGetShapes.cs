using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawShapes
{
    class HandleGetShapes
    {
        /// <summary>
        /// Method to check if the input is circle
        /// </summary>
        /// <param name="shape">Shape as paremeter</param>
        /// <returns></returns>
        public bool isCircle(string shape)
        {
            if (shape == "circle")
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Method to check if the input is Rectangle
        /// </summary>
        /// <param name="shape">Shape as paremeter</param>
        /// <returns></returns>
        public bool isRectangle(string shape)
        {
            if (shape == "rectangle")
            {
                return true;
            }
            return false;
        }
    }
}
