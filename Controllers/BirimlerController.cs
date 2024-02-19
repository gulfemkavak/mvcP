using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using mvcP.Models;
namespace mvcP.Controllers
{
    public class BirimlerController : Controller
    {
        context c = new context();
        

        public IActionResult Index()
        {
            var degerler = c.Birims.ToList();
            return View(degerler);
        }
        
        [HttpGet]
        public IActionResult YeniDepartman()
        {
            return View();

        }
        [HttpPost]
        public IActionResult YeniDepartman(Birim d)
        {

            c.Birims.Add(d);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        
   public IActionResult DepartmanSil(int id)
   {
       var dep = c.Birims.Find(id);

       if (dep != null)
       {
           c.Birims.Remove(dep);
           c.SaveChanges();
       }
       else
       {
           // Örneğin: ModelState.AddModelError("BirimID", "Belirtilen BirimID'ye sahip departman bulunamadı.");
       }

       return RedirectToAction("Index"); 
}
        public IActionResult DepartmanGetir(int id)
        {
            var depart = c.Birims.Find(id);
            return View("DepartmanGetir", depart);
        }
        public IActionResult Guncelle(Birim d)
        {
            var dep = c.Birims.Find(d.BirimID);
            if (dep != null)
            {


                dep.BirimAd = d.BirimAd;
                c.SaveChanges();
            }
            else { }
            return RedirectToAction("Index");
        }

   




    }
}
