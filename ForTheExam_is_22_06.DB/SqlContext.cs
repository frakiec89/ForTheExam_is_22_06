using Microsoft.EntityFrameworkCore;
// track

namespace ForTheExam_is_22_06.DB
{
    public class SqlContext : DbContext
    {
        public SqlContext() { }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString());
        }

        private string connectionString()
        {
            return
                  "server=192.168.59.63; database =ForTheExam_is_22_06_aht; user id = stud ; password = stud; TrustServerCertificate =true; ";
        }

        public DbSet<User> Users { get; set; }
    }
}
