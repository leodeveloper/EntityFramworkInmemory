using Microsoft.EntityFrameworkCore;
using Model.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Service
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Post> Posts { get; set; }
    }
}
