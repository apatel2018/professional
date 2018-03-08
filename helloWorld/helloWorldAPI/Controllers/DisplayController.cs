using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using helloWorldBLL;
using helloWorldBusinessObj;

namespace helloWorldAPI.Controllers
{
    public class DisplayController : ApiController
    {
        BLL bllobj = new BLL();   
        /// <summary>
        /// Gets text that needs to be displayed
        /// </summary>
        /// <returns></returns>
        public string GetDisplay() 
        {
            return bllobj.loadDisplayObj().textToDisplay;
        }
    }
}
