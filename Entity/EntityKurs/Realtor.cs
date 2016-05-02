using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace EntityKurs
{
    /// <summary>
    /// Class-entity for storage information about realtors.
    /// </summary>
    public class Realtor
    {
        public int id { get; set; }//primary key
        public string fio { get; set; }
        public string login { get; set; }
        public string password {
            get { return password; }
            set {
                MD5 md5 = MD5.Create();
                password = Convert.ToString(md5.ComputeHash(Encoding.UTF8.GetBytes(value)));
            }
        }
        public string telephoneNumber { get; set; }

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
