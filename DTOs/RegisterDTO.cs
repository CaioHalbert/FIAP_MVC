using System.ComponentModel.DataAnnotations;

namespace FIAP_MVC.DTOs
{
    public class RegisterDTO
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        [EmailAddress]
        public string UserEmail { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string UserPassword { get; set; }
        [DataType(DataType.Password)]
        [Compare("UserPassword", ErrorMessage = "As senhas não coincidem.")]
        public string ComparePassword { get; set; }
        public string UserPhone { get; set; }
    }
}
