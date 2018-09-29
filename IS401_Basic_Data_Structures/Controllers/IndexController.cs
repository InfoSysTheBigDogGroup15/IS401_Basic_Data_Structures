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
        //Random number generator Dr. Anderson gave us.
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
            //input data (Log the customers in line)
            for (int i = 0; i < 100; i++) 
            {
                lineOfCustomers.Enqueue(randomName());
            }
            //move customers into dictionary and add num burgers bought
            IEnumerator<string> MyQueueEnumerator = lineOfCustomers.GetEnumerator();

            while (MyQueueEnumerator.MoveNext()) //while enumerator can still move next (IE, the queue still have values left)
            {
                string myValue = MyQueueEnumerator.Current; //myValue = what ever is in the queue at this point.
                if(lineOfCustomers.Contains(myValue))
                {
                    customerInfo[myValue] += randomNumberInRange(); //if name is in dictionary, add burgers
                }
                else 
                {
                    customerInfo.Add(myValue, randomNumberInRange());//first time in line, have to add them to the dictionary
                    //QUESTION: the first go around, do they get burgers? or should we initiate to 0 first?
                }
            }
<<<<<<< HEAD

=======
>>>>>>> 8541a3f... dictionary loaded and has burger values.

            return View();
        }
    }
}