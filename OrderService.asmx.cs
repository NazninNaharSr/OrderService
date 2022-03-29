using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace OrderService
{
    /// <summary>
    /// Summary description for OrderService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class OrderService : System.Web.Services.WebService
    {

        [WebMethod]
        public string OrderInformation()
        {
            return "Show Order Information";
        }
        [WebMethod]
        public string AddOrder()
        {
            return "Order added successfully";
        }
        [WebMethod]
        public string DeleteOrder()
        {
            return "Order deleted successfuly";
        }
        [WebMethod]
        public string UpdateOrder()
        {
            return "Order updated successfully";
        }
        [WebMethod]
        public string ViewOrder()
        {
            return "show order list";
        }
    }
}
