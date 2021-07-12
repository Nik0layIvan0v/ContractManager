namespace ContractManager.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using static Common.DatabaseConstants;

    public class MainCompany : BaseEntity
    {
        public MainCompany()
        {
            this.Offices = new HashSet<Office>();
            this.BankAccounts = new HashSet<BankAccount>();
        }

        [Required]
        [MaxLength(MaxEikLength)]
        //TODO: Validation Before seed.
        public string EikNumber { get; set; }

        [Required]
        [MaxLength(MaxVatNumberLength)]
        //TODO: Validation Before seed.
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

        //TODO: Regex
        [MaxLength(MaxPhoneLength)]
        public string Phone { get; set; }

        //TODO: validate
        [MaxLength(MaxEmailLength)]
        public string Email { get; set; }

        //TODO: Validate
        [Required]
        [MaxLength(MaxPeopleNamesLength)]
        public string BossName { get; set; }

        //TODO: Validate
        [Required]
        [MaxLength(MaxBossTittleLength)]
        public string BossTittle { get; set; }

        //TODO: Regex
        [Required]
        [MaxLength(MaxEgnLength)]
        public string BossEgn { get; set; }

        [Required]
        [MaxLength(MaxIbanNumberLength)]
        public string IbanNumber { get; set; }

        public virtual ICollection<Office> Offices { get; set; }

        public virtual ICollection<BankAccount> BankAccounts { get; set; }
    }
}