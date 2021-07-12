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
                .HasOne(detail => detail.VatRate)
                .WithMany(vatRate => vatRate.ContractDetails)
                .HasForeignKey(fk => fk.VatRateId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}