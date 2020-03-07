using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMiniFigure
{
    enum Location
    {
        Earth,
        Space,
        SpaceStation
    }
    class Astronaut
    {
        public Location Location { get; set; }
        public bool SuitedUp => Name == "Space Person";
        public string Name { get; }
        public string Job { get; private set; }
        public int OxygenLevel { get; set; }

        public Astronaut(string name, string job)
        {
            Name = name;
            Job = job;
        }
        public void Promote()
        {
            Job = "Commander of Janitors";
        }
        public void DoYourJob()
        {
            Console.WriteLine($"{Name} is doing all their {Job} duties...");
        }
    }
}
