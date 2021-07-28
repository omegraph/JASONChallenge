using JSONChallenge.Challenge1;
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
            Event _event = new Event();

            _event.StartDate = new DateTime(2021, 05, 15);
            _event.EndDate = new DateTime(2021, 05, 21);
            _event.EventTitle = "Indy Marathon";
            _event.EventCapacity = 10000;
            _event.PriceOfAdmission = 325.50;
            
            string json = JsonConvert.SerializeObject(_event);
            Console.WriteLine(json);
            Console.ReadKey();

            Badge badge = new Badge();
            badge.BadgeID = "12345";
            badge.ListOfDoor =     


        }
    }
}
