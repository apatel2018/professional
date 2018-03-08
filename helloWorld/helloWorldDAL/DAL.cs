using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using helloWorldBusinessObj;

namespace helloWorldDAL
{
    /// <summary>
    /// Data access layer of API
    /// </summary>
    public class DAL
    {
        /// <summary>
        /// Load data from a source
        /// </summary>
        /// <returns></returns>
        public Display loadDisplayObj()
        {
            return new Display() { textToDisplay = "Hello World" }; 
        }
    }
}
