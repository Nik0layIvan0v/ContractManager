namespace ContractManager.Web.Data.EntityConfigurations
{
    using ContractManager.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class OfficeConfiguration : IEntityTypeConfiguration<Office>
    {
        public void Configure(EntityTypeBuilder<Office> office)
        {
            office
                .Property(x => x.OfficeName)
                .IsUnicode();

            office
                .HasOne(x => x.MainCompany)
                .WithMany(x => x.Offices)
                .HasForeignKey(fk => fk.MainCompanyId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
