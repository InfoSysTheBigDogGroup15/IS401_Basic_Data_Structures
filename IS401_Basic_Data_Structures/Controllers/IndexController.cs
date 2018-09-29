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

        public static string randomName() {
        string[] names = new string[8]{"Dan Morain", "Emily Bell", "Carol Roche", "Ann Rose", "John Miller", "Greg Anderson", "Arthur McKinney", "Joann Fisher"};
        int randomIndex = Convert.ToInt32(random.NextDouble() * 7);
        return names[randomIndex];
        }

        public static int randomNumberInRange() {
        return Convert.ToInt32(random.NextDouble() * 20);
        }

       
        // GET: Index
        public ActionResult Index()
        {   
            Queue<string> CustomerQueue = new Queue<string>();
            Boolean usethis = true;
            Dictionary<string, int> CustomerDictionary = new Dictionary<string, int>();
            for (int i =0; i<100; i++)
                {   string loopName = randomName();
                    CustomerQueue.Enqueue(loopName);
                
                }
            IEnumerator<string> MyQueueEnumerator = CustomerQueue.GetEnumerator();

            while (MyQueueEnumerator.MoveNext()) //while enumerator can still move next (IE, the queue still have values left)
            {
                string myValue = MyQueueEnumerator.Current; //myValue = what ever is in the queue at this point.
                if (CustomerDictionary.ContainsKey(myValue))
                {
                    CustomerDictionary[myValue] += randomNumberInRange(); //if name is in dictionary, add burgers
                }
                else
                {
                    CustomerDictionary.Add(myValue, 0);//first time in line, have to add them to the dictionary
                    //QUESTION: the first go around, do they get burgers? or should we initiate to 0 first?
                }
            }
            ViewBag.Output = "<table>";
            ViewBag.Output += "<tr>";
            ViewBag.Output += "<th>Name</th>";
            ViewBag.Output += "<th>Burgers</th>";
            ViewBag.Output += "</tr>";

            //add the rest of the html table rows (using <tr> tag) and cells (using <td> tag) and a foreach statement
            //make sure you close the table html tag

            foreach (KeyValuePair<string, int> Name2 in CustomerDictionary)
            {
                
                ViewBag.Output += "<tr>";
                ViewBag.Output += "<td>" + Name2.Key + "</td>";
                ViewBag.Output += "<td>" + Name2.Value + "</td>";
                ViewBag.Output += "</tr>";
            }

            ViewBag.Output += "</table>";
            return View();
        }
    }
}
