using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PracaDyplomowa.Models;

namespace PracaDyplomowa.Interface
{
    public interface IEventRepozytory
    {
        void addEvent(Event e);
        void delEvent(int id);
        IEnumerable<Event> allEvent();
        Event findEvent(int Id);
    }
}
