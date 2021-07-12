namespace ContractManager.Web.Data.EntityConfigurations
{
    using ContractManager.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class MainCompanyConfiguration : IEntityTypeConfiguration<MainCompany>
    {
        public void Configure(EntityTypeBuilder<MainCompany> mainCompany)
        {
            mainCompany
                .Property(x => x.CompanyName)
                .IsUnicode();

            mainCompany
                .HasOne(company => company.Ekatte)
                .WithMany(city => city.MainCompanies)
                .HasForeignKey(fk => fk.CityId)
                .OnDelete(DeleteBehavior.Restrict);

            mainCompany
                .Property(company => company.Address)
                .IsUnicode();

            mainCompany
                .Property(company => company.BossName)
                .IsUnicode();

            mainCompany
                .Property(company => company.BossTittle)
                .IsUnicode();
        }
    }
}