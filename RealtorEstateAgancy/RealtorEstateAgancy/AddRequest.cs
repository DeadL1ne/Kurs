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
using HelpRequests;

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
                request.lArea = lAreaTextBox.Text;
                request.uArea = uAreaTextBox.Text;
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
                //////////////////////////////////////////////////////////////////////////////////////
                if (HelpRequestTextBox.Text != "")
                {
                    hr.Connect(path);
                    hr.UpdateRequestFrame(hr.ConvertRequestToFrame(request, HelpRequestTextBox.Text));
                }
                Close();

            }
            else
            {
                MessageBox.Show("ОШИБКА! Вернитесь в окно выбора клиента и выберите вновь клиента для добавления заявки");
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateRequest_ValueChanged(object sender, EventArgs e)
        {

        }




        //////////////////////////////////////////////////////////////////////////////////////////////////////////
        HelpRequest hr = new HelpRequest();
        
        
        string path = @"C:\BD\FRAMEVL.sqlite";
        
         
        
        

        
            
            /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HelpRequestTextBox_TextChanged(object sender, EventArgs e)
        {
            hr.Connect(path);
            Request tmpr = new Request();
            try
            {
               hr.Create();
            }
            catch { }

            tmpr = hr.GetRequestOfFrame(HelpRequestTextBox.Text);
            if (tmpr != null)
            {
                uAreaTextBox.Text = tmpr.uArea;
                lAreaTextBox.Text = tmpr.lArea;
                lPriceTextBox.Text = tmpr.lPrice;
                uPriceTextBox.Text = tmpr.uPrice;
                materialcomboBox.Text = hr.fillterString(tmpr.material);
                floorTextBox.Text = Convert.ToString(tmpr.floor);
                maxFloorTextBox.Text = Convert.ToString(tmpr.maxFloor);
                roomNumberTextBox.Text = Convert.ToString(tmpr.roomNumber);
                localityComboBox.Text = hr.fillterString(tmpr.locality);
                dealTypeComboBox.Text = hr.fillterString(tmpr.dealType);
                estateObjectTypeComboBox.Text = hr.fillterString(tmpr.estateObjectType);

            }
        }
    }
}
