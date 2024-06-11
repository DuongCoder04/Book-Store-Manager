using System.Data.Entity;
using WindowsFormsApp.Models;

namespace WindowsFormsApp.DataService
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base("name = BSM_connectionString")
        {
            var initializer = new MigrateDatabaseToLatestVersion<MyDbContext, Migrations.Configuration>();
            Database.SetInitializer(initializer);
        }
        public virtual DbSet<Book> myBooks { get; set; }
        public virtual DbSet<Category> myCategory { get; set; }
        public virtual DbSet<Authors> myAuthors { get; set; }
        public virtual DbSet<Publisher> myPublisher { get; set; }
        public virtual DbSet<Staff> myStaff { get; set; }
        public virtual DbSet<User> myUser { get; set; }
        public virtual DbSet<Bill> myBill { get; set; }
        public virtual DbSet<BillInfo> myBillInfo { get; set; }

        private void SeedDefaultUser()
        {
            var defaultUser = new User
            {
                UserName = "admin",
                Password = CryptoLib.Encryptor.MD5Hash("admin"),
                Permision = "quản lý"
            };

            this.myUser.Add(defaultUser);
            this.SaveChanges();
        }
    }
}
//enable-migrations -EnableAutomaticMigration:$true
//Add-Migration Initial -IgnoreChanges
//Update-Database -verbose