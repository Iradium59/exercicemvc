using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ExerciceMVC.Models;

namespace ExerciceMVC.Data
{
    public class ExerciceMVCContext : DbContext
    {
        public ExerciceMVCContext (DbContextOptions<ExerciceMVCContext> options)
            : base(options)
        {
        }

        public DbSet<ExerciceMVC.Models.Contact> Contact { get; set; } = default!;
        public DbSet<ExerciceMVC.Models.Todo> Todo { get; set; } = default!;
    }
}
