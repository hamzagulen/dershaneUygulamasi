// Models/Kullanici.cs
using System.ComponentModel.DataAnnotations;

namespace efcoreApp.Data
{
    public class Kullanici
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "TC Kimlik alanı boş bırakılamaz.")]
        public string? TcKimlik { get; set; }
        
        [Required(ErrorMessage = "Şifre alanı boş bırakılamaz.")]
        public string? Sifre { get; set; }

        [Required(ErrorMessage = "Ad alanı boş bırakılamaz.")]
        public string? Ad { get; set; }

        [Required(ErrorMessage = "Soyad alanı boş bırakılamaz.")]
        public string? Soyad { get; set; }

        [Required(ErrorMessage = "E-posta alanı boş bırakılamaz.")]
        [EmailAddress(ErrorMessage = "Geçersiz e-posta adresi.")]
        public string? Email { get; set; }

        [Phone(ErrorMessage = "Geçersiz telefon numarası.")]
        public string? Telefon { get; set; }
    }
}
