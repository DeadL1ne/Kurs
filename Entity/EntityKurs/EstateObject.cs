using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityKurs
{
    /// <summary>
    /// Class-Entity for storage information about estate object.
    /// </summary>
    public class EstateObject
    {
        public int id { get; set; }//primary key
        public string avitoId { get; set; }//id page on avito.ru, needs for loading phone number and photo
        public string dealType { get; set; }//values: purchase, selling, lease, rent
        public string price { get; set; }
        public string locality { get; set; }//a distinct of the city
        public string address { get; set; }//address of the estate object
        public string area { get; set; }//apartment area
        public string roomNumber { get; set; }//number of rooms in the apartment
        public string floor { get; set; }//floor on which the estate object is located
        public string maxFloor { get; set; }//maximum number of floors in the building
        public string material { get; set; }//the material from which the house is made
        public string seller { get; set; }//estate object seller
        public string sellerNumber { get; set; }//seller's telephone number
        public string description { get; set; }//description by the seller

        public EstateObject(int id, string dealType, string price, string locality, string address, string area, string roomNumber,
            string floor, string maxFloor, string material, string seller, string sellerNumber, string description)
        {
            this.id = id;
            this.dealType = dealType;
            this.price = price;
            this.locality = locality;
            this.address = address;
            this.area = area;
            this.roomNumber = roomNumber;
            this.floor = floor;
            this.maxFloor = maxFloor;
            this.material = material;
            this.seller = seller;
            this.sellerNumber = sellerNumber;
            this.description = description;
        }

        public EstateObject() { }
    }
}
