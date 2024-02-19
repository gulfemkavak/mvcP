using Microsoft.AspNetCore.Mvc;
using mvcP.Models;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace mvcP.Controllers
{
    public class PersonelController : Controller
    {
        context c=new context();
        public IActionResult Index()
        {
            var degerler = c.personels.Include(x => x.Birim).ToList();
            return View(degerler);
        }
        [HttpGet]
        public IActionResult YeniPersonel()
        {
            List<SelectListItem> degerler=(from x in c.Birims.ToList()
                                           select new SelectListItem
                                           {
                                               Text=x.BirimAd,
                                               Value=x.BirimID.ToString()
                                           }).ToList();
            ViewBag.Deger = degerler;    
            return View(); 
        }
        [HttpPost]  
        public IActionResult YeniPersonel(personel p)
        {
            var per= c.Birims.Where(x=>x.BirimID==p.Birim.BirimID).FirstOrDefault();
            p.Birim = per;
            c.personels.Add(p);
            c.SaveChanges();        
            return RedirectToAction("Index");  
        }

     
    }
}
