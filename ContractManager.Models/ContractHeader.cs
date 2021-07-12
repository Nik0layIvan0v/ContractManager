namespace ContractManager.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class ContractHeader : BaseEntity
    {
        //TODO: check for column have Identity!
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ContractNumber { get; set; }

        public DateTime ContractDate { get; set; }

        public int ReferenceYear { get; set; }

        [Required]
        public string BankAccountId { get; set; }

        public BankAccount BankAccount { get; set; }

        [Required]
        public string ClientCompanyId { get; set; }

        public ClientCompany ClientCompany { get; set; }

        [Required]
        public string EmployeeId { get; set; }

        public Employee Employee { get; set; }

        public DateTime DateOfCreation { get; set; }

        public bool IsValid { get; set; } = true;
    }
}