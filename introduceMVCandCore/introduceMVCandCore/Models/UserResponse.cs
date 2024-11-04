using System.ComponentModel.DataAnnotations;

namespace introduceMVCandCore.Models
{
    public class UserResponse
    {
        [Required(ErrorMessage ="Adınızı belirtmeyi unutmayınız.")]
        public string FullName { get; set; }


        [Required(ErrorMessage = "E-postayı belirtmeyi unutmayınız.")]
        [EmailAddress(ErrorMessage ="E-posta formatı uygun değil")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Lütfen yanıtınızı seçiniz.", AllowEmptyStrings =false)]
        public bool IsComing { get; set; }
    }
}
