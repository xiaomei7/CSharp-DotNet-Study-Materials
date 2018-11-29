using Microsoft.AspNetCore.Mvc;

namespace OdeToFood.Controllers
{
    [Route("[controller]/[action]")] // attribute based routing
    public class AboutController
    {
        // /about to phone action
        public string Phone()
        {
            return "1+555+555+5555";
        }

        public string address()
        {
            return "USA";
        }
    }
}