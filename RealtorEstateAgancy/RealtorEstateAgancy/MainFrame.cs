using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using xNet;
using ParserAvito;
using SQLitekurs;

namespace RealtorEstateAgancy
{
    public partial class MainFrame : Form
    {
        public MainFrame()
        {
            InitializeComponent();
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
            SQLitekurs.SQLite db = new SQLitekurs.SQLite();
            if (!File.Exists(@"C:\BD\RealtorEstateAgancy.sqlite"))
            {
                SQLiteConnection.CreateFile(@"C:\BD\RealtorEstateAgancy.sqlite");
                db.Connect(@"C:\BD\RealtorEstateAgancy.sqlite");
                db.Create();
                //SQLiteConnection connection = new SQLiteConnection(@"Data Source=C:\BD\RealtorEstateAgancy.sqlite;Version=3");
                //SQLiteCommand command;
                //command= new SQLiteCommand("create table Realtor(id integer primary key autoincrement, fio text, login text, password text, telephoneNumber text);", connection);
                //connection.Open();
                //command.ExecuteNonQuery();
                //command = new SQLiteCommand("create table Customer(id integer primary key autoincrement, fio text, email text, telephoneNumber text);", connection);
                //command.ExecuteNonQuery();
                //command = new SQLiteCommand("create table EstateObject(id INTEGER PRIMARY KEY AUTOINCREMENT, avitoId text, dealType text, price text, locality text," +
                //   " address text, area text, roomNumber text, floor text, maxFloor text, material text, seller text, description text);", connection);
                //command.ExecuteNonQuery();
                //command = new SQLiteCommand("create table Request(id integer primary key autoincrement, customerID references Customer(id)," + 
                //    " date text, dealType text, estateObjectType text, material text, lPrice text, uPrice text, locality text, lArea real, uArea real" + 
                //    " roomNumber integer, floor integer, maxFloor integer, suggestion text, status text);", connection);
                //command.ExecuteNonQuery();
                //command = new SQLiteCommand("create table Agreement(id integer primary key autoincrement, date text, estateObjectId references estateObject(id)," +
                //    " realtorId references Realtor(id), requestId references Request(id));", connection);
                //command.ExecuteNonQuery();
                //connection.Close();
            }             
        }

        private void btnEstate_Click(object sender, EventArgs e)
        {
            EstateObjectFrame estateObjectForm = new EstateObjectFrame();
            estateObjectForm.Show();
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            RequestForm requestForm = new RequestForm();
            requestForm.Show();
        }
    }
}
    