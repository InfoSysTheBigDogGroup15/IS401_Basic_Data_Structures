using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IS401_Basic_Data_Structures.Controllers
{
    public class IndexController : Controller
    {
        //random name generator code

        public static Random random = new Random();

        public static string randomName()
        {
            string[] names = new string[8] { "Dan Morain", "Emily Bell", "Carol Roche", "Ann Rose", "John Miller", "Greg Anderson", "Arthur McKinney", "Joann Fisher" };
            int randomIndex = Convert.ToInt32(random.NextDouble() * 7);
            return names[randomIndex];
        }

        public static int randomNumberInRange()
        {
            return Convert.ToInt32(random.NextDouble() * 20);
        }

        // GET: Index
        public ActionResult Index()
        {
            //Create variables
            Queue<string> lineOfCustomers = new Queue<string>();
            Dictionary<string, int> customerInfo = new Dictionary<string, int>();
            //Load variables


            return View();
        }
}
