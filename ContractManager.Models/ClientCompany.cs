namespace ContractManager.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using static Common.DatabaseConstants;

    public class ClientCompany : BaseEntity
    {
        public ClientCompany()
        {
            this.Farms = new HashSet<Farm>();
            this.ContractHeaders = new HashSet<ContractHeader>();
        }

        [Required]
        [MaxLength(MaxEikLength)]
        //TODO: Regex validation before seed
        public string EikNumber { get; set; }

        [Required]
        [MaxLength(MaxVatNumberLength)]
        //TODO: Regex validation before seed
        public string VatNumber { get; set; }

        [Required]
        [MaxLength(MaxCompanyNameLength)]
        public string CompanyName { get; set; }

        [Required]
        public string CityId { get; set; }

        public City Ekatte { get; set; }

        [Required]
        [MaxLength(MaxAddressLength)]
        public string Address { get; set; }

        [MaxLength(MaxPhoneLength)]
        //TODO: Regex validation before seed
        public string Phone { get; set; }

        [MaxLength(MaxEmailLength)]
        //TODO: Validation before seed
        public string Email { get; set; }

        [Required]
        [MaxLength(MaxPeopleNamesLength)]
        public string OwnerName { get; set; }

        [Required]
        [MaxLength(MaxBossTittleLength)]
        public string OwnerTittle { get; set; }

        //TODO: Validation before seed
        [Required]
        [MaxLength(MaxEgnLength)]
        public string OwnerEgn { get; set; }

        public bool IsActive { get; set; } = true;

        [Required]
        public string OfficeId { get; set; }

        public Office Office { get; set; }

        public virtual ICollection<Farm> Farms { get; set; }

        public virtual ICollection<ContractHeader> ContractHeaders { get; set; }
    }
}
