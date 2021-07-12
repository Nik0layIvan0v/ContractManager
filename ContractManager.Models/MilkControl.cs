namespace ContractManager.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using static Common.DatabaseConstants;

    public class MilkControl : BaseEntity
    {
        public MilkControl()
        {
            this.PriceLists = new HashSet<PriceList>();
        }

        [Required]
        [MaxLength(MaxControlNameLength)]
        public string ControlName { get; set; }

        public bool IsActive { get; set; } = true;

        public virtual ICollection<PriceList> PriceLists { get; set; }
    }
}