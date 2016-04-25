using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityKurs
{
    /// <summary>
    /// Class-entity for storage information about customer's requests.
    /// </summary>
    public class Request
    {
        private int id { get; set; }//primary key
        private int customerId { get; set; }//foreign key which uses to connect this class-entity with class-entity "Customer"
        private string date { get; set; }//request leaving date
        private string dealType { get; set; }//values: purchase, selling, lease, rent
        private string estateObjectType { get; set; }//values: new building, resale
        private string material { get; set; }//the material from which the house is made
        private string lPrice { get; set; }//the lower limit of the price
        private string uPrice { get; set; }// the upper limit of the price
        private string locality { get; set; }//a distinct of the city
        private double lArea { get; set; }//the lower limit of the apartment area
        private double uArea { get; set; }//the upper limit of the apartment area
        private int roomNumber { get; set; }//number of rooms in the apartment
        private int floor { get; set; }//floor on which the estate object is located
        private int maxFloor { get; set; }//maximum number of floors in the building
        private string suggestion { get; set; }//customer's suggestions
        private string status { get; set; }//current request status

        public Request(int id, int customerId, string date, string dealType, string estateObject, string material, string lPrice,
            string uPrice, string locality, double lArea, double uArea, int roomNumber, int floor, int maxFloor, string suggestion, string status)
        {
            this.id = id;
            this.customerId = customerId;
            this.date = date;
            this.dealType = dealType;
            estateObjectType = estateObject;
            this.material = material;
            this.lPrice = lPrice;
            this.uPrice = uPrice;
            this.locality = locality;
            this.lArea = lArea;
            this.uArea = uArea;
            this.roomNumber = roomNumber;
            this.floor = floor;
            this.maxFloor = maxFloor;
            this.suggestion = suggestion;
            this.status = status;

        }
        public Request() { }

    }
}
