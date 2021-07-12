using ContractManager.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ContractManager.Web.Data.EntityConfigurations
{
    public class ContractDetailConfiguration : IEntityTypeConfiguration<ContractDetail>
    {
        public void Configure(EntityTypeBuilder<ContractDetail> contractDetail)
        {
            contractDetail
                .Property(x => x.Price)
                .HasColumnType("decimal")
                .HasPrecision(2);

            contractDetail
                .HasOne(detail => detail.VatRate)
                .WithMany(vatRate => vatRate.ContractDetails)
                .HasForeignKey(fk => fk.VatRateId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}