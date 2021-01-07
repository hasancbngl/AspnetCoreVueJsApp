using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace my_vue_starter_new.Models.Entities
{
    //IdentityUser class provides convenient entity to store the data
    //maps to a table in database
    public class AppUser : IdentityUser
     {
         public string FullName { get; set; }
         public string UserEmail { get; set; }
         public string Password { get; set; }
         public string Birthdate { get; set; }
    } 


}