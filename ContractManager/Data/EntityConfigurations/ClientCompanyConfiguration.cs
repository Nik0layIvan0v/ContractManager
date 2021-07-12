namespace ContractManager.Web.Data.EntityConfigurations
{
    using ContractManager.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class ClientCompanyConfiguration : IEntityTypeConfiguration<ClientCompany>
    {
        public void Configure(EntityTypeBuilder<ClientCompany> clientCompany)
        {
            clientCompany
                .HasOne(company => company.Ekatte)
                .WithMany(city => city.ClientCompanies)
                .HasForeignKey(key => key.CityId)
                .OnDelete(DeleteBehavior.Restrict);

            clientCompany
                .HasOne(company => company.Office)
                .WithMany(office => office.ClientCompanies)
                .OnDelete(DeleteBehavior.Restrict);

            clientCompany
                .Property(x => x.CompanyName)
                .IsUnicode();

            clientCompany
                .Property(x => x.Address)
                .IsUnicode();

            clientCompany
                .Property(owner => owner.OwnerName)
                .IsUnicode();

            clientCompany
                .Property(owner => owner.OwnerTittle)
                .IsUnicode();
        }
    }
}
