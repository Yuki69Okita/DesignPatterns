using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public class AssassinsCreed:IPlay
    {
        public AssassinsCreed()
        {
            Console.WriteLine("Assassin's Creed is created!");
        }

        public void Play()
        {
            Console.WriteLine("Now is playing Assassin's Creed!");
        }
    }
}