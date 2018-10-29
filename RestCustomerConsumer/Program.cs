using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using ModelClassCustomer.model;
using Newtonsoft.Json;
using ModelClassCustomer.model;
using RestCustomerService.Controllers;

namespace RestCustomerConsumer
{
    class Program
    {
       

        static void Main(string[] args)
        {
            RestHandler handler = new RestHandler();

            IList<Customer> clist = handler.GetCustomers();

            foreach (var c in clist)
            {
                Console.WriteLine(c);

            }

            Console.ReadLine();





        }
    }
}
