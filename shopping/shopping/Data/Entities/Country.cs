using System.ComponentModel.DataAnnotations;

namespace shopping.Data.Entities
{
    public class Country
    {

        public int id { get; set; }

        [Required(ErrorMessage = "Field {0} is required")]
        [MaxLength(50, ErrorMessage = "field {0} mysbe maximum {1} characters")]
        [Display(Name = "Country")]
        public string Name { get; set; }

    }
}
