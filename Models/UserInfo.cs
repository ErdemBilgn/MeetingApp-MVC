using System.ComponentModel.DataAnnotations;

namespace MeetingApp.Models
{
    public class UserInfo
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ad alanı boş bırakılamaz")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Telefon alanı boş bırakılamaz.")]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "Email alanı boş bırakılamaz.")]
        [EmailAddress(ErrorMessage = "Hatalı eposta")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Lütfen katılım durumunuzu belirtiniz.")]
        public bool? WillAttend { get; set; }
    }
}