using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KontrolerZadanie.Logic
{
    public class TimerAttribute : ActionFilterAttribute
    {
        public TimerAttribute()
        {
            this.Order = int.MaxValue;
        }

        private Stopwatch _stopWatch;


        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var controller = filterContext.Controller;

            if (controller != null)
            {
                var stopwatch = new Stopwatch();
                _stopWatch = stopwatch;

                _stopWatch.Start();
            }
        }


        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            var controller = filterContext.Controller;

            if (controller != null)
            {
                var stopwatch = _stopWatch;

                stopwatch.Stop();
                controller.ViewBag._Duration = stopwatch.ElapsedMilliseconds;
            }
        }
    }
}