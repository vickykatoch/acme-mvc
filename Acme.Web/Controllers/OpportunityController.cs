using Acme.Data;
using Acme.Domain;
using Acme.Web.Models;
using AutoMapper;
using System;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace Acme.Web.Controllers
{
    public class OpportunityController : AcmeControllerBase
    {
        private readonly AcmeContext _context = new AcmeContext();

        public JsonResult Add(OpportunityModel opportunity)
        {
            var customer = _context.Customers.Include(x => x.Opportunities).Where(c => c.Id == opportunity.CustomerId).FirstOrDefault();

            Mapper.CreateMap<OpportunityModel, Opportunity>()
                .ForMember(dest => dest.Customer, opt => opt.NullSubstitute(null))
                .ForMember(dest => dest.Id, opt => opt.MapFrom(s=>s.CustomerId));
            var model = Mapper.Map<Opportunity>(opportunity);
            model.Customer = customer;
            model.CreateDate = DateTime.Now;
            customer.Opportunities.Add(model);
            _context.SaveChanges();

            Mapper.CreateMap<Opportunity, OpportunityModel>()
                .ForMember(dest => dest.CustomerId, opt => opt.MapFrom(s => s.Id))
                 .ForMember(dest => dest.CustomerName, opt => opt.MapFrom(s => s.Customer.Name));
            var newModel = Mapper.Map<OpportunityModel>(model);
            return BetterJson(newModel);
            //return BetterJson(_context.Opportunities.Where(o => o.Customer.Id == opportunity.customerId).ToArray());
        }
    }
}
