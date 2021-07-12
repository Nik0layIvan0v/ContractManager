namespace ContractManager.Web.Data
{
    using System.Reflection;
    using ContractManager.Models;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    public class ContractManagerDbContext : IdentityDbContext
    {
        public ContractManagerDbContext(DbContextOptions<ContractManagerDbContext> options)
            : base(options)
        {
        }

        public DbSet<BankAccount> BankAccounts { get; set; }

        public DbSet<City> Cities { get; set; }

        public DbSet<ClientCompany> ClientCompanies { get; set; }

        public DbSet<ContractDetail> ContractDetails { get; set; }

        public DbSet<ContractHeader> ContractHeaders { get; set; }

        public DbSet<District> Districts { get; set; }

        //public DbSet<Employee> Employees { get; set; }

        public DbSet<EmployeesOffice> EmployeesOffices { get; set; }

        public DbSet<Farm> Farms { get; set; }

        public DbSet<MainCompany> MainCompanies { get; set; }

        public DbSet<MilkControl> MilkControls { get; set; }

        public DbSet<Municipality> Municipalities { get; set; }

        public DbSet<Office> Offices { get; set; }

        public DbSet<PriceList> PriceLists { get; set; }

        public DbSet<VatRate> VatRates { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(builder);
        }
    }
}
