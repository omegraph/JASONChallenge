using JSONChallenge.Challenge1;
using JSONChallenge.Challenge2;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONChallenge
{
    class Program
    {
        static void Main(string[] args)
        {

            //Event
            Event _event = new Event();

            _event.StartDate = new DateTime(2021, 05, 15);
            _event.EndDate = new DateTime(2021, 05, 21);
            _event.EventTitle = "Indy Marathon";
            _event.EventCapacity = 10000;
            _event.PriceOfAdmission = 325.50;

            string json = JsonConvert.SerializeObject(_event);
            Console.WriteLine(json);
            Console.ReadKey();


            //Badge
            Badge badge = new Badge();
            badge.BadgeID = "12345";
            badge.ListOfDoors = new List<string>
            {
                "A1",
                "B2",
                "B5",
                "G21"
            };

            badge.HasSecurityClearance = true;
            badge.EmployeeId = "F54G678Hj32321S";
            badge.CreatedOn = new DateTime(2021, 07, 27);

            string json = JsonConvert.SerializeObject(badge);
            Console.WriteLine(json);
            Console.ReadKey();

        }
        
    }
}
