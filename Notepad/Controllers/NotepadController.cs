using Notepad.Data;
using Notepad.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Notepad.Controllers
{
	public class NotepadController : Controller
	{
		private readonly ApplicationDbContext _context;

		public NotepadController(ApplicationDbContext context)
		{
			_context = context;
		}

		public IActionResult Index()
		{
			IEnumerable<Notepad> notepads = _context.Notepads;
			return View(notepads);
		}

		public IActionResult Greate()
		{
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Create(Notepad notepad)
		{
			if (ModelState.IsValid)
			{
				_context.Notepads.Add(notepad);
				_context.SaveChanges();
				return RedirectToAction("Index");
			}

			return View(notepad);
		}


		public IActionResult Edit(int? id) 
		{
			if(id == null || id == 0)
			{
				return NotFound();
			}

			var notepad = _context.Notepads.Find(id);

			if (notepad == null)
			{
				return NotFound();
			}
			return View(notepad);
			
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Edit(Notepad notepad)
		{
			if (ModelState.IsValid)
			{
				_context.Notepads.Update(notepad);
				_context.SaveChanges();
				return RedirectToAction("Index");
			}
			return View(notepad);
		}
		public IActionResult Delete(int? id)
		{
			if(id == null || id== 0){
				return NotFound();
			}

			var notepad = _context.Notepads.Find(id);

			if(notepad == null)
			{
				return NotFound();
			}
			return View(notepad);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult DeleteNote(int? id)
		{
			var notepad = _context.Notepads.Find(id);
			if(notepad == null)
			{
				return NotFound();
			}
			_context.Notepads.Remove(notepad);
			_context.SaveChanges();

			return RedirectToAction("Index");
		}

	}
}
