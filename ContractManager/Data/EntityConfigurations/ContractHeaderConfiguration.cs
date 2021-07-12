namespace ContractManager.Web.Data.EntityConfigurations
{
    using ContractManager.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class ContractHeaderConfiguration : IEntityTypeConfiguration<ContractHeader>
    {
        public void Configure(EntityTypeBuilder<ContractHeader> contractHeader)
        {
           
            contractHeader
                .HasOne(header => header.BankAccount)
                .WithMany(bankAccount => bankAccount.ContractHeaders)
                .HasForeignKey(fk => fk.BankAccountId)
                .OnDelete(DeleteBehavior.Restrict);

            contractHeader
                .HasOne(header => header.ClientCompany)
                .WithMany(clientCompany => clientCompany.ContractHeaders)
                .HasForeignKey(fk => fk.ClientCompanyId)
                .OnDelete(DeleteBehavior.Restrict);

            contractHeader
                .HasOne(header => header.Employee)
                .WithMany(employee => employee.ContractHeaders)
                .HasForeignKey(fk => fk.EmployeeId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}