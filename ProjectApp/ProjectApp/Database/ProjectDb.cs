using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjectApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectApp.Database
{
    public class ProjectDb : IdentityDbContext<ProjectUser>
    {
        public ProjectDb(DbContextOptions<ProjectDb> options) : base(options)
        {

        }
    }
}
