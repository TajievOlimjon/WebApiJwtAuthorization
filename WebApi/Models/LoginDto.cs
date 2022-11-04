using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
    public class LoginDto
    {
        [Required(ErrorMessage ="Введите логин ?")]
        [Display(Name ="Логин")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Введите пароль ?")]
        [Display(Name = "Пароль")]
        public string Password { get; set; }

    }
}
