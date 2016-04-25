using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using EntityKurs;
using ParserAvito;

namespace SQLitekurs
{
    public class SQLite
    {

        public SQLiteConnection connection;
        public SQLiteCommand command;
        /// <summary>
        /// Method connects to database.
        /// </summary>
        /// <param name="path">Path where database file is situated.</param>
        public void Connect(string path)
        {
            connection = new SQLiteConnection(@"Data Source=" + path + ";Version=3");
        }
        /// <summary>
        /// Menhod creates database.
        /// </summary>
        public void Create()
        {
            command = new SQLiteCommand("create table Realtor(id integer primary key autoincrement, fio text, login text, password text, telephoneNumber text);", connection);
            connection.Open();
            command.ExecuteNonQuery();
            command = new SQLiteCommand("create table Customer(id integer primary key autoincrement, fio text, email text, telephoneNumber text);", connection);
            command.ExecuteNonQuery();
            command = new SQLiteCommand("create table EstateObject(id INTEGER PRIMARY KEY AUTOINCREMENT, avitoId text, dealType text, price text, locality text," +
               " address text, area text, roomNumber text, floor text, maxFloor text,  material text, seller text, description text);", connection);
            command.ExecuteNonQuery();
            command = new SQLiteCommand("create table Request(id integer primary key autoincrement, customerID references Customer(id)," +
                " date text, dealType text, estateObjectType text, material text, lPrice text, uPrice text, locality text, lArea real, uArea real" +
                " roomNumber integer, floor integer, maxFloor integer, suggestion text, status text);", connection);
            command.ExecuteNonQuery();
            command = new SQLiteCommand("create table Agreement(id integer primary key autoincrement, date text, estateObjectId references estateObject(id)," +
                " realtorId references Realtor(id), requestId references Request(id));", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
        /// <summary>
        /// Method updates estate objects in database
        /// </summary>
        public void Update()
        {
            connection.Open();
            WebParser parser = new WebParser();
            //try
            //{
                for (int page = 0; page < parser.GetCountPages(); page++)
                {
                        for (int estateObject = 0; estateObject < 50; estateObject++)
                        {
                            string avitoId = parser.GetEstateObjectId(estateObject + 1, 1);
                            string sourcePage = parser.GetSourcePage(avitoId);
                            command = new SQLiteCommand("insert into EstateObject (avitoId, dealType, price, locality, address, area, roomNumber, " +
                                "floor, maxFloor, material, seller, description) values ('" + avitoId + "', " +
                                "'" + parser.GetDealType(sourcePage) + "', " +
                                "'" + parser.GetPrice(sourcePage) + "', " +
                                "'" + parser.GetLocality(sourcePage) + "', " +
                                "'" + parser.GetAddress(sourcePage) + "', " +
                                "'" + parser.GetArea(sourcePage) + "', " +
                                "'" + parser.GetRoomNumber(sourcePage) + "', " +
                                "'" + parser.GetFloor(sourcePage) + "', " +
                                "'" + parser.GetMaxFloor(sourcePage) + "', " +
                                "'" + parser.GetMaterial(sourcePage) + "', " +
                                "'" + parser.GetSellerName(sourcePage) + "', " +
                                "'" + parser.GetDescription(sourcePage) + "');", connection);
                            command.ExecuteNonQuery();
                        }
                }
            connection.Close();
            //}
            //catch (IndexOutOfRangeException)
            //{
            //    return;
            //}
        }
        /// <summary>
        /// Method drops and then create table "EstateObject" in database. It needs before updating.
        /// </summary>
        public void DropEstateObjectTable()
        {
            connection.Open();
            command = new SQLiteCommand("drop table EstateObject", connection);
            command.ExecuteNonQuery();
            command = new SQLiteCommand("create table EstateObject(id INTEGER PRIMARY KEY AUTOINCREMENT, avitoId text, dealType text, price text, locality text," +
               " address text, area text, roomNumber text, floor text, maxFloor text, material text, seller text, description text);", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
        /// <summary>
        /// Method removes record in database.
        /// </summary>
        /// <param name="id">id for removing</param>
        public void RemoveEstateObject(int id)
        {
            connection.Open();
            command = new SQLiteCommand("delete from EstateObject where id =" + id, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
        /// <summary>
        /// Method searches estateObjects which satisfy given address
        /// </summary>
        /// <param name="address">address to which the search is carried out</param>
        /// <returns>Table with all suitable addresses</returns>
        public DataTable SearchByAddress(string address)
        {
            connection.Open();
            command = new SQLiteCommand("SELECT id, dealType, locality, address, roomNumber, price FROM EstateObject where address LIKE '" + address +
                "%';", connection);
            SQLiteDataReader searchReader = command.ExecuteReader();
            DataTable searchDataTable = new DataTable();
            searchDataTable.Load(searchReader);
            searchReader.Close();
            connection.Close();
            return searchDataTable;
        }
        /// <summary>
        /// Method write all data in DataTable
        /// </summary>
        /// <returns>DataTable with all data.</returns>
        public DataTable DisplayAllData()
        {
            connection.Open();
            command = new SQLiteCommand(connection);
            command.CommandText = @"SELECT id, dealType, locality, address, roomNumber, price FROM EstateObject;";
            SQLiteDataReader allDataReader = command.ExecuteReader();
            DataTable allData = new DataTable();
            allData.Load(allDataReader);
            allDataReader.Close();
            connection.Close();
            return allData;
        }
        /// <summary>
        /// Method for adding user's estate object in database.
        /// </summary>
        /// <param name="newEstate">Exemplar of EstateObject entity</param>
        public void AddEstate(EstateObject newEstate)
        {
            Connect(@"C:\BD\RealtorEstateAgancy.sqlite");
            connection.Open();
            command = new SQLiteCommand("insert into EstateObject(dealType, locality, address, area, roomNumber, floor, maxFloor, " +
                "material, price, description) values (" +
                "'" + newEstate.dealType + "', " +
                "'" + newEstate.locality + "', " +
                "'" + newEstate.address + "', " +
                "'" + newEstate.area + "', " +
                "'" + newEstate.roomNumber + "', " +
                "'" + newEstate.floor + "', " +
                "'" + newEstate.maxFloor + "', " +
                "'" + newEstate.material + "', " +
                "'" + newEstate.price + "', " +
                "'" + newEstate.description + "');", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void AddCustomer(Customer customer)
        {
            Connect(@"C:\BD\RealtorEstateAgancy.sqlite");
            connection.Open();
            command = new SQLiteCommand("insert into Customer(fio, email, telephoneNumber) values ("
                + "'" + customer.fio + "'," +
                 "'" + customer.email + "'," +
                  "'" + customer.telephoneNumber + "');", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
        //Павел, я не знаю что это, но мне нужно было собрать проект, поэтому я закомментировал
        //public string GetDealType()
        //{
        //    string dealType;
        //    Connect(@"C:\BD\RealtorEstateAgancy.sqlite");
        //    connection.Open();
        //    command = new SQLiteCommand("select (dealType) from EstateObject")

        //}
        public void Change()
        { }
    }
}
