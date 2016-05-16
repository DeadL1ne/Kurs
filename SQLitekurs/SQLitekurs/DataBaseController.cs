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
                " date text, dealType text, estateObjectType text, material text, lPrice text, uPrice text, locality text, lArea real, uArea real," +
                " roomNumber int, floor integer, maxFloor integer, suggestion text, status text);", connection);
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
        /// Method removes record in database.
        /// </summary>
        /// <param name="id">id for removing</param>
        public void RemoveCustomer(int id)
        {
            connection.Open();
            command = new SQLiteCommand("delete from Customer where id =" + id, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
        /// <summary>
        /// Method removes record in database.
        /// </summary>
        /// <param name="id">id for removing</param>
        public void RemoveRequest(int id)
        {
            connection.Open();
            command = new SQLiteCommand("delete from Request where id =" + id, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
        /// <summary>
        /// Method removes record in database.
        /// </summary>
        /// <param name="id">id for removing</param>
        public void RemoveRealtor(int id)
        {
            connection.Open();
            command = new SQLiteCommand("delete from Realtor where id =" + id, connection);
            command.ExecuteNonQuery();
            connection.Close();
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
        /// Method write all data in DataTable
        /// </summary>
        /// <returns>DataTable with all data.</returns>
        public DataTable DisplayAllDataCustomer()
        {
            connection.Open();
            command = new SQLiteCommand(connection);
            command.CommandText = @"SELECT id, fio, email, telephoneNumber FROM Customer;";
            SQLiteDataReader allDataReader = command.ExecuteReader();
            DataTable allData = new DataTable();
            allData.Load(allDataReader);
            allDataReader.Close();
            connection.Close();
            return allData;
        }
        /// <summary>
        /// Method write all data in DataTable
        /// </summary>
        /// <returns>DataTable with all data.</returns>
        public DataTable DisplayAllDataRequest()
        {
            connection.Open();
            command = new SQLiteCommand(connection);
            command.CommandText = @"SELECT id, customerID, date, dealType, estateObjectType, material, lPrice , uPrice, locality, lArea, uArea, roomNumber, floor, maxFloor, suggestion, status FROM Request;";
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
                + "'" + customer.fio + "', " +
                 "'" + customer.email + "', " +
                  "'" + customer.telephoneNumber + "');", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void AddRequest(Request request)
        {
            Connect(@"C:\BD\RealtorEstateAgancy.sqlite");
            connection.Open();
            //(int id, int customerId, string date, string dealType, string estateObject, string material, string lPrice,
            //string uPrice, string locality, double lArea, double uArea, int roomNumber, int floor, int maxFloor, string suggestion, string status)
            command = new SQLiteCommand("insert into Request(customerID, date, dealType, estateObjectType, material, lPrice , uPrice, locality, lArea, uArea, roomNumber, floor, maxFloor, suggestion, status) values (" +
                "'" + request.customerId + "', " +
                "'" + request.date + "', " +
                "'" + request.dealType + "', " +
                "'" + request.estateObjectType + "', " +
                "'" + request.material + "', " +
                "'" + request.lPrice + "', " +
                "'" + request.uPrice + "', " +
                "'" + request.locality + "', " +
                "'" + request.lArea + "', " +
                "'" + request.uArea + "', " +
                "'" + request.roomNumber + "', " +
                "'" + request.floor + "', " +
                "'" + request.maxFloor + "', " +
                "'" + request.suggestion + "', " +
                "'" + request.status + "');", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void AddRealtor(Realtor realtor)
        {
            Connect(@"C:\BD\RealtorEstateAgancy.sqlite");
            connection.Open();
            command = new SQLiteCommand("insert into Realtor(fio, login, password, telephoneNumber) values ("
                + "'" + realtor.fio + "', " +
                "'" + realtor.login + "', " +
                 "'" + realtor.password + "', " +
                  "'" + realtor.telephoneNumber + "');", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public List<EstateObject> GetListEstate()
        {
            Connect(@"C:\BD\RealtorEstateAgancy.sqlite");
            connection.Open();
            command = new SQLiteCommand(connection);
            command.CommandText = @"SELECT id, dealType, locality, address, area, roomNumber, floor, maxFloor, material, price, description FROM EstateObject;";
            SQLiteDataReader allDataReader = command.ExecuteReader();
            DataTable allData = new DataTable();
            allData.Load(allDataReader);
            allDataReader.Close();
            connection.Close();
            List<EstateObject> lstObj = new List<EstateObject>();
            for (int i = 0; i < allData.Rows.Count; i++)
            {
                EstateObject tempEstObj = new EstateObject();
                try
                {

                    tempEstObj.id = Convert.ToInt32(allData.Rows[i].ItemArray[0]);
                    tempEstObj.dealType = Convert.ToString(allData.Rows[i].ItemArray[1]);
                    tempEstObj.locality = Convert.ToString(allData.Rows[i].ItemArray[2]);
                    tempEstObj.address = Convert.ToString(allData.Rows[i].ItemArray[3]);
                    tempEstObj.area = Convert.ToString(allData.Rows[i].ItemArray[4]);
                    tempEstObj.roomNumber = Convert.ToString(allData.Rows[i].ItemArray[5]);
                    tempEstObj.floor = Convert.ToString(allData.Rows[i].ItemArray[6]);
                    tempEstObj.maxFloor = Convert.ToString(allData.Rows[i].ItemArray[7]);
                    tempEstObj.material = Convert.ToString(allData.Rows[i].ItemArray[8]);
                    tempEstObj.price = Convert.ToString(allData.Rows[i].ItemArray[9]);
                    tempEstObj.description = Convert.ToString(allData.Rows[i].ItemArray[10]);
                }
                catch
                {

                }
                lstObj.Add(tempEstObj);

            }
            return lstObj;
        }


        /// <summary>
        /// Method returns an Request Objectn for the given id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Request GetRequestOfId(int id)
        {
            connection.Open();
            command = new SQLiteCommand(connection);
            command.CommandText = @"SELECT id, customerID, date, dealType, estateObjectType, material, lPrice , uPrice, locality, lArea, uArea, roomNumber, floor, maxFloor, suggestion, status FROM Request WHERE id = " + id + " ;";
            SQLiteDataReader allDataReader = command.ExecuteReader();
            DataTable allData = new DataTable();
            allData.Load(allDataReader);
            Request request = new Request();
            request.id = id;
            request.customerId = Convert.ToInt32(allData.Rows[0].ItemArray[1]);
            request.date = Convert.ToString(allData.Rows[0].ItemArray[2]);
            request.dealType = Convert.ToString(allData.Rows[0].ItemArray[3]);
            request.estateObjectType = Convert.ToString(allData.Rows[0].ItemArray[4]);
            request.material = Convert.ToString(allData.Rows[0].ItemArray[5]);
            request.lPrice = Convert.ToString(allData.Rows[0].ItemArray[6]);
            request.uPrice = Convert.ToString(allData.Rows[0].ItemArray[7]);
            request.locality = Convert.ToString(allData.Rows[0].ItemArray[8]);
////////////////////// ////Double -> string////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            request.lArea = Convert.ToString(allData.Rows[0].ItemArray[9]);
            request.uArea = Convert.ToString(allData.Rows[0].ItemArray[10]);
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            request.roomNumber = Convert.ToInt32(allData.Rows[0].ItemArray[11]);
            request.floor = Convert.ToInt32(allData.Rows[0].ItemArray[12]);
            request.maxFloor = Convert.ToInt32(allData.Rows[0].ItemArray[13]);
            request.suggestion = Convert.ToString(allData.Rows[0].ItemArray[14]);
            request.status = Convert.ToString(allData.Rows[0].ItemArray[15]);
            allDataReader.Close();
            connection.Close();
            return request;
        }

        /// <summary>
        /// Method for  getting estate obj from database
        /// </summary>
        /// <param name="objId">Object id in database</param>
        /// <returns>EstateObject with all filled fields</returns>
        public EstateObject GetEstateObject(int objId)
        {
            EstateObject estate = new EstateObject();
            Connect(@"C:\BD\RealtorEstateAgancy.sqlite");
            connection.Open();
            command = new SQLiteCommand("select dealType, locality, address, area, roomNumber, floor, maxFloor," +
                "material, price, description, avitoId from EstateObject where id = " + objId + ";", connection);
            SQLiteDataReader dealTypeReader = command.ExecuteReader();
            while (dealTypeReader.Read())
            {
                estate.dealType = dealTypeReader.GetString(0);
                estate.locality = dealTypeReader.GetString(1);
                estate.address = dealTypeReader.GetString(2);
                estate.area = dealTypeReader.GetString(3);
                estate.roomNumber = dealTypeReader.GetString(4);
                estate.floor = dealTypeReader.GetString(5);
                estate.maxFloor = dealTypeReader.GetString(6);
                estate.material = dealTypeReader.GetString(7);
                estate.price = dealTypeReader.GetString(8);
                estate.description = dealTypeReader.GetString(9);
                estate.avitoId = dealTypeReader.GetString(10);
            }
            dealTypeReader.Close();
            connection.Close();
            return estate;
        }
        public void Edit(EstateObject estate, int objId)
        {
            connection.Open();
            command = new SQLiteCommand(connection);
            command.CommandText = @"UPDATE EstateObject SET " +
                 "dealType = '" + estate.dealType + "'," +
                 "locality = '" + estate.locality + "'," +
                 "address = '" + estate.address + "'," +
                 "area = '" + estate.area + "'," +
                 "roomNumber = '" + estate.roomNumber + "'," +
                 "floor = '" + estate.floor + "'," +
                 "maxFloor = '" + estate.maxFloor + "'," +
                 "material = '" + estate.material + "'," +
                 "price = '" + estate.price + "'," +
                 "description = '" + estate.description + "' " + "where id =" + objId;
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
