using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using my_vue_starter_new.Models.Entities;

namespace my_vue_starter_new.Data
{
    //interact with SQL database and Entities
    //UserInfo mapping

    public class ApplicationDbContext : IdentityDbContext<AppUser> {
        
        public ApplicationDbContext(DbContextOptions options) 
            : base(options)
            {

            }

            public DbSet<UserInfo> UserInfos {get; set;}
    }
}

