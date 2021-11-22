using System;
using System.Collections.Generic;
using System.Text;

namespace Zipse_Final
{
    class myBox
    {
        //Creates 2 variables, the counter variable, and the zipcode
        //That is created with each box
        public ulong myCounter = 0;
        public int zipcode = 0;
    }

    class MyQueue : IComparable<MyQueue>
    {
        
        //sets the time in which the arm needs to be triggered.
        public ulong trigger { get; set; }
        //Getter and setter for each box ID
        public string ID { get; set; }
        //Getter and Setter for the zip code on the queue.
        public string zipcode { get; set; }
        //Getter and setter for the lane that the box item needs to be  
        //Pushed off
        public int lane { get; set; }


        //Used for sorting by the time needed to get off the conveyor belt
        public int CompareTo(MyQueue other)
        {
            if (this.trigger < other.trigger) return -1;
            else if (this.trigger > other.trigger) return 1;
            else return 0;


        }

    }
}
