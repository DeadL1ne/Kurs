using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using xNet;

namespace ParserAvito
{
    /// <summary>
    /// Class for parsing html pages from avito.ru
    /// </summary>
    public class WebParser
    {
        /// <summary>
        /// Method for getting quantity of pages with flats on avito.ru
        /// </summary>
        /// <returns>quantity of pages with flats on avito.ru</returns>
        public int GetCountPages()
        {
            int countPages = 0;
            using (var request = new HttpRequest())
            {
                string sourcePage;
                sourcePage = request.Get("https://www.avito.ru/ulyanovsk/kvartiry").ToString();
                countPages = Convert.ToInt32(sourcePage.Substrings("ulyanovsk/kvartiry?p=", "\">", 0)[10]);
            }
            return countPages;
        }
        /// <summary>
        /// Method gets a reference to a specific page 
        /// </summary>
        /// <param name="objectNumber">Current number of estate object on page</param>
        /// <param name="pageNum">Page number</param>
        /// <returns>A part of estate object's personal reference</returns>
        public string GetEstateObjectId(int objectNumber, int pageNum)
        {
            string objId;
            using (var request = new HttpRequest())
            {
                string sourcePage;
                sourcePage = request.Get("https://www.avito.ru/ulyanovsk/kvartiry?p=" + pageNum).ToString();
                objId = sourcePage.Substrings("<a class=\"item-description-title-link\" href=\"/ulyanovsk/kvartiry/", "\" title=", 0)[objectNumber];
            }
            return objId;
        }
        /// <summary>
        /// Method for getting html page of estate object
        /// </summary>
        /// <param name="estateObjectId">A part of reference to a specific page of estate object</param>
        /// <returns>Line with html page's text</returns>
        public string GetSourcePage(string estateObjectId)
        {
            string sourcePage;
            using (var request = new HttpRequest())
            {
                sourcePage = request.Get("https://www.avito.ru/ulyanovsk/kvartiry/" + estateObjectId).ToString();
            }
            return sourcePage;
        }
        /// <summary>
        /// Method for getting address of estate object
        /// </summary>
        /// <param name="sourcePage">Line with html page's text</param>
        /// <returns>Address of estate object from avito.ru</returns>
        public string GetAddress(string sourcePage)
        {
            string address;
            try
            {
                address = sourcePage.Substrings("<span itemprop=\"streetAddress\">", "</span>", 0)[0];
            }
            catch (IndexOutOfRangeException)
            {
                address = "Нет";
            }
            return address;
        }
        /// <summary>
        /// Method for getting locality of estate object
        /// </summary>
        /// <param name="estateObjectId">Line with html page's text</param>
        /// <returns>Area of estate object from avito.ru</returns>
        public string GetLocality(string sourcePage)
        {
            string locality;
            try
            {

                locality = sourcePage.Substrings("<span id=\"toggle_map\" class=\"pseudo-link \">", ", <span itemprop=\"streetAddress", 0)[0];
            }
            catch (IndexOutOfRangeException ex)
            {
                locality = sourcePage.Substrings("<span class=\"pseudo-link \" id=\"toggle_map\"><span itemprop=\"name\">Ульяновск</span>,", "</span>", 0)[0];
            }
            return locality;
        }
        /// <summary>
        /// Method for getting price of estate object
        /// </summary>
        /// <param name="sourcePage">Line with html page's text</param>
        /// <returns>Price of estate object</returns>
        public string GetPrice(string sourcePage)
        {
            string price;
            price = sourcePage.Substrings("<span itemprop=\"price\">", "</span>", 0)[0];
            return price;
        }
        /// <summary>
        /// Method for getting deal type of estate object(selling,rent, etc.)
        /// </summary>
        /// <param name="sourcePage">Line with html page's text</param>
        /// <returns>Deal type of estate object</returns>
        public string GetDealType(string sourcePage)
        {
            string dealType;
            dealType = sourcePage.Substrings("Тип объявления &mdash; ", "\"", 0)[0];
            return dealType;
        }
        /// <summary>
        /// Method for getting number of rooms in estate object
        /// </summary>
        /// <param name="">A part of reference to a specific page of estate object</param>
        /// <returns>Number of rooms in estate object</returns>
        public string GetRoomNumber(string estateObjectId)
        {
            string roomNumber;
            int index = estateObjectId.IndexOf("-k_kvar");
            roomNumber = estateObjectId[index - 1].ToString();
            return roomNumber;
        }
        /// <summary>
        /// Method for getting area of estate object
        /// </summary>
        /// <param name="sourcePage">Line with html page's text</param>
        /// <returns>Area of estate object</returns>
        public string GetArea(string sourcePage)
        {
            string area;
            try
            {
                area = sourcePage.Substrings("квартира, ", " м²", 0)[0];
            }
            catch (IndexOutOfRangeException)
            {
                area = "Не указана";
            }
            return area;
        }
        /// <summary>
        /// Method for getting floor of estate object
        /// </summary>
        /// <param name="sourcePage">Line with html page's text</param>
        /// <returns>Floor of estate object</returns>
        public string GetFloor(string sourcePage)
        {
            string floor;
            try
            {
                floor = sourcePage.Substrings("м², ", "/", 0)[0];
            }
            catch (IndexOutOfRangeException)
            {
                floor = "Не указан";
            }
            return floor;
        }
        /// <summary>
        /// Method for getting max floor in building
        /// </summary>
        /// <param name="sourcePage">Line with html page's text</param>
        /// <returns>Max floor in the building</returns>
        public string GetMaxFloor(string sourcePage)
        {
            string maxFloor;
            try
            {
                maxFloor = sourcePage.Substrings("/", "эт.", 0)[0];
            }
            catch (IndexOutOfRangeException)
            {
                maxFloor = "Не указан";
            }
            return maxFloor;
        }
        /// <summary>
        /// Method for getting material of building
        /// </summary>
        /// <param name="sourcePage">Line with html page's text</param>
        /// <returns>Material of building</returns>
        public string GetMaterial(string sourcePage)
        {
            string material;
            try
            {
                material = sourcePage.Substrings("Тип дома &mdash;", "\"", 0)[0];
            }
            catch (IndexOutOfRangeException)
            {
                material = "Не указан";
            }
            return material;
        }
        /// <summary>
        /// Method for getting seller's name
        /// </summary>
        /// <param name="sourcePage">Line with html page's text</param>
        /// <returns>Seller's name</returns>
        public string GetSellerName(string sourcePage)
        {
            string sellerName;
            sellerName = sourcePage.Substrings("<strong itemprop=\"name\">", "</strong>", 0)[0];
            return sellerName;
        }
        /// <summary>
        /// Method for getting seller's telephone number
        /// </summary>
        /// <param name="sourcePage">Line with html page's text</param>
        /// /// <returns>Seller's telephone number</returns>
        public string GetSellerNumber(string estateObjectId)
        {
            string telephoneNumberRef;
            using (var request = new HttpRequest())
            {
                string sourcePage;
                sourcePage = request.Get("https://www.avito.ru/ulyanovsk/kvartiry/" + estateObjectId).ToString();
                try
                {
                    telephoneNumberRef = sourcePage.Substrings("<img class=\"description__phone-img\" src=", ">", 0)[0];
                }
                catch(IndexOutOfRangeException)
                {
                    telephoneNumberRef = "Не указан";
                }

            }
            return telephoneNumberRef;

        }
        /// <summary>
        /// Method for getting description about estate object
        /// </summary>
        /// <param name="sourcePage">Line with html page's text</param>
        /// <returns>Description of estate object</returns>
        public string GetDescription(string sourcePage)
        {
            string description;
            try
            {
                description = sourcePage.Substrings("<div id=\"desc_text\" itemprop=\"description\"><p>", "</p></div>", 0)[0];
            }
            catch(IndexOutOfRangeException)
            {
                description = "Отсутствует";
            }
            return description;
        }
    }
}
