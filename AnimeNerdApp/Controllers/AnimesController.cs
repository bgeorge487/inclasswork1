using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnimeNerdApp.Models;

namespace AnimeNerdApp.Controllers
{
    public class AnimesController : Controller
    {
        // GET: AnimesController
        public ActionResult Index()
        {
            List<Anime> result = null;
            using (AnimeContext context = new AnimeContext())
            {
                result = context.Anime.ToList();
            }
            return View(result);
        }

        

        // GET: AnimesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AnimesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AnimesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                using (AnimeContext context = new AnimeContext())
                {
                    Anime anime = new Anime();
                    anime.Name = collection["Name"];
                    anime.Genre = collection["Genre"];
                    anime.NumberOfHusbandos = int.Parse(collection["NumberOfHusbandos"]);
                    anime.NumberOfEpisodes = int.Parse(collection["NumberOfEpisodes"]);

                    context.Anime.Update(anime);
                    context.SaveChanges();
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AnimesController/Edit/5
        public ActionResult Edit(int id)
        {
            Anime result = null;
            using(AnimeContext context = new AnimeContext())
            {
                result = context.Anime.Where(x => x.AnimeId == id).First();
            }
            return View(result);
        }

        // POST: AnimesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                using(AnimeContext context = new AnimeContext())
                {
                    Anime anime = context.Anime.Where(x => x.AnimeId == id).First();
                    anime.Name = collection["Name"];
                    anime.Genre = collection["Genre"];
                    anime.NumberOfHusbandos = int.Parse(collection["NumberOfHusbandos"]);
                    anime.NumberOfEpisodes = int.Parse(collection["NumberOfEpisodes"]);

                    context.Anime.Update(anime);
                    context.SaveChanges();
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View("Error");
            }
        }

        // GET: AnimesController/Delete/5
        public ActionResult Delete(int id)
        {
            Anime result = null;
            using (AnimeContext context = new AnimeContext())
            {
                result = context.Anime.Where(x => x.AnimeId == id).First();
            }
            return View(result);
        }

        // POST: AnimesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                using (AnimeContext context = new AnimeContext())
                {
                    Anime anime = context.Anime.Where(x => x.AnimeId == id).First();
                
                    context.Anime.Remove(anime);
                    context.SaveChanges();
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View("Error");
            }
        }
    }
}
