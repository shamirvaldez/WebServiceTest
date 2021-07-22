using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebServiceTest.Models;

namespace WebServiceTest.Controllers
{
    public class ClientController : Controller
    {
        ClientInfoWS.InfoWebServiceSoapClient clientWS = new ClientInfoWS.InfoWebServiceSoapClient();
        public ClientController()
        {

        }

        // GET: Client
        public ActionResult Index()
        {
         var client = clientWS.GetClient().ToList();


            List<Clients> clients = new List<Clients>();
           

           foreach (var item in client)
          {
                var clientValue = new Clients();

                clientValue.Name = item.Name;
                clientValue.LastName = item.LastName;
                clientValue.Country = item.Country;
                clientValue.Age = item.Age;
                clientValue.Number = item.Number;

                clients.Add(clientValue);
            }

            return View(clients);
        }

        // GET: Client/Details/
        public ActionResult AddClient(Clients model)
        {
            return View();
        }

        // GET: Client/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Client/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Client/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Client/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Client/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Client/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
