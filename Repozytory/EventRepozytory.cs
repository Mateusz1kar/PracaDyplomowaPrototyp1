using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PracaDyplomowa.Interface;
using PracaDyplomowa.Models;

namespace PracaDyplomowa.Repozytory
{
    public class EventRepozytory : IEventRepozytory
    {
        private readonly AppDbContext _appDbContext;
        public EventRepozytory(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public void addEvent(Event e)
        {
            e.FirmAccount = _appDbContext.FirmAccounts.Find(e.UserName);
            _appDbContext.Events.Add(e);
            _appDbContext.SaveChanges();
        }

        public IEnumerable<Event> allEvent()
        {
            return _appDbContext.Events.ToList();
        }

        public void delEvent(int id)
        {
            throw new NotImplementedException();
        }

        public Event findEvent(int Id)
        {
            return _appDbContext.Events.Find(Id);
        }
    }
}
