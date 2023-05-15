using System.Text.RegularExpressions;

namespace _04_ASp.NetRouting
{
    public class CustomeConstrainsts_Class : IRouteConstraint
    {

        public bool Match(HttpContext? httpContext, IRouter? route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
        {
            if (!values.ContainsKey(routeKey))
            {
                return false;
            }
            Regex regex = new Regex("^(apr | july | oct | jun )$");
            string? month1 = Convert.ToString(values[routeKey]);
            if (regex.IsMatch(month1))
            {
                return true;
            }
            return false;


        }
    }


}
