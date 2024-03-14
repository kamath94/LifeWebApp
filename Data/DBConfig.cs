using lifedashboard.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace lifedashboard.Data
{
    public class DBConfig : DbContext
    {
        public DBConfig(DbContextOptions<DBConfig> option) : base(option)
        {

        }
        public DbSet<MembeDetails> MemberDetails { get; set; }
        public DbSet<FeeCollection> FeeCollection { get; set; }
        public DbSet<PresentLog> PresentLog { get; set; }
        public DbSet<AddPlans> AddPlans { get; set; }

    }
}
