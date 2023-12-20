using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MyProject.Data.Model
{
    public class Credit
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Vytvořeno")]
        public DateTime Created { get; set; }

        [DisplayName("Hodnocení")]
        [Required(ErrorMessage = "Toto pole je povinné")]
        [Range(1, 5, ErrorMessage = "Hodnota musí být mezi 1 a 5.")]
        public int Value { get; set; }
        
        [DisplayName("Uspěl")]
        [Required(ErrorMessage = "Toto pole je povinné")]
        public bool Success { get; set; }
    }
}
