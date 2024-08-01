using System.ComponentModel.DataAnnotations;

namespace efcoreApp.Data
{
    public class PdfDocument
    {
        public int Id { get; set; }

        [Required]
        public string FileName { get; set; } =null!;

        [Required]
        public byte[] Content { get; set; } =null!;  // Dosya içeriğini byte dizisi olarak saklayacağız

        // Eğer dosya adına da ihtiyacınız varsa, FileName özelliğini kullanabilirsiniz
    }
}
