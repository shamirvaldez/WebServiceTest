using SoapWebService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace SoapWebService.Services
{
    /// <summary>
    /// Summary description for InfoWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class InfoWebService : System.Web.Services.WebService
    {
        private readonly  Functions _functions;
        public InfoWebService()
        {
            _functions = new Functions();
        }

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public List<Clients> GetClient()
        {
            var client = _functions.Clients();
            return client;
        }

        [WebMethod]

        public List<Clients> AddClient(string name, string lastName, string age, string country, string number)
        {
            var clientAdd = new Clients() { Name = name, LastName = lastName, Age = age, Country = country, Number = number};

            return _functions.AddClient(clientAdd);

        }
    }
}
