using AutoMapper;
using BookStore.Application.Interfaces;
using BookStore.Domain.Entities;
using BookStore.MVC.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace BookStore.MVC.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookAppService _bookApp;

        public BookController(IBookAppService bookApp)
        {
            _bookApp = bookApp;
        }

        // GET: Book
        public ActionResult Index()
        {
            var bookVMList = Mapper.Map<IEnumerable<Book>, IEnumerable<BookViewModel>>(_bookApp.GetAll());

            if (bookVMList != null)
            {
                bookVMList = bookVMList.OrderBy(b => b.Title);
            }

            return View(bookVMList);
        }

        // GET: Book/Details/5
        public ActionResult Details(int id)
        {
            var bookDomain = _bookApp.GetById(id);
            var bookVM = Mapper.Map<Book, BookViewModel>(bookDomain);

            return View(bookVM);
        }

        // GET: Book/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Book/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(BookViewModel bookVM)
        {
            if (ModelState.IsValid)
            {
                var bookDomain = Mapper.Map<BookViewModel, Book>(bookVM);

                _bookApp.Add(bookDomain);

                return RedirectToAction("Index");
            }

            return View(bookVM);
        }

        // GET: Book/Edit/5
        public ActionResult Edit(int id)
        {
            var bookDomain = _bookApp.GetById(id);
            var bookVM = Mapper.Map<Book, BookViewModel>(bookDomain);

            return View(bookVM);
        }

        // POST: Book/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(BookViewModel bookVM)
        {
            if (ModelState.IsValid)
            {
                var bookDomain = Mapper.Map<BookViewModel, Book>(bookVM);
                _bookApp.Update(bookDomain);

                return RedirectToAction("Index");
            }

            return View(bookVM);
        }

        // GET: Book/Delete/5
        public ActionResult Delete(int id)
        {
            var bookDomain = _bookApp.GetById(id);
            var bookVM = Mapper.Map<Book, BookViewModel>(bookDomain);

            return View(bookVM);
        }

        // POST: Book/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var bookDomain = _bookApp.GetById(id);
            _bookApp.Remove(bookDomain);

            return RedirectToAction("Index");
        }
    }
}
