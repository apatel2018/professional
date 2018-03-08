using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using helloWorldDAL;
using helloWorldBusinessObj;

namespace helloWorldBLL
{
    /// <summary>
    /// Business logic for API
    /// </summary>
    public class BLL
    {
        DAL dalobj = new DAL();
        /// <summary>
        /// loads Display object from data access layer 
        /// and can be used to add necessary business logic
        /// </summary>
        /// <returns></returns>
        public Display loadDisplayObj()
        {
            string displayText = dalobj.loadDisplayObj().textToDisplay;
            if (displayText != string.Empty)
                return dalobj.loadDisplayObj();
            else
                throw new ArgumentException("Received null value from data source");
        }
    }
}
