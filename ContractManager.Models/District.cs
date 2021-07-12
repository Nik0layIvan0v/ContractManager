namespace ContractManager.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using static Common.DatabaseConstants;

    public class District : BaseEntity
    {
        public District()
        {
            this.Municipalities = new HashSet<Municipality>();
        }

        [Required]
        [MaxLength(MaxDistrictSuffixLength)]
        public string DistrictSuffixCode { get; set; }

        [Required]
        [MaxLength(MaxLocationNameLength)]
        public string DistrictName { get; set; }

        public virtual ICollection<Municipality> Municipalities { get; set; }
    }
}