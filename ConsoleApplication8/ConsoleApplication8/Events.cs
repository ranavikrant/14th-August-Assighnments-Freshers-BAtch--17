using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Events
    {

        public event TickHandler called;
        public EventArgs e = null;
        public delegate void TickHandler(Events m, EventArgs e);
        public void subscribe(Events e)
        {

            e.called += new TickHandler(getMessage);

        }
        public void getMessage(Events m, EventArgs e)
        {
            Console.WriteLine(e);
        }
        public void print()
        {
            called(this, e);
        }
    }
}
