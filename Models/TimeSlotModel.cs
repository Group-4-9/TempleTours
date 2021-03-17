using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TempleTours.Models
{
    public class TimeSlotModel
    {
        public class Times 
        { 
        public string Time { get; set; }

        public string Day { get; set; }

        public bool Available { get; set; }
        
        }

        public List<Times> Schedule { get; set; } = new List<Times>();
        
        public TimeSlotModel()
        {
            Schedule.Add(new Times
            {
                Time = "8:00 AM",
                Day = "Sunday",
                Available = true
            });

            Schedule.Add(new Times
            {
                Time = "9:00 AM",
                Day = "Sunday",
                Available = true
            });

            Schedule.Add(new Times
            {
                Time = "10:00 AM",
                Day = "Sunday",
                Available = true
            });

            Schedule.Add(new Times
            {
                Time = "11:00AM",
                Day = "Sunday",
                Available = true
            });

            Schedule.Add(new Times
            {
                Time = "12:00 PM",
                Day = "Sunday",
                Available = true
            });

            Schedule.Add(new Times
            {
                Time = "1:00 PM",
                Day = "Sunday",
                Available = true
            });

            Schedule.Add(new Times
            {
                Time = "2:00 PM",
                Day = "Sunday",
                Available = true
            });

            Schedule.Add(new Times
            {
                Time = "3:00 PM",
                Day = "Sunday",
                Available = true
            });

            Schedule.Add(new Times
            {
                Time = "4:00 PM",
                Day = "Sunday",
                Available = true
            });

            Schedule.Add(new Times
            {
                Time = "5:00 PM",
                Day = "Sunday",
                Available = true
            });

            Schedule.Add(new Times
            {
                Time = "6:00 PM",
                Day = "Sunday",
                Available = true
            });

            Schedule.Add(new Times
            {
                Time = "7:00 PM",
                Day = "Sunday",
                Available = true
            });

            Schedule.Add(new Times
            {
                Time = "8:00 PM",
                Day = "Sunday",
                Available = true
            });

            Schedule.Add(new Times
            {
                Time = "8:00 AM",
                Day = "Monday",
                Available = true
            });

            Schedule.Add(new Times
            {
                Time = "9:00 AM",
                Day = "Monday",
                Available = true
            });

            Schedule.Add(new Times
            {
                Time = "10:00 AM",
                Day = "Monday",
                Available = true
            });

            Schedule.Add(new Times
            {
                Time = "11:00 AM",
                Day = "Monday",
                Available = true
            });

            Schedule.Add(new Times
            {
                Time = "12:00 PM",
                Day = "Monday",
                Available = true
            });

            Schedule.Add(new Times
            {
                Time = "1:00 PM",
                Day = "Monday",
                Available = true
            });

            Schedule.Add(new Times
            {
                Time = "2:00 PM",
                Day = "Monday",
                Available = true
            });

            Schedule.Add(new Times
            {
                Time = "3:00 PM",
                Day = "Monday",
                Available = true
            });

            Schedule.Add(new Times
            {
                Time = "4:00 PM",
                Day = "Monday",
                Available = true
            });

            Schedule.Add(new Times
            {
                Time = "5:00 PM",
                Day = "Monday",
                Available = true
            });

            Schedule.Add(new Times
            {
                Time = "6:00 PM",
                Day = "Monday",
                Available = true
            });

            Schedule.Add(new Times
            {
                Time = "7:00 PM",
                Day = "Monday",
                Available = true
            });

            Schedule.Add(new Times
            {
                Time = "8:00 PM",
                Day = "Monday",
                Available = true
            });

            Schedule.Add(new Times
            {
                Time = "8:00 AM",
                Day = "Tuesday",
                Available = true
            });

            Schedule.Add(new Times
            {
                Time = "9:00 AM",
                Day = "Tuesday",
                Available = true
            });

            Schedule.Add(new Times
            {
                Time = "10:00 AM",
                Day = "Tuesday",
                Available = true
            });

            Schedule.Add(new Times
            {
                Time = "11:00 AM",
                Day = "Tuesday",
                Available = true
            });

            Schedule.Add(new Times
            {
                Time = "12:00 PM",
                Day = "Tuesday",
                Available = true
            });

            Schedule.Add(new Times
            {
                Time = "1:00 PM",
                Day = "Tuesday",
                Available = true
            });

            Schedule.Add(new Times
            {
                Time = "2:00 PM",
                Day = "Tuesday",
                Available = true
            });

            Schedule.Add(new Times
            {
                Time = "3:00 PM",
                Day = "Tuesday",
                Available = true
            });

            Schedule.Add(new Times
            {
                Time = "4:00 PM",
                Day = "Tuesday",
                Available = true
            });

            Schedule.Add(new Times
            {
                Time = "5:00 PM",
                Day = "Tuesday",
                Available = true
            });

            Schedule.Add(new Times
            {
                Time = "6:00 PM",
                Day = "Tuesday",
                Available = true
            });

            Schedule.Add(new Times
            {
                Time = "7:00 PM",
                Day = "Tuesday",
                Available = true
            });

            Schedule.Add(new Times
            {
                Time = "8:00 PM",
                Day = "Tuesday",
                Available = true
            });

            Schedule.Add(new Times
            {
                Time = "8:00 AM",
                Day = "Wednesday",
                Available = true
            });

            Schedule.Add(new Times
            {
                Time = "9:00 AM",
                Day = "Wednesday",
                Available = true
            });

            Schedule.Add(new Times
            {
                Time = "10:00 AM",
                Day = "Wednesday",
                Available = true
            });

            Schedule.Add(new Times
            {
                Time = "11:00 AM",
                Day = "Wednesday",
                Available = true
            });

            Schedule.Add(new Times
            {
                Time = "12:00 PM",
                Day = "Wednesday",
                Available = true
            });

            Schedule.Add(new Times
            {
                Time = "1:00 PM",
                Day = "Wednesday",
                Available = true
            });

            Schedule.Add(new Times
            {
                Time = "2:00 PM",
                Day = "Wednesday",
                Available = true
            });

            Schedule.Add(new Times
            {
                Time = "3:00 PM",
                Day = "Wednesday",
                Available = true
            });

            Schedule.Add(new Times
            {
                Time = "4:00 PM",
                Day = "Wednesday",
                Available = true
            });

            Schedule.Add(new Times
            {
                Time = "5:00 PM",
                Day = "Wednesday",
                Available = true
            });

            Schedule.Add(new Times
            {
                Time = "6:00 PM",
                Day = "Wednesday",
                Available = true
            });

            Schedule.Add(new Times
            {
                Time = "7:00 PM",
                Day = "Wednesday",
                Available = true
            });

            Schedule.Add(new Times
            {
                Time = "8:00 PM",
                Day = "Wednesday",
                Available = true
            });

            Schedule.Add(new Times
            {
                Time = "8:00 AM",
                Day = "Thursday",
                Available = true
            });

            Schedule.Add(new Times
            {
                Time = "9:00 AM",
                Day = "Thursday",
                Available = true
            });

            Schedule.Add(new Times
            {
                Time = "10:00 AM",
                Day = "Thursday",
                Available = true
            });

            Schedule.Add(new Times
            {
                Time = "11:00 AM",
                Day = "Thursday",
                Available = true
            });

            Schedule.Add(new Times
            {
                Time = "12:00 PM",
                Day = "Thursday",
                Available = true
            });

            Schedule.Add(new Times
            {
                Time = "1:00 PM",
                Day = "Thursday",
                Available = true
            });

            Schedule.Add(new Times
            {
                Time = "2:00 PM",
                Day = "Thursday",
                Available = true
            });

            Schedule.Add(new Times
            {
                Time = "3:00 PM",
                Day = "Thursday",
                Available = true
            });

            Schedule.Add(new Times
            {
                Time = "4:00 PM",
                Day = "Thursday",
                Available = true
            });

            Schedule.Add(new Times
            {
                Time = "5:00 PM",
                Day = "Thursday",
                Available = true
            });

            Schedule.Add(new Times
            {
                Time = "6:00 PM",
                Day = "Thursday",
                Available = true
            });

            Schedule.Add(new Times
            {
                Time = "7:00 PM",
                Day = "Thursday",
                Available = true
            });

            Schedule.Add(new Times
            {
                Time = "8:00 PM",
                Day = "Thursday",
                Available = true
            });

            Schedule.Add(new Times
            {
                Time = "8:00 AM",
                Day = "Friday",
                Available = true
            });

            Schedule.Add(new Times
            {
                Time = "9:00 AM",
                Day = "Friday",
                Available = true
            });

            Schedule.Add(new Times
            {
                Time = "10:00 AM",
                Day = "Friday",
                Available = true
            });

            Schedule.Add(new Times
            {
                Time = "11:00 AM",
                Day = "Friday",
                Available = true
            });

            Schedule.Add(new Times
            {
                Time = "12:00 PM",
                Day = "Friday",
                Available = true
            });

            Schedule.Add(new Times
            {
                Time = "1:00 PM",
                Day = "Friday",
                Available = true
            });

            Schedule.Add(new Times
            {
                Time = "2:00 PM",
                Day = "Friday",
                Available = true
            });

            Schedule.Add(new Times
            {
                Time = "3:00 PM",
                Day = "Friday",
                Available = true
            });

            Schedule.Add(new Times
            {
                Time = "4:00 PM",
                Day = "Friday",
                Available = true
            });

            Schedule.Add(new Times
            {
                Time = "5:00 PM",
                Day = "Friday",
                Available = true
            });

            Schedule.Add(new Times
            {
                Time = "6:00 PM",
                Day = "Friday",
                Available = true
            });

            Schedule.Add(new Times
            {
                Time = "7:00 PM",
                Day = "Friday",
                Available = true
            });

            Schedule.Add(new Times
            {
                Time = "8:00 PM",
                Day = "Friday",
                Available = true
            });

            Schedule.Add(new Times
            {
                Time = "8:00 AM",
                Day = "Saturday",
                Available = true
            });

            Schedule.Add(new Times
            {
                Time = "9:00 AM",
                Day = "Saturday",
                Available = true
            });

            Schedule.Add(new Times
            {
                Time = "10:00 AM",
                Day = "Saturday",
                Available = true
            });

            Schedule.Add(new Times
            {
                Time = "11:00 AM",
                Day = "Saturday",
                Available = true
            });

            Schedule.Add(new Times
            {
                Time = "12:00 PM",
                Day = "Saturday",
                Available = true
            });

            Schedule.Add(new Times
            {
                Time = "1:00 PM",
                Day = "Saturday",
                Available = true
            });

            Schedule.Add(new Times
            {
                Time = "2:00 PM",
                Day = "Saturday",
                Available = true
            });

            Schedule.Add(new Times
            {
                Time = "3:00 PM",
                Day = "Saturday",
                Available = true
            });

            Schedule.Add(new Times
            {
                Time = "4:00 PM",
                Day = "Saturday",
                Available = true
            });

            Schedule.Add(new Times
            {
                Time = "5:00 PM",
                Day = "Saturday",
                Available = true
            });

            Schedule.Add(new Times
            {
                Time = "6:00 PM",
                Day = "Saturday",
                Available = true
            });

            Schedule.Add(new Times
            {
                Time = "7:00 PM",
                Day = "Saturday",
                Available = true
            });

            Schedule.Add(new Times
            {
                Time = "8:00 PM",
                Day = "Saturday",
                Available = true
            });
        }
    }
}
