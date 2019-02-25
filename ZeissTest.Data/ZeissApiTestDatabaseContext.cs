using ZeissTest.Data.Entities;
using System.Data.Entity;

namespace ZeissTest.Data
{
    public class ZeissTestDatabaseContext : DbContext
    {
        public ZeissTestDatabaseContext()
            : base("ZeissTest")
        {
        }

        public DbSet<Machine> Machine { get; set; }

        //public DbSet<MachineHistory> MachineHistory { get; set; }
    }
}
