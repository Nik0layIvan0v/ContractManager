namespace ContractManager.Models
{
    using System;
    using System.Collections.Generic;

    public class ContractDetail : BaseEntity
    {
        public ContractDetail()
        {
            this.MilkControls = new HashSet<MilkControl>();
        }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public string VatRateId { get; set; }

        public VatRate VatRate { get; set; }

        public decimal QuantityPerPrice => Math.Round((this.Price * this.Quantity), 2);

        public decimal VatValue => Math.Round((this.QuantityPerPrice * (this.VatRate.Rate / 100)), 2);

        public virtual ICollection<MilkControl> MilkControls { get; set; }
    }
}