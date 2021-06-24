using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace finalexam.Controllers
{
    public class WeekController : Controller
    {
        // GET: Week
        public ActionResult onetwo(float? num)
        {
            var result = "";
            if (num.HasValue)
            {
                if(num==1)
                {
                    result = "星期一";
                }
                if (num == 2)
                {
                    result = "星期二";
                }
                if (num == 3)
                {
                    result = "星期三";
                }
                if (num == 4)
                {
                    result = "星期四";
                }
                if (num == 5)
                {
                    result = "星期五";
                }
                if (num == 6)
                {
                    result = "星期六";
                }
                if (num == 7)
                {
                    result = "星期日";
                }
            }
            ViewBag.Result = result;
            return View();
        }
    }
}