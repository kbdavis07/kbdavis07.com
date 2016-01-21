﻿using KB.Models;
using System;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace KB.Controllers
{
    public class ContactController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Contact
        [Authorize(Users = "kbdavis07@yahoo.com")]
        public ActionResult Index()
        {
            return View(db.Messages.ToList());
        }

        // GET: Contact/Details/5
        [Authorize(Users = "kbdavis07@yahoo.com")]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contact contact = db.Messages.Find(id);
            if (contact == null)
            {
                return HttpNotFound();
            }
            return View(contact);
        }

        // GET: Contact/Create
        public ActionResult Me()
        {
            ViewBag.Title = "Contact Me";
            ViewBag.Keywords = "Asp.Net, MVC, C#, Web Application, Developer,Contact";
            ViewBag.Description = "Asp.Net MVC C# Web Application Developer available for hire.";
            ViewBag.Subject = "Contact Me | Brian Keith Davis | Web Application Developer";

            return View();
        }

        // POST: Contact/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Me([Bind(Include = "MessageId,FirstName,LastName,Email,Topic,Subject,Message")] Contact contact)
        {

            ViewBag.Title = "Contact Me";
            ViewBag.Keywords = "Asp.Net, MVC, C#, Web Application, Developer,Contact";
            ViewBag.Description = "Asp.Net MVC C# Web Application Developer available for hire.";
            ViewBag.Subject = "Contact Me | Brian Keith Davis | Web Application Developer";
            
            DateTime Now = DateTime.Now;

            contact.ContactDate = Now;


            if (ModelState.IsValid)
            {
                db.Messages.Add(contact);
                db.SaveChanges();
                return RedirectToAction("Success", "Home");
            }

            return View(contact);
        }

        // GET: Contact/Edit/5
        [Authorize(Users = "kbdavis07@yahoo.com")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contact contact = db.Messages.Find(id);
            if (contact == null)
            {
                return HttpNotFound();
            }
            return View(contact);
        }

        // POST: Contact/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Users = "kbdavis07@yahoo.com")]
        public ActionResult Edit([Bind(Include = "MessageId,ContactDate,FirstName,LastName,Email,Topic,Subject,Message")] Contact contact)
        {
            if (ModelState.IsValid)
            {
                db.Entry(contact).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(contact);
        }

        // GET: Contact/Delete/5
        [Authorize(Users = "kbdavis07@yahoo.com")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contact contact = db.Messages.Find(id);
            if (contact == null)
            {
                return HttpNotFound();
            }
            return View(contact);
        }

        // POST: Contact/Delete/5
        [Authorize(Users = "kbdavis07@yahoo.com")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Contact contact = db.Messages.Find(id);
            db.Messages.Remove(contact);
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
