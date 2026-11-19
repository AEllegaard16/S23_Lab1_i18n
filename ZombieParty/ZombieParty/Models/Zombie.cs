using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace ZombieParty.Models
{
    public class Zombie
    {
        public int Id { get; set; }

        [DisplayName("Name")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "ValidationRange")]
        public string Name { get; set; }

        [DisplayName("ShortDesc")]
        [StringLength(255, ErrorMessage = "ValidationStringMax")]
        public string ShortDesc { get; set; }

        [DisplayName("Point")]
        [Range(1, 20, ErrorMessage = "ValidationRange")]
        public int Point { get; set; }

        [DisplayName("Force")]
        public int Force { get; set; }

        [ValidateNever]
        [DisplayName("Image")]
        public string Image { get; set; }

        // FACULTATIF on peut formellement identifier le champ lien
        // sinon le champ de foreignKey sera auto généré dans la BD
        [DisplayName("ZombieType")]
        [ForeignKey("ZombieType")]
        public int ZombieTypeId { get; set; }
        [ValidateNever] 
        public virtual ZombieType? ZombieType { get; set; }

        [ValidateNever]
        [DisplayName("HuntingLogs")]
        public virtual List<HuntingLog> HuntingLogs { get; set; }
    }
}
