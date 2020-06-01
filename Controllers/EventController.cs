using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PracaDyplomowa.Interface;
using PracaDyplomowa.Models;
using PracaDyplomowa.ViewsModel;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PracaDyplomowa.Controllers
{
    public class EventController : Controller
    {
        private readonly IEventRepozytory _eventRepozytory ;
        public EventController(IEventRepozytory eventRepozytory)
        {
            _eventRepozytory = eventRepozytory;
        }
        // GET: /<controller>/
        [HttpGet]
        public IActionResult AddEvent()
        {
            AddEventVM model = new AddEventVM();
            return View(model);
        }
        [HttpPost]
        public IActionResult AddEvent(AddEventVM model)
        {
            if (ModelState.IsValid)
            {
                Event e = new Event
                {
                    Name = model.Name,
                    ShortDescription = model.ShortDescription,
                    Description = model.Description,
                    Place = model.Place,
                    DateStart = model.DateStart,
                    DateEnd = model.DateEnd
                };
                _eventRepozytory.addEvent(e);


                return RedirectToAction("ShowEvents");
            }
            return View(model);

        }
        public IActionResult ShowEvents(EventsListVM model)
        {
            model.eventList = _eventRepozytory.allEvent().ToList();
            return View(model);
        }
    }
}
