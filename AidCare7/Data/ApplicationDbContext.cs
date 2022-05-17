using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using AidCare7.Models;

namespace AidCare7.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<AidCare7.Models.member> member { get; set; }
        public DbSet<AidCare7.Models.Event> Event { get; set; }
        public DbSet<AidCare7.Models.donation> donation { get; set; }
    }
}
