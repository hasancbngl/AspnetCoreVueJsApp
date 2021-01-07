using System;
using System.Threading.Tasks;
using System.Collections;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using my_vue_starter_new.Models.Entities;
using my_vue_starter_new.ViewModel;
using my_vue_starter_new.Data;
using AutoMapper;
using System.ComponentModel.DataAnnotations;

namespace my_vue_starter_new.Controllers
{
    //Api creating new users via standard email registration
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _appDbContext;
        private readonly UserManager<AppUser> _userManager;
        private readonly IMapper _mapper;

        public UserController(UserManager<AppUser> userManager, IMapper mapper, ApplicationDbContext appDbContext)
        {
            _userManager = userManager;
            _appDbContext = appDbContext;
            _mapper = mapper;
        }


        [HttpPost]
          public async Task<IActionResult> Post([FromBody]RegistrationViewModel model) {
           var userIdentity = _mapper.Map<AppUser>(model);

           await _userManager.CreateAsync(userIdentity, model.Password);
           await _appDbContext.UserInfos.AddAsync(new UserInfo {IdentityId=userIdentity.Id});
           await _appDbContext.SaveChangesAsync();

           return new OkObjectResult("Account created!");
       }
    }


}

