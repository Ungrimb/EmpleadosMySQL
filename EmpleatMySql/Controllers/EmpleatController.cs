using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmpleatMySql.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmpleatMySql.Controllers
{
    public class EmpleatController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            EmpleatContext context = HttpContext.RequestServices.GetService(typeof(EmpleatMySql.Models.EmpleatContext)) as EmpleatContext;

            return View(context.GetAll());
        }

        // POST: EmpleatController/Create
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

        // GET: EmpleatController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EmpleatController/Edit/5
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

        // GET: EmpleatController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmpleatController/Delete/5
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
