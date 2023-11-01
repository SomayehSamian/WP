using Microsoft.AspNetCore.Mvc.Filters;

namespace WorkProject.ActionFilter
{
    public class MyLogFilter: ActionFilterAttribute
    {
        //private static int _callCount=0;
        private int _callCount=0;
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            _callCount++;
        }
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            context.HttpContext.Response.Headers.Add("X-Api-Call-Count", _callCount.ToString());
        }
    }
}
