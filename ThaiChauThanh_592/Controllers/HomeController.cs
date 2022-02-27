using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ThaiChauThanh_592.Controllers
{
    public class HomeController : Controller
    {
        private Models.ModelBangluong dc = new Models.ModelBangluong();
        // GET: Home
        public ActionResult Index()
        {
            return View(dc.bangluongs.ToList());
        }
        public ActionResult FormXoaBangLuong(string id)
        {
            Models.bangluong p = dc.bangluongs.Find(id);
            if (p == null)
            {
                return View("Index", dc.bangluongs.ToList());
            }
            if (p.chitietbangluongs.Count > 0)
            {
                ViewBag.isDelete = false;
                ViewBag.message = "Bạn không thể xóa bảng lương này!!";
                return View("FormXoaBangLuong", p);
            }
            ViewBag.isDelete = true;
            ViewBag.message = "Bạn có thực sự muốn xóa không?";
            return View(p);
        }
        public ActionResult XoaBangLuong(string id)
        {
            Models.bangluong p = dc.bangluongs.Find(id);
            if (p == null)
            {
                return View("Index", dc.bangluongs.ToList());
            }
            if (p.chitietbangluongs.Count > 0)
            {
                ViewBag.isDelete = false;
                ViewBag.message = "Bạn không thể xóa bảng lương này!!";
                return View("FormXoaBangLuong", p);
            }
            dc.bangluongs.Remove(p);
            dc.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult xemChiTiet(string id)
        {
            Models.bangluong bl = dc.bangluongs.Find(id);
            Models.nhancong a = new Models.nhancong();
            return View(bl);
        }
        public ActionResult FormThemCTBL(string id)
        {
            ViewBag.id = id;
            ViewBag.manc = new SelectList(dc.nhancongs.ToList(), "manc", "manc");
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult xuliThem(Models.chitietbangluong chitiet)
        {

            if (chitiet == null)

            {
                return View("Index", dc.bangluongs.ToList());
            }
            Models.bangluong p = dc.bangluongs.Find(chitiet.luongky);
            dc.chitietbangluongs.Add(chitiet);
            dc.SaveChanges();
            return View("xemChiTiet", p);
        }
    }
}