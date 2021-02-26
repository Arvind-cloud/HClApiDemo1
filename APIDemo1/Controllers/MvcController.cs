using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace APIDemo1.Controllers
{
    public class MvcController : Controller
    {
        // GET: Mvc
        public ActionResult Index( int n, int k)
        {
            if (ModelState.IsValid)
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:57257/api/");//API url
                    var postTask = client.GetAsync("Values/findNthNumber/" + n.ToString()+"/"+ n.ToString());//api action name
                    postTask.Wait();
                    var result = postTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        return RedirectToAction("Index");
                    }
                }
            }
            return View();
        }
    }
}