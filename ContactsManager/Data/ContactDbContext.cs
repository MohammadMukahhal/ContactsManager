using Microsoft.EntityFrameworkCore;

namespace ContactsManager.Data
{
    public class ContactDbContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }

        public ContactDbContext(DbContextOptions<ContactDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            Contact[] contactToSeed = new Contact[1];
            contactToSeed[0] = new Contact { Id = Guid.NewGuid(), FirstName = "Mohammad", LastName = "Mukahhal", Phone = "3134426680", BirthDate = new DateTime(2001, 01, 15) };
            modelBuilder.Entity<Contact>().HasData(contactToSeed);
        }
    }
}
