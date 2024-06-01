using Microsoft.EntityFrameworkCore;

namespace PoS.EntityFrameWork.TheCsharpAcademy
{
    internal class ProductContext : DbContext // 4 Install entity framework and inherit DbContext
    {
        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=PoSTutorial;Integrated Security=True";
        public DbSet<Product> products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => //5 Override optionbuilder
            optionsBuilder.UseSqlServer(connectionString);

    }
}
// #

// 6 Run add-migration initial-migration 
// 7 Run update-database