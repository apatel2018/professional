using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloWorldConsole
{
    class Program
    {
        /// <summary>
        /// object to access Data Access Methods
        /// </summary>
        public static DAL dalobj = new DAL();
        static void Main(string[] args)
        {
            DisplayText();
        }

        /// <summary>
        /// Method to display text on console screen
        /// </summary>
        public static void DisplayText()
        {
            try
            {
                Console.WriteLine(dalobj.GetTextToDisplay());
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
