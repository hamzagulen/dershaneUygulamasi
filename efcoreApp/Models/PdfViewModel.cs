using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace efcoreApp.Models
{
    public class PdfViewModel
    {
        [Required(ErrorMessage = "Please select a file.")]
        [Display(Name = "PDF File")]
        public IFormFile File { get; set; } =null!;
    }
}
