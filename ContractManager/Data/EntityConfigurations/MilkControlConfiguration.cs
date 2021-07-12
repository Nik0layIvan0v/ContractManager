namespace ContractManager.Web.Data.EntityConfigurations
{
    using ContractManager.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class MilkControlConfiguration : IEntityTypeConfiguration<MilkControl>
    {
        public void Configure(EntityTypeBuilder<MilkControl> milkControl)
        {
            milkControl
                .Property(control => control.ControlName)
                .IsUnicode();
        }
    }
}
