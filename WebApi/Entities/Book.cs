using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Entities
{
    public class Book
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Required(ErrorMessage ="Введите названия"),StringLength(maximumLength: 55,
            ErrorMessage ="Число символов должен содержать  до 50 символов",MinimumLength =2)]
        public string Name { get; set; }
        public string Descrption { get; set; }

    }
}
