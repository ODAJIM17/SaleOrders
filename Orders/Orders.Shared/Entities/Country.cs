using Orders.Shared.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Orders.Shared.Entities
{
    public class Country : IEntityWithName
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Country")]
        [MaxLength(100, ErrorMessage = "Field {0} allows max {1} characters")]
        [Required(ErrorMessage = "Field {0} is required.")]
        public string Name { get; set; } = null!;

        public ICollection<State>? States { get; set; }

        [Display(Name = "States")]
        public int StatesNumber => States == null || States.Count == 0 ? 0 : States.Count;

        ///[Display(Name = "Cities")]
        // public int CitiesCount => States == null ? 0 : States.Sum(s => s.CitiesCount);
    }
}