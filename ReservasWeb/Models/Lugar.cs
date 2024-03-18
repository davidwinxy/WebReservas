using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ReservasWeb.Models
{
    public class Lugar : Controller
    {
        // GET: Lugar
        public ActionResult Index()
        {
            return View();
        }

        // GET: Lugar/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Lugar/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Lugar/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Lugar/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Lugar/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Lugar/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Lugar/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
