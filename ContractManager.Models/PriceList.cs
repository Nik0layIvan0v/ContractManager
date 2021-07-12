namespace ContractManager.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class PriceList : BaseEntity
    {
        [Required]
        public string MilkControlId { get; set; }

        public MilkControl MilkControl { get; set; }

        public DateTime Year { get; set; }

        public int MinCows { get; set; }

        public int MaxCows { get; set; }

        public decimal Price { get; set; }
    }
}