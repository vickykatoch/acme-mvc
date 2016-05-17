using Acme.Data;
using Acme.Data.Repo;
using Acme.Domain;
using AutoMapper;
using ConsoleApplication1.Model;
using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            LinqQueries();
            //Oppurtunities();
            //Customers();

            //Risk();
            Console.Read();
        }
        static void LinqQueries()
        {
            double[] doubles = { 1.7, 2.3, 1.9, 4.1, 2.9 };

            //int[] array = { 1, 3, 5, 7 };
            //array
            //    .GroupBy(a => a % 2 == 0)
            //    .ToDictionary(grp => grp.Key, grp => grp.Count());


        }
        static void Customers()
        {
            MapBuilder.ToViewModelMap();
            MapBuilder.FromViewModelMap();
            using (var repo = new CustomerRepository())
            {
                var op = repo.FecthById(1, true);
                
                var rs = Mapper.Map<CustomerModel>(op);
                Console.WriteLine(rs);
                var rs1 = Mapper.Map<Customer>(rs);
                Console.WriteLine(rs1);

            }
        }
        static void Oppurtunities()
        {
            using (var repo = new OpportunityRepository())
            {
                var op = repo.FecthById(1,true);
                MapBuilder.ToViewModelMap();
                MapBuilder.FromViewModelMap();
                var rs = Mapper.Map<OpportunityModel>(op);
                Console.WriteLine(rs);

                var rs1 = Mapper.Map<Opportunity>(rs);
                Console.WriteLine(rs1);
            }
        }
        static void Risk()
        {
            using (var repo = new RiskRepository())
            {
                MapBuilder.ToViewModelMap();
                var risk = repo.FetchAll();
                var rs = Mapper.Map<IEnumerable<RiskModel>>(risk);
                Console.WriteLine(rs);
            }
        }
    }
}
