using System.Text;
using System.Web.Http;
//using TokenSecured.ProductApi.Models;
//using TokenSecured.ProductApi.Repository;

namespace TokenSecured.ProductApi.Controllers
{
    [RoutePrefix("api/Authentication")]
    public class AuthenticationController : ApiController
    {
        [HttpGet]
        [Route("NoAuth")]
        [Authorize(Roles = "Admin")]
        public IHttpActionResult NoAuth()
        {
            //Accounts userRoles = new Accounts();
            return Ok();// userRoles.GetUserRoles());
        }

        [HttpGet]
        [Route("AuthorizedUser")]
        [Authorize(Roles ="Admin")]
        public IHttpActionResult AuthorizedUser()
        {
            //Accounts userRoles = new Accounts();
            return Ok();// userRoles.GetUserRoles());
        }

        [HttpGet]
        [Route("AuthenticatedUser")]
        [Authorize]
        public IHttpActionResult AuthenticatedUser()
        {
            //Employees emp = new Employees();
            return Ok();// emp.GetEmployees());
        }

        [HttpGet]
        [Route("AuthenticatedUser2")]
        [Authorize]
        public IHttpActionResult AuthenticatedUser2()
        {
            //Employees emp = new Employees();
            return Ok(new { name="abc", val="val1"});// emp.GetEmployees());
        }

        [HttpPost]
        [Route("PostUserData")]
        [Authorize(Roles = "Admin")]
        public IHttpActionResult PostData()//[FromBody]Models.User userData)
        {
            //Accounts regObj = new Accounts();
            //ApplicationUser regData = new ApplicationUser();
            //regData.EmailID = userData.EmailID;
            //regData.Password = Encoding.UTF8.GetBytes(userData.Password);
            //regData.UserName = userData.UserName;
            //regData.RoleId = userData.RoleId;

            return Ok();// regObj.Register(regData));
        }

    }
}
