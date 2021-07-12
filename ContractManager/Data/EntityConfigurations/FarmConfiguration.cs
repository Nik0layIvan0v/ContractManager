namespace ContractManager.Web.Data.EntityConfigurations
{
    using ContractManager.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class FarmConfiguration : IEntityTypeConfiguration<Farm>
    {
        public void Configure(EntityTypeBuilder<Farm> farm)
        {
            farm
                .Property(x => x.Address)
                .IsUnicode();

            farm
                .Property(x => x.UniqueFarmNumber)
                .IsUnicode(false);

            farm
                .HasOne(location => location.Ekatte)
                .WithMany(city => city.Farms)
                .HasForeignKey(fk => fk.CityId)
                .OnDelete(DeleteBehavior.Restrict);

            farm
                .HasOne(x => x.ClientCompany)
                .WithMany(x => x.Farms)
                .HasForeignKey(fk => fk.ClientCompanyId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
