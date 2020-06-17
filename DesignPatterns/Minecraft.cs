using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public class Minecraft:IPlay
    {
        public Minecraft()
        {
            Console.WriteLine("Minecraft is created!");
        }

        public void Play()
        {
            Console.WriteLine("Now is playing Minnecraft!");
        }
    }
}