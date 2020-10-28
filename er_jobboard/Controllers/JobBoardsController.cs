using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using er_jobboard.Models;

namespace er_jobboard.Controllers
{
    public class JobBoardsController : Controller
    {
        private JobboardDBContext db = new JobboardDBContext();

        // GET: JobBoards
        public async Task<ActionResult> Index()
        {
            return View(await db.JobBoards.ToListAsync());
        }

        // GET: JobBoards/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JobBoard jobBoard = await db.JobBoards.FindAsync(id);
            if (jobBoard == null)
            {
                return HttpNotFound();
            }
            return View(jobBoard);
        }

        // GET: JobBoards/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: JobBoards/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,job,job_title,description,created_at,expires_at")] JobBoard jobBoard)
        {
            if (ModelState.IsValid)
            {
                db.JobBoards.Add(jobBoard);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(jobBoard);
        }

        // GET: JobBoards/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JobBoard jobBoard = await db.JobBoards.FindAsync(id);
            if (jobBoard == null)
            {
                return HttpNotFound();
            }
            return View(jobBoard);
        }

        // POST: JobBoards/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,job,job_title,description,created_at,expires_at")] JobBoard jobBoard)
        {
            if (ModelState.IsValid)
            {
                db.Entry(jobBoard).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(jobBoard);
        }

        // GET: JobBoards/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JobBoard jobBoard = await db.JobBoards.FindAsync(id);
            if (jobBoard == null)
            {
                return HttpNotFound();
            }
            return View(jobBoard);
        }

        // POST: JobBoards/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            JobBoard jobBoard = await db.JobBoards.FindAsync(id);
            db.JobBoards.Remove(jobBoard);
            await db.SaveChangesAsync();
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
