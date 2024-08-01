using System.Linq;
using efcoreApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication; // Ekledik
using Microsoft.AspNetCore.Http; // Ekledik
using System.Security.Claims;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authentication.Cookies;


public class KullaniciController : Controller
{
    private readonly DataContext _context;

    public KullaniciController(DataContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Login(Kullanici model)
    {
        var user = await _context.Kullanicilar.FirstOrDefaultAsync(u => u.TcKimlik == model.TcKimlik && u.Sifre == model.Sifre);

        if (user != null)
        {
            // Giriş başarılı, yönlendirme yapabilirsiniz
            var identity = new ClaimsIdentity(new[] {
                new Claim(ClaimTypes.Name, user.TcKimlik),
                // Burada kullanıcı rolleri veya diğer iddialar eklenebilir
            }, CookieAuthenticationDefaults.AuthenticationScheme);

            var principal = new ClaimsPrincipal(identity);
            await HttpContext.SignInAsync(principal);

            return RedirectToAction("Index", "Home");
        }
        else
        {
            // Giriş başarısız, hata mesajı ekleme işlemleri yapılabilir
            ModelState.AddModelError(string.Empty, "Geçersiz TC Kimlik veya Şifre");
            return View(model);
        }
    }

    [HttpGet]
    public IActionResult Register()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Register(Kullanici model)
    {
        if (ModelState.IsValid)
        {
            _context.Kullanicilar.Add(model);
            await _context.SaveChangesAsync();
            return RedirectToAction("Login");
        }

        return View(model);
    }

    [HttpGet]


[HttpGet]
public IActionResult Profil()
{
    // HttpContext.User'daki Identity özelliğinin IsAuthenticated özelliğini kontrol ediyoruz
    if (HttpContext.User?.Identity?.IsAuthenticated ?? false)
    {
        // Kullanıcının oturum açık olduğunu varsayalım ve kullanıcının TC Kimlik bilgisini alalım
        string tcKimlik = HttpContext.User.Identity.Name;

        // TC Kimlik bilgisine göre kullanıcıyı veritabanından çekelim
        var user = _context.Kullanicilar.FirstOrDefault(u => u.TcKimlik == tcKimlik);

        // Kullanıcı bilgilerini kontrol edelim
        if (user == null)
        {
            // Kullanıcı bilgileri alınamazsa, uygun bir hata sayfasına yönlendirin (örneğin NotFound())
            return NotFound();
        }

        // Kullanıcı bilgileri başarıyla alınırsa, bu bilgileri Profil görünümüne aktarın
        return View(user);
    }
    else
    {
        // Kullanıcı oturum açık değilse, oturum açma sayfasına yönlendir
        return RedirectToAction("Login");
    }
}



}
