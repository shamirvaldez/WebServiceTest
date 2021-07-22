using SoapWebService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoapWebService.Services
{
    public class Functions : IServices
    {
        List<Clients> clientList = new List<Clients>();
        public List<Clients> Clients()
        {
            

            clientList.Add(new Clients() { Name = "Isaac", LastName = "Valdez", Age = "30", Country = "Republica Dominicana", Number = "8095643304" });
            clientList.Add(new Clients() { Name = "Monica", LastName = "Peng", Age = "28", Country = "China", Number = "234133504" });
            clientList.Add(new Clients() { Name = "Alberto", LastName = "Mendoza", Age = "24", Country = "Puerto Rico", Number = "7875648907" });
            clientList.Add(new Clients() { Name = "Luis", LastName = "Lopez", Age = "35", Country = "Mexico", Number = "1395244304" });
            clientList.Add(new Clients() { Name = "Abdiel", LastName = "Colon", Age = "30", Country = "USA", Number = "9092643664" });


            return clientList.ToList();
        }

        public List<Clients> AddClient(Clients models)
        {
   
            clientList.Add(new Clients() { Name = models.Name, LastName = models.LastName, Age = models.Age, Country = models.Country, Number = models.Number });

            return clientList.ToList();

        }
    }
}