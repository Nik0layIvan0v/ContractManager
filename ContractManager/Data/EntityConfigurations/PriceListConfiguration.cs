namespace ContractManager.Web.Data.EntityConfigurations
{
    using ContractManager.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class PriceListConfiguration : IEntityTypeConfiguration<PriceList>
    {
        public void Configure(EntityTypeBuilder<PriceList> priceList)
        {
            priceList
                .Property(x => x.Price)
                .HasColumnType("decimal")
                .HasPrecision(2);

            priceList
                .HasOne(list => list.MilkControl)
                .WithMany(milkControl => milkControl.PriceLists)
                .HasForeignKey(fk => fk.MilkControlId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
