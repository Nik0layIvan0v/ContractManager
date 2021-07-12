namespace ContractManager.Web.Data.EntityConfigurations
{
    using ContractManager.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;


    public class DistrictConfiguration : IEntityTypeConfiguration<District>
    {
        public void Configure(EntityTypeBuilder<District> district)
        {
            district
                .Property(x => x.DistrictSuffixCode)
                .IsUnicode(false);

            district
                .Property(x => x.DistrictName)
                .IsUnicode();
        }
    }
}
