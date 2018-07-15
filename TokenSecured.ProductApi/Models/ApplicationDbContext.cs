using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TokenSecured.ProductApi.Models
{
    public class ApplicationDbContexts
    {
        AuthenticationEntities db = new AuthenticationEntities();
        public AuthenticationEntities ApplicationDbContext { get { return db; } }

    }
}