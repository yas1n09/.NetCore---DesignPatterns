using Microsoft.EntityFrameworkCore;

namespace DesignPattern.ChainOfResponsibilty.DAL
{
    public class Context : DbContext
    {
        //veritabanını ayağa kaldırma//
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //data source=(LocalDb)\MSSQLLocalDB;initial catalog=DataProje;integrated security=True;" providerName="System.Data.SqlClient//
            optionsBuilder.UseSqlServer("server=(LocalDb)\\MSSQLLocalDB;initial catalog=DesignPattern1;integrated security=True;");

        }
        public DbSet<CustomerProcess> customerProcesses { get; set; }
    }
}
