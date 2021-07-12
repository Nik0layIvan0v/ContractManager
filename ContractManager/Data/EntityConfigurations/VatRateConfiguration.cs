namespace ContractManager.Web.Data.EntityConfigurations
{
    using ContractManager.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class VatRateConfiguration : IEntityTypeConfiguration<VatRate>
    {
        public void Configure(EntityTypeBuilder<VatRate> vatRate)
        {
            vatRate
                .Property(x => x.Rate)
                .HasColumnType("decimal")
                .HasPrecision(2);
        }
    }
}
