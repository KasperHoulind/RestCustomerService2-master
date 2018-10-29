using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using ModelClassCustomer.model;
using Newtonsoft.Json;

namespace RestCustomerConsumer
{
    class RestHandler
    {
        public IList<Customer> GetCustomers()
        {
            // laver en ny instance af HTTPClient der kan handle requests, using sørger for at den lukker forbindelsen efter brug
            using (HttpClient client = new HttpClient())
            {
                //laver en instance af typen string der tager imod HTTPClienten.
                // og klader en metode for at gette en værdi/value, dne taget en enkel parameter: REST URIen
                string content = client.GetStringAsync("http://localhost:61404/api/Customers").Result;
                //create a instance of a list which takes the type Customer from library, the JsonConvert method deserializes the jason object and 
                //outputs it to the system 
                IList<Customer> cList = JsonConvert.DeserializeObject<IList<Customer>>(content);
                return cList;
            }
    }
}


