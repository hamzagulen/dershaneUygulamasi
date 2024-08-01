// HelloWorldViewComponent.cs
using Microsoft.AspNetCore.Mvc;

namespace efcoreApp.ViewComponents
{
    public class TextViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("Default");
        }
    }
}
