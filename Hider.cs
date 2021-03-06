using System;
using System.Collections.Generic;


namespace Unit03.Game
{
    public class Hider
    {
        public int location = 0;
        private List<int> distance = new List<int>();

        public Hider()
        {
            Random random = new Random();
            location = random.Next(1001);
            // start with two so GetHint always works
            distance.Add(0);
            distance.Add(0);
        }

        public string GetHint()
        {
            int current = distance[distance.Count - 1];
            int previous = distance[distance.Count - 2];


            string hint = "(-.-) Nap time.";
            if (current == 0)
            {
                hint = ("(;.;) You found me!");
            }

            else if (current > previous)
            {
                hint = ("(^.^) Getting colder!");
            }
            else if (current < previous)
            {
                hint = ("(>.<) Getting warmer!");
            }
            return hint;
        }

        public bool IsFound()
        {
            return distance[distance.Count - 1] == 0;
        }

        public void WatchSeeker(Seeker seeker)
        {
            int newDistance = Math.Abs(location - seeker.GetLocation());
            distance.Add(newDistance);
        }

    }
}