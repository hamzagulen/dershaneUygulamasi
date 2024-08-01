using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.IO;
using System.Threading.Tasks;
using efcoreApp.Data;
using efcoreApp.Models;

namespace efcoreApp.Controllers
{
    public class PdfController : Controller
    {
        private readonly DataContext _context;

        public PdfController(DataContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UploadPdf(PdfViewModel model)
        {
            if (ModelState.IsValid)
            {
                using (var memoryStream = new MemoryStream())
                {
                    await model.File.CopyToAsync(memoryStream);
                    var pdf = new PdfDocument
                    {
                        FileName = model.File.FileName,
                        Content = memoryStream.ToArray()
                    };
                    _context.PdfDocuments.Add(pdf);
                    await _context.SaveChangesAsync();
                }
                return RedirectToAction("Index");
            }
            return View("Index", model);
        }

        public IActionResult ListPdfDocuments()
        {
         var pdfDocuments = _context.PdfDocuments.ToList();
         return View(pdfDocuments);
        }

        public async Task<IActionResult> ViewPdf(int id)
        {
          var pdf = await _context.PdfDocuments.FindAsync(id);
         if (pdf != null)
         {
        return File(pdf.Content, "application/pdf");
         }
          return NotFound();
        }




   }
}
