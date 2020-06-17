using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public class Factory
    {
        public static IPlay playGame(String key)
        {
            switch (key)
            {
                case "assassin's creed":
                    return new AssassinsCreed();
                case "minectaft":
                    return new Minecraft();
                case "outlast":
                    return new Outlast();
                default:
                    throw new Exception("Not valid key provided.");
            }
        }
    }
}