using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TokenSecured.ProductApi.Models
{
    public class User
    {

        public int Id { get; set; }
        public string EmailID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
    }
}