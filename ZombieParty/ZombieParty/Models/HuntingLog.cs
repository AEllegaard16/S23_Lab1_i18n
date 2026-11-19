using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace ZombieParty.Models
{
    public class HuntingLog
    {
        public int Id { get; set; }

        [DisplayName("Title")]
        [StringLength(25, MinimumLength = 5, ErrorMessage = "ValidationRange")]
        public string Title { get; set; }

        [DisplayName("Description")]
        [StringLength(255, ErrorMessage = "ValidationStringMinMax")]
        public string Description { get; set; }

        public DateTime AdventureDate { get; set; }

        [ValidateNever]
        [Display(Name = "Zombies")]
        public virtual List<Zombie> Zombies { get; set; }
    }
}
