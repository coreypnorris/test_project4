using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PublicComics.Web.Infrastructure
{
    public class ServiceConfiguration
    {
        public ServiceConfiguration()
        {
            BasicAuthenticationUsername = System.Configuration.ConfigurationManager.AppSettings["BasicAuthenticationUsername"];
            BasicAuthenticationPassword = System.Configuration.ConfigurationManager.AppSettings["BasicAuthenticationPassword"];
        }

        public string BasicAuthenticationUsername { get; private set; }
        public string BasicAuthenticationPassword { get; private set; }
    }
}