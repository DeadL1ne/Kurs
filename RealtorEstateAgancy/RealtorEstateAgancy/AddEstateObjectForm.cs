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
    public partial class AddEstateObjectForm : Form
    {
        public AddEstateObjectForm()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            EstateObject newEstate = new EstateObject();
            newEstate.dealType = dealTypeComboBox.Text;
            newEstate.locality = localityComboBox.Text;
            newEstate.address = addressTextBox.Text;
            newEstate.area = areaTextBox.Text;
            newEstate.roomNumber = roomNumberComboBox.Text;
            newEstate.floor = floorTextBox.Text;
            newEstate.maxFloor = maxFloorTextBox.Text;
            newEstate.material = materialTextBox.Text;
            newEstate.price = priceTextBox.Text;
            newEstate.description = descriptionRichTextBox.Text;
            SQLitekurs.SQLite db = new SQLitekurs.SQLite();
            db.AddEstate(newEstate);
            Close();

        }
    }
}
