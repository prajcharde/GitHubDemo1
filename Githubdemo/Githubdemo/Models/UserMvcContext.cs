using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Githubdemo.Models
{
    public class UserMvcContext:DbContext
    {
        public UserMvcContext():base("name=MyConnection")
        {

        }
        public DbSet<UserMvc> UserMvcs { get; set; }
    }
}