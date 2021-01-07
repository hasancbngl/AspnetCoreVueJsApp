using System;
using Microsoft.AspNetCore.Mvc;
using my_vue_starter_new.Models;

namespace my_vue_starter_new.Controllers
{
    [Route("api/[controller]")]
    public class RegisterController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            // get parameters
            // call provıders to do actıoooooon
            // return results
            return Ok();
        }

        [HttpPost]
        public IActionResult Index([FromBody]UserInfo userInfo)
        {
            return Ok(userInfo);
        } 

    }


}

