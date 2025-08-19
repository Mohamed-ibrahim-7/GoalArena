using Microsoft.AspNetCore.Mvc;

namespace GoalArena.Areas.Customer.Controllers
{
    [Area("Customer")]  
    public class News : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details(int id)
        {
            // هنا يمكنك إضافة منطق لجلب تفاصيل الخبر بناءً على المعرف
            // على سبيل المثال، يمكنك استخدام قاعدة البيانات لجلب الخبر
            // var newsItem = _context.News.FirstOrDefault(n => n.Id == id);
            // return View(newsItem);
            // في الوقت الحالي، سنعيد عرضًا بسيطًا
            return View();
        }
    }
}
