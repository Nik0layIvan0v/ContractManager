namespace ContractManager.Web.Data.EntityConfigurations
{
    using ContractManager.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class CityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> city)
        {
            city
                .Property(prop => prop.CityName)
                .IsUnicode();
        }
    }
}
