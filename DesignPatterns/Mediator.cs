using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    class Mediator
    {
        public delegate void Callback(string message, string from);
        Callback respond;

        public void SignOn(Callback method)
        {
            respond += method;
        }

        public void Block(Callback method)
        {
            respond -= method;
        }
        public void Unblock(Callback method)
        {
            respond += method;
        }

        public void Send(string message, string from)
        {
            respond(message, from);
            Console.WriteLine();
        }
    }
}