namespace ContractManager.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using static Common.DatabaseConstants;

    public class BankAccount : BaseEntity
    {
        public BankAccount()
        {
            this.ContractHeaders = new HashSet<ContractHeader>();
        }
        //TODO: Validate
        [Required]
        [MaxLength(MaxIbanNumberLength)]
        public string IbanNumber { get; set; }

        [Required]
        [MaxLength(MaxBicCodeLength)]
        public string BicCodeNumber { get; set; }

        [Required]
        [MaxLength(MaxBankNameLength)]
        public string BankName { get; set; }

        [Required]
        public string MainCompanyId { get; set; }

        public MainCompany MainCompany { get; set; }

        public ICollection<ContractHeader> ContractHeaders { get; set; }
    }
}