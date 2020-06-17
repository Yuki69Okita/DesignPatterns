using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    class JoinGameGroup1
    {
        Mediator mediator;
        protected string name;

        public JoinGameGroup1(Mediator mediator, string name)
        {
            this.mediator = mediator;
            mediator.SignOn(Receive);
            this.name = name;
        }
        public virtual void Receive(string message, string from)
        {
            Console.WriteLine(name + " received from " + from + ": " + message);
        }
        public void Send(string message)
        {
            Console.WriteLine("Send (From " + name + "): " + message);
            mediator.Send(message, name);
        }
    }

    class JoinGameGroup2 : JoinGameGroup1
    {
        public JoinGameGroup2(Mediator mediator, string name): base(mediator, name)
        {

        }

        public override void Receive(string message, string from)
        {
            if (!String.Equals(from, name))
                Console.WriteLine(name + " received from " + from + ": " + message);
        }
    }
}