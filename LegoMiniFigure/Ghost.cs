using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMiniFigure
{
    class Ghost
    {
        public bool Friendly { get; set; }
        public bool IsVisible { get; set; }
        public string Name { get; set; }
        public string HauntingLocation { get; private set; }
        public DateTime DeathDay { get; }

        public Ghost(string name, DateTime deathDay)
        {
            Name = name;
            DeathDay = deathDay;
        }

        public void Haunt(string hauntingLocation)
        {
            HauntingLocation = hauntingLocation;
            Console.WriteLine($"{Name} spooks at {HauntingLocation}");
        }

        public void Spook()
        {
            if (string.IsNullOrEmpty(HauntingLocation)) return; //return in this case quits the method
            Console.WriteLine($"{Name} does a spook at {HauntingLocation}");
        }
    }
}
