using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityKurs
{
    public class Agreement
    {
        public int id { get; set; }//primary key
        public string date { get; set; }//agreement conclusion date
        public int estateObjectId { get; set; }//foreign key which uses to connect this class-entity with class-entity "EstateObject"
        public int realtorId { get; set; }//foreign key which uses to connect this class-entity with class-entity "Realtor"
        public int requestId { get; set; }////foreign key which uses to connect this class-entity with class-entity "Request"

        public Agreement(int id, string date, int estateObjectId, int realtorId, int requestId)
        {
            this.id = id;
            this.date = date;
            this.estateObjectId = estateObjectId;
            this.realtorId = realtorId;
            this.requestId = requestId;
        }
    }
}
