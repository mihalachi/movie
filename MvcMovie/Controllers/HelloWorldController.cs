
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/ 

        public string Index()
        {
            return "This is my <b>default</b> action...";
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        //        // parameter as query string
        //        // http://localhost:xxx/HelloWorld/Welcome?name=Scott&numtimes=4
        //        public string Welcome(string name, int numTimes = 1)
        //        {
        //            return HttpUtility.HtmlEncode("Hello " + name + ", NumTimes is: " + numTimes);
        //        }

        // NB: prefer to use route inspite of query string to pass parameters
        // query string - http://localhost:xxx/HelloWorld/Welcome?name=Scott&numtimes=4
        // route        - http://localhost:xxx/HelloWorld/Welcome/3?name=Rick
        // route        - http://localhost:xxx/helloworld/welcome/jozefina/55

        // model binder - also is posible to pass data using model binder, and it does not require to modifi default route.


        // parameter as route data
        // http://localhost:xxx/HelloWorld/Welcome/3?name=Rick
        public string Welcome(string name, int ID = 1)
        {
            return HttpUtility.HtmlEncode("Hello " + name + ", ID: " + ID);
        }
    }
}