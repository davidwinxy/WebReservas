﻿using ReservasBL;
using ReservasEN;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReservasDAL;
using System.Security.Claims;

namespace ReservasWeb.Controllers
{
    public class Usercontroller : Controller
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
        public async Task<IActionResult> Login(string returnUrl)
        {
            ViewBag.Url = returnUrl;
            ViewBag.Error = "";
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(User pUser, string pReturnURL = null)
        {
            try
            {
                var user = await UserBL.Login(pUser);
                if (user != null && user.Id > 0 && pUser.UserName == user.UserName)
                {
                    user.Roles = await RoleBL.GetById(new Role { Id = user.RoleId });

                    var claims = new[] { new Claim(ClaimTypes.Name, user.UserName), new Claim(ClaimTypes.Role, user.Roles.Name) };
                    var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(identity));
                }
                else
                {
                    throw new Exception("Credenciales incorrectas");
                }
                if (!string.IsNullOrWhiteSpace(pReturnURL))
                {
                    return Redirect(pReturnURL);
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }

            }
            catch (Exception ex)
            {
                ViewBag.Url = pReturnURL;
                ViewBag.Error = ex.Message;
                return View(new User { UserName = pUser.UserName });
            }
        }
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "User");
        }

    }
}
