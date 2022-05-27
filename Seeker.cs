using System;

namespace Unit03.Game
{

//# TODO: Implement the Seeker class as follows...

    //1) Add the class declaration. Use the following class comment.

    //"""The person looking for the Hider. 

    //The responsibility of a Seeker is to keep track of its location and distance travelled.

    //Attributes:
    //location (int): The location of the Seeker (1-1000).
    //"""

    public class Seeker
    {
        private int location = 0;

        //#2) Create the class constructor. Use the following method comment.
        //"""Constructs a new Seeker.

        //Args:
        //self (Seeker): An instance of Seeker.
        // """

        public Seeker()
        {
            Random random = new Random();
            location = random.Next(1001);
        }

        //# 3) Create the get_location(self) method. Use the following method comment.
        //        """Gets the current location.
        //        
        //        Returns:
        //            number: The current location,
        //        """

        public int GetLocation()
        {
            return location;
        }

        //# 4) Create the move_location(self, location) method. Use the following method comment.
        //        """Moves to the given location.
        //
        //        Args:
        //            self (Seeker): An instance of Seeker.
        //            location (int): The given location.
        //        """

        public void MoveLocation(int location)
        {
            this.location = location;
        }
    }
}