using System.ComponentModel.DataAnnotations;

namespace Phinscal.Models
{
    public class RegistrationModel
    {
        [Required(ErrorMessage = "Korisničko ime mora biti upisano.")]
        public string? Username { get; set; }

        [Required(ErrorMessage = "Lozinka mora biti upisana.")]
        [MinLength(6, ErrorMessage = "Lozinka mora sadržavati minimalno 6 znakova.")]
        public string? Password { get; set; }

        [Compare("Password", ErrorMessage = "Lozinka i potvrda lozinke nisu iste.")]
        public string? ConfirmPassword { get; set; }

        [Required(ErrorMessage = "E-mail mora biti upisan.")]
        [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", ErrorMessage = "E-mail nije ispravan.")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Ime mora biti upisano.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Prezime mora biti upisano.")]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "Broj telefona je obavezan.")]
        [RegularExpression(@"^09\d{7,8}$", ErrorMessage = "Broj telefona nije ispravan.")]
        public string? PhoneNumber { get; set; }
    }
}
