namespace ContractManager.Models
{
    using System.ComponentModel.DataAnnotations;
    using static Common.DatabaseConstants;

    public class Farm : BaseEntity
    {
        [Required]
        [MaxLength(MaxUniqueFarmNumberLength)]
        public string UniqueFarmNumber { get; set; }

        [Required]
        public string CityId { get; set; }

        public City Ekatte { get; set; }

        [Required]
        [MaxLength(MaxLocationNameLength)]
        public string Address { get; set; }

        [Required]
        public string ClientCompanyId { get; set; }

        public ClientCompany ClientCompany { get; set; }
    }
}