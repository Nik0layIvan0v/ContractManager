namespace ContractManager.Web.Data.EntityConfigurations
{
    using ContractManager.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class EmployeeOfficeConfiguration : IEntityTypeConfiguration<EmployeesOffice>
    {
        public void Configure(EntityTypeBuilder<EmployeesOffice> employeesOffice)
        {
            employeesOffice
                .HasKey(x => new { x.EmployeeId, x.OfficeId });

            employeesOffice
                .HasOne(x => x.Employee)
                .WithMany(x => x.EmployeesOffices)
                .HasForeignKey(fk => fk.OfficeId)
                .OnDelete(DeleteBehavior.Restrict);

            employeesOffice
                .HasOne(x => x.Office)
                .WithMany(x => x.EmployeesOffices)
                .HasForeignKey(fk => fk.OfficeId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
