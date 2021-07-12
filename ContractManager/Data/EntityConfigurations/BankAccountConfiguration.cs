namespace ContractManager.Web.Data.EntityConfigurations
{
    using ContractManager.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class BankAccountConfiguration : IEntityTypeConfiguration<BankAccount>
    {
        public void Configure(EntityTypeBuilder<BankAccount> bankAccount)
        {
            bankAccount
                .Property(name => name.BankName)
                .IsUnicode();

            bankAccount
                .HasOne(account => account.MainCompany)
                .WithMany(mCompany => mCompany.BankAccounts)
                .HasForeignKey(key => key.MainCompanyId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
