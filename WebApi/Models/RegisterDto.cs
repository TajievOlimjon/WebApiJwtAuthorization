using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace WebApi.Models
{
    public class RegisterDto
    {
        [Display(Name = "Имя")]
        [Required(ErrorMessage = "Введите имя")]
        public string FirstName { get; set; }
        [Display(Name = "Фамилия")]
        [Required(ErrorMessage = "Введите фамилию")]
        public string LastName { get; set; }

        [Display(Name = "Отчество")]
        [Required(ErrorMessage = "Введите отчество")]
        public string MiddleName { get; set; }

        [Display(Name = "Логин")]
        [Required(ErrorMessage = "Введите логин")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Введите электронную почту")]
        [Display(Name = "Электронная почта")]
        [EmailAddress(ErrorMessage ="Неправилная электронная почта")]
       // [RegularExpression(pattern:$"/^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$/g")]
        public string Email { get; set; }
        [Display(Name = "Номер телефона")]
        [Required(ErrorMessage = "Введите номер телефона")]
        public string PhoneNumber { get; set; }
        [Display(Name = "Пароль")]
        [Required(ErrorMessage ="Введите пароль")]
        public string Password { get; set; }
        
    }
}
