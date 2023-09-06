using Microsoft.EntityFrameworkCore;

namespace DesignPattern.CQRS.DAL
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //data source=(LocalDb)\MSSQLLocalDB;initial catalog=DataProje;integrated security=True;" providerName="System.Data.SqlClient//
            optionsBuilder.UseSqlServer("server=(LocalDb)\\MSSQLLocalDB;initial catalog=DesignPattern2;integrated security=True;");

        }
        public DbSet<Product> Products { get; set; }
    }
}
