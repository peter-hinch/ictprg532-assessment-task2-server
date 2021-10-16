using AssessmentTask2Server.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssessmentTask2Server.DbContexts
{
    public class RecordDbContext : DbContext
    {
        public RecordDbContext(DbContextOptions<RecordDbContext> options)
            : base(options)
        {
        }

        public DbSet<Record> Records { get; set; }
    }
}
