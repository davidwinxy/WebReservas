using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ReservasWeb.Controllers
{
    public class Reservascontroller : Controller
    {
        // GET: Reservascontroller
        public ActionResult Index()
        {
            return View();
        }

        // GET: Reservascontroller/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Reservascontroller/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Reservascontroller/Create
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

        // GET: Reservascontroller/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Reservascontroller/Edit/5
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

        // GET: Reservascontroller/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Reservascontroller/Delete/5
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
