using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityKurs;
using System.Windows.Forms;
using System.Data.SQLite;

namespace RealtorEstateAgancy
{
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (FIO_textbox.Text != "" && (e_mail_textbox.Text != "" || phone_textbox.Text != ""))
             {
                Customer customer = new Customer();
                customer.
             }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
