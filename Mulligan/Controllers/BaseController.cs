using Mulligan.Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Mulligan.Controllers
{
    public abstract class BaseApiController : ApiController
    {
        protected MulliganDataContext DataContext
        {
            get
            {
                try
                {
                    var connString = ConfigurationManager.ConnectionStrings["MulliganEntities"];
                    return new MulliganDataContext(connString.ConnectionString);
                }
                catch
                {
                    return new MulliganDataContext();
                }
            }
        }
    }
}