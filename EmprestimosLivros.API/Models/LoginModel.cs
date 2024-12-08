using System.ComponentModel.DataAnnotations;

namespace EmprestimosLivros.API.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "O e-mail é óbrigatório")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "A senha é óbrigatória")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}
