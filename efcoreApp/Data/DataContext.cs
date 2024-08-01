using Microsoft.EntityFrameworkCore;

namespace efcoreApp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }
        public DbSet<Kurs> Kurslar { get; set; }
        public DbSet<Ogrenci> Ogrenciler { get; set; }
        public DbSet<KursKayit> KursKayitlari { get; set; }
        public DbSet<Ogretmen> Ogretmenler { get; set; }
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<PdfDocument> PdfDocuments { get; set; }


    }
}