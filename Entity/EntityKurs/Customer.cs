using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityKurs
{
    /// <summary>
    /// Class-entity for storage information about customers.
    /// </summary>
    public class Customer
    {
        public int id { get; set; }//primary key
        public string fio { get; set; }
        public string email { get; set; }
        public string telephoneNumber { get; set; }

        public Customer(int id, string fio, string email, string telephoneNumber)
        {
            this.id = id;
            this.fio = fio;
            this.email = email;
            this.telephoneNumber = telephoneNumber;
        }
        public Customer() { }
    }
}
