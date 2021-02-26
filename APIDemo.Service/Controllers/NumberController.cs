using APIDemo.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace APIDemo.Service.Controllers
{
    public class NumberController : Controller
    {
        // GET: Number
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(NumberEntity numberEntity)
        {
            using (var client = new HttpClient())
            {

                var responseTask = client.GetAsync("http://localhost:57257/api/Number/GetDetails?Number=" + numberEntity.Number + "&Divisor=" + numberEntity.Divisor);
                //responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<NumberEntity>();
                    readTask.Wait();
                    numberEntity = readTask.Result;
                }
            }

            return View("Result", numberEntity);
        }
        public ActionResult Result()
        {
            return View();
        }
    }
}