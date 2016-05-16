using Acme.Data;
using Acme.Data.Repo;
using Acme.Domain;
using AutoMapper;
using ConsoleApplication1.Model;
using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Oppurtunities();
            Customers();
            
            Risk();
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
