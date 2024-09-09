using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    public delegate void EventHandler();

    public class EventManager
    {
        private List<EventHandler> eventHandlers;

        public EventManager()
        {
            eventHandlers = new List<EventHandler>();
        }

        public void AddHandler(EventHandler handler)
        {
            eventHandlers.Add(handler);
        }

        public void RemoveHandler(EventHandler handler)
        {
            eventHandlers.Remove(handler);
        }

        public void RaiseEvent()
        {
            foreach (EventHandler handler in eventHandlers)
            {
                handler.Invoke();
            }
        }
    }
}
