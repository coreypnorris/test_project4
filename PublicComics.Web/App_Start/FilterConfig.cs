using System;
using System.Web;
using System.Web.Mvc;

namespace PublicComics.Web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }

    public class BasicAuthentication : ActionFilterAttribute
    {
        public string BasicRealm { get; set; }
        protected string Username { get; set; }
        protected string Password { get; set; }

        public BasicAuthentication()
        {
            var ServiceConfiguration = new Infrastructure.ServiceConfiguration();
            var BasicAuthUsername = ServiceConfiguration.BasicAuthenticationUsername;
            var BasicAuthPassword = ServiceConfiguration.BasicAuthenticationPassword;
            this.Username = BasicAuthUsername;
            this.Password = BasicAuthPassword;
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var req = filterContext.HttpContext.Request;
            var auth = req.Headers["Authorization"];
            if (!String.IsNullOrEmpty(auth))
            {
                var cred = System.Text.ASCIIEncoding.ASCII.GetString(Convert.FromBase64String(auth.Substring(6))).Split(':');
                var user = new { Name = cred[0], Pass = cred[1] };
                if (user.Name == Username && user.Pass == Password) return;
            }
            var res = filterContext.HttpContext.Response;
            res.StatusCode = 401;
            res.AddHeader("WWW-Authenticate", String.Format("Basic realm=\"{0}\"", BasicRealm ?? "Ryadel"));
            res.End();
        }
    }
}
