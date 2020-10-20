using System;
using System.Collections.Generic;
using System.Text;
using SilverTongueTypewriter.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace SilverTongueTypewriter.Data
{
    //Auto-generated class. I'll add the models here.
    public class ApplicationDbContext : IdentityDbContext
    {
        //reference the models.
        public DbSet<Author> Authors {get; set;}
        public DbSet<WrittenWork> WrittenWorks {get;set;}

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        //override the method when the model is created. Bug fix.

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
