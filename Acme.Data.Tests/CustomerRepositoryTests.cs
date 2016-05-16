using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Acme.Data.Repo;
using System.Linq;
using Acme.Domain;

namespace Acme.Data.Tests
{
    [TestClass]
    public class CustomerRepositoryTests
    {
        [TestMethod]
        public void FindByIdMustReturnResult()
        {
            using (var repo = new Repository<Customer>())
            {
                var customer = repo.FindById<int>(1);
                Assert.IsTrue(customer != null, "Test Passed");
            }
        }

        [TestMethod]
        public void FetchAllMustReturnMoreThanOne()
        {
            using(var repo=new Repository<Customer>())
            {
                var customers = repo.FetchAll();
                Assert.IsTrue(customers.Count()>1, "Test Passed");
            }
        }

        [TestMethod]
        public void SaveMustPersistToDB()
        {
            using (var repo = new Repository<Customer>())
            {
                var customer = repo.FindById<int>(2);
                customer.Name = "Aryan Katoch";
                repo.Save(customer);
            }
            using (var repo = new CustomerRepository())
            {
                var customer = repo.FindById<int>(2);
                Assert.IsTrue(customer.Name == "Aryan Katoch", "Test passed as customer not found");
            }
        }

        [TestMethod]
        public void FetchCustomOne()
        {
            using(var repo = new Repository<Customer>())
            {
                var customerWithOpps = repo
                    .FetchByQuery(c => c.Name.StartsWith("A"));
                Assert.IsTrue(customerWithOpps.Count() ==3, "Test Passed");
            }
        }
    }
}
