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

namespace RealtorEstateAgancy
{
    public delegate string avitoId();
    public partial class FullDescriptionForm : Form
    {
        private estateId id;
        public FullDescriptionForm(estateId sender)
        {
            InitializeComponent();
            id = sender;
        }

        private void FullDescriptionForm_Load(object sender, EventArgs e)
        {
            SQLitekurs.SQLite db = new SQLitekurs.SQLite();
            int objectId = Convert.ToInt32(id.Invoke());
            EstateObject estate = db.GetEstateObject(objectId);
            dealTypeLabel.Text = estate.dealType;
            localityLabel.Text = estate.locality;
            addressLabel.Text = estate.address;
            areaLabel.Text = estate.area;
            roomNumberLabel.Text = estate.roomNumber;
            floorLabel.Text = estate.floor + "/" + estate.maxFloor;
            materialLabel.Text = estate.material;
            priceLabel.Text = estate.price;
            descriptionRTB.Text = estate.description;
        }
        private string GetAvitoId()
        {
            SQLitekurs.SQLite db = new SQLitekurs.SQLite();
            int objectId = Convert.ToInt32(id.Invoke());
            EstateObject estate = db.GetEstateObject(objectId);
            return estate.avitoId;
        }

        private void showPhotosbtn_Click(object sender, EventArgs e)
        {
            ShowPhotoForm photoForm = new ShowPhotoForm(new avitoId(GetAvitoId));
            photoForm.ShowDialog();
        }

        private void showPhotosbtn_Click_1(object sender, EventArgs e)
        {

        }
    }
}
