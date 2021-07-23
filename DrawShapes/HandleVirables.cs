using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawShapes
{
    public class HandleVirables
    {
        /// <summary>
        /// Get Set method for variable
        /// </summary>
        public string variable { get; set; }
        /// <summary>
        /// Get Set method for value
        /// </summary>
        public float value { get; set; }
        /// <summary>
        /// Setter for variable
        /// </summary>
        /// <param name="variable">Variables as paremeter</param>
        public void setVariable(string variable)
        {
            this.variable = variable;
        }
        /// <summary>
        /// Getter for variables
        /// </summary>
        /// <returns></returns>
        public string getVariable()
        {
            return this.variable;
        }
        /// <summary>
        /// Setter for value
        /// </summary>
        /// <param name="value">Value as paremeter</param>
        public void setValue(float value)
        {
            this.value = value;
        }
        /// <summary>
        /// Getter for variable
        /// </summary>
        /// <returns></returns>
        public float getValue()
        {
            return this.value;
        }
    }
}
