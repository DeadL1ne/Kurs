using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityKurs
{
    /// <summary>
    /// Class-entity for storage information about realtors.
    /// </summary>
    public class Realtor
    {
        private int id { get; set; }//primary key
        private string fio { get; set; }
        private string login { get; set; }
        private string password { get; set; }
        private string telephoneNumber { get; set; }

        public Realtor(int id, string fio, string login, string password, string telephoneNumber)
        {
            this.id = id;
            this.fio = fio;
            this.login = login;
            this.password = password;
            this.telephoneNumber = telephoneNumber;
        }
    }
}
