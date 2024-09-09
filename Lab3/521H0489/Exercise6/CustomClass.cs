using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    public class EventHandling
    {
        public event Action<string>? Event;

        public void TriggerEvent(string message)
        {
            Event?.Invoke(message);
        }
    }
}
