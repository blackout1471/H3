using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WrittenProject
{
    public abstract class Contract2
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ContractID { get; set; }

        [DataType(DataType.Date)]
        [Required]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date)]
        [Required]
        public DateTime EndDate { get; set; }
    }

    [Table("CreditContract2")]
    public class CreditContract2 : Contract2
    {
        [Required]
        public float CreditLimit { get; set; }

        [Column(TypeName = "char")]
        [StringLength(3)]
        [Required]
        public string CreditLimitCurrency { get; set; }
    }

    [Table("PrepaymentContract2")]
    public class PrepaymentContract2 : Contract2
    {
        [Required]
        public float PrepaymentAmount { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        [Required]
        public string PrepaymentPeriod { get; set; }
    }
}
