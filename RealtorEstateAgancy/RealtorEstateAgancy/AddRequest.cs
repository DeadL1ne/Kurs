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
    public partial class AddRequest : Form
    {
        object CustomerID;
        public AddRequest()
        {
            InitializeComponent();
        }
        public AddRequest(object Customer_id)
        {
            InitializeComponent();
            CustomerID = Customer_id;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (CustomerID != null)
            {
                Request request = new Request();
                request.customerId = Convert.ToInt32(CustomerID);
                request.date = dateRequest.Text;
                request.dealType = dealTypeComboBox.Text;
                request.locality = localityComboBox.Text;
                request.lArea = Convert.ToDouble(lAreaTextBox.Text);
                request.uArea = Convert.ToDouble(uAreaTextBox.Text);
                request.lPrice = lPriceTextBox.Text;
                request.uPrice = uPriceTextBox.Text;
                request.roomNumber = Convert.ToInt32(roomNumberTextBox.Text);
                request.status = "Активная";
                request.suggestion = suggestionRichTextBox.Text;
                request.maxFloor =Convert.ToInt32( maxFloorTextBox.Text);
                request.floor =Convert.ToInt32( floorTextBox.Text);
                request.material = materialcomboBox.Text;
                request.estateObjectType = estateObjectTypeComboBox.Text;
                SQLitekurs.SQLite db = new SQLitekurs.SQLite();
                db.AddRequest(request);
                Close();

            }
            else
            {
                MessageBox.Show("ОШИБКА! Вернитесь в окно выбора клиента и выберите вновь клиента для добавления заявки");
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
