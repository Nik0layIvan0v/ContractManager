namespace ContractManager.Web.Data.EntityConfigurations
{
    using ContractManager.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class MunicipalityConfiguration : IEntityTypeConfiguration<Municipality>
    {
        public void Configure(EntityTypeBuilder<Municipality> municipality)
        {
            municipality
                .HasOne(m => m.District)
                .WithMany(district => district.Municipalities)
                .HasForeignKey(fk => fk.DistrictId)
                .OnDelete(DeleteBehavior.Restrict);

            municipality
                .Property(x => x.MunicipalitySuffixCode)
                .IsUnicode(false);

            municipality
                .Property(x => x.MunicipalityName)
                .IsUnicode();
        }
    }
}