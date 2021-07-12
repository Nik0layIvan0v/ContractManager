namespace ContractManager.Models
{
    using System;
    using System.Collections.Generic;

    public class VatRate : BaseEntity
    {
        public VatRate()
        {
            this.ContractDetails = new HashSet<ContractDetail>();
        }

        public DateTime DateValidFrom { get; set; }

        public decimal Rate { get; set; }

        public virtual ICollection<ContractDetail> ContractDetails { get; set; }
    }
}