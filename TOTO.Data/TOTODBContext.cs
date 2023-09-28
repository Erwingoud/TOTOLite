using Microsoft.EntityFrameworkCore;

namespace TOTO.Data
{
    public class TOTODBContext : DbContext
    {
        public TOTODBContext(DbContextOptions<TOTODBContext> options) : base(options)
        {
        }

        public DbSet<Prognosis> Prognosis { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed 100 entries with random values
            var random = new Random();
            var startDate = DateTime.Now.AddDays(-80);
            for (int i = 0; i < 100; i++)
            {
                var prognosis = new Prognosis
                {
                    Id = -(i + 1),
                    CustomersExpected = random.Next(200, 501), // Random value between 200 and 500 for CustomersExpected
                    ColliExpected = random.Next(30, 61),       // Random value between 30 and 60 for ColliExpected
                    PrognosisDate = startDate.AddDays(i)       // Date incrementing from 80 days in the past
                };

                modelBuilder.Entity<Prognosis>().HasData(prognosis);
            }
        }
    }
}