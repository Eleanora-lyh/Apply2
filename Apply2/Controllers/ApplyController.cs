using Apply2.Config;
using Apply2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Apply2.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class ApplyController : ControllerBase
    {
        [HttpPost]
        public string AddApplies(ApplyContainer Apply)
        {
            Response.Headers.Add("Access-Control-Allow-Origin", "*");
            using (MyDbConext ctx = new())
            {
                ctx.ApplyContainers.Add(Apply);
                ctx.SaveChanges();
            }
            return "yes";
        }
    }
}
