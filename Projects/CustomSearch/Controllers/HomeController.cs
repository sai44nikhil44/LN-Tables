using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using Newtonsoft.Json;
using System.IO;
using CustomSearch.Models;

namespace CustomSearch.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult SignIn()
        {
            return View();
        }
        public ActionResult Index()
        {
            string userName = Request["name"];
            string password = Request["password"];
            
            return View();
        }



        public ActionResult ShowResults()
        {
            string searchQuery = Request["search"];
            string cx = "000048702179250519178:x1q6gz2ecvh";
            string apiKey = "AIzaSyAP2W-a9kWamimS7Wjzk6NpDqPECdiZrFc";
            var request = WebRequest.Create("https://customsearch.googleapis.com/customsearch/v1?key=" + apiKey + "&cx=" + cx + "&q=" + searchQuery);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseString = reader.ReadToEnd();
            dynamic jsonData = JsonConvert.DeserializeObject(responseString);

            var results = new List<Result>();
            foreach (var item in jsonData.items)
            {
                results.Add(new Result
                {
                    Title = item.title,
                    Link = item.link,
                    Snippet = item.snippet,
                    

                }) ;
            }
            return View(results.ToList());
        }
    }
}