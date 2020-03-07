using System;

namespace LegoMiniFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            var astronaut = new Astronaut("Space Person", "Janitor");
            var astronaut2 = new Astronaut("Space Man", "Janitor");
            astronaut.DoYourJob();

            var casper = new Ghost("Casper", DateTime.Now)
            {
                Friendly = true,
            };
            casper.Haunt("Whipstaff Manor");
            casper.Spook();

            var fatSo = new Ghost("FatSo", DateTime.Today)
            {
                Friendly = false,
            };
            fatSo.Haunt("Whipstaff Manor");
            fatSo.Spook();
        }


    }
}
