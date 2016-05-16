using System.Web.Mvc;
using Acme.Data.Repo;
using Acme.Domain;
using System.Linq;
using System;
using AutoMapper.QueryableExtensions;
using Acme.Web.Models;
using Acme.Web.Xtns;
using AutoMapper;
using System.Collections.Generic;
using System.Net;

namespace Acme.Web.Controllers
{
    public class CustomerController : AcmeControllerBase
    {
        private readonly IRepository<Customer> repository =
            new Repository<Customer>();

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(CustomerModel customer)
        {
            ModelViewModelMapper.Map();
            var model = Mapper.Map<Customer>(customer);
            if (repository.Save(model))
            {
                return BetterJson(Mapper.Map<Customer>(model));
            }
            return new HttpStatusCodeResult(HttpStatusCode.InternalServerError);
        }

        public JsonResult All()
        {
            ModelViewModelMapper.Map();
            var customers = Mapper
                .Map<IEnumerable<CustomerModel>>(repository.FetchAll());
            return BetterJson(customers.ToArray());
        }

        protected override void Dispose(bool disposing)
        {
            repository.Dispose();
            base.Dispose(disposing);
        }

        
    }
}