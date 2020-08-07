using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BiletaraKino.Models;

namespace BiletaraKino.Controllers
{
    public class CinemaRoomsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: CinemaRooms
        public ActionResult Index()
        {
            return View(db.cinemaRooms.ToList());
        }

        // GET: CinemaRooms/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CinemaRoom cinemaRoom = db.cinemaRooms.Find(id);
            if (cinemaRoom == null)
            {
                return HttpNotFound();
            }
            return View(cinemaRoom);
        }

        // GET: CinemaRooms/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CinemaRooms/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CinemaRoomId,Name,Number")] CinemaRoom cinemaRoom)
        {
            if (ModelState.IsValid)
            {
                db.cinemaRooms.Add(cinemaRoom);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cinemaRoom);
        }

        // GET: CinemaRooms/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CinemaRoom cinemaRoom = db.cinemaRooms.Find(id);
            if (cinemaRoom == null)
            {
                return HttpNotFound();
            }
            return View(cinemaRoom);
        }

        // POST: CinemaRooms/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CinemaRoomId,Name,Number")] CinemaRoom cinemaRoom)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cinemaRoom).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cinemaRoom);
        }
        /*
        // GET: CinemaRooms/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CinemaRoom cinemaRoom = db.cinemaRooms.Find(id);
            if (cinemaRoom == null)
            {
                return HttpNotFound();
            }
            return View(cinemaRoom);
        }

        // POST: CinemaRooms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CinemaRoom cinemaRoom = db.cinemaRooms.Find(id);
            db.cinemaRooms.Remove(cinemaRoom);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        */

        public ActionResult Delete(int id)
        {
            CinemaRoom cinemaRoom = db.cinemaRooms.Find(id);
            db.cinemaRooms.Remove(cinemaRoom);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
