using Acme.Domain;
using AutoMapper;

namespace Acme.Web.Models
{
    public class ModelViewModelMapper
    {
        public static void Map()
        {
            Mapper.CreateMap<Opportunity, OpportunityModel>()
                    .ForMember(dest => dest.CustomerId, opt => opt.MapFrom(s => s.Customer.Id));
            Mapper.CreateMap<Risk, RiskModel>()
                .ForMember(dest => dest.CustomerId, opt => opt.MapFrom(s => s.Customer.Id));
            Mapper.CreateMap<Customer, CustomerModel>()
                .ForMember(dest => dest.Risks, opt => opt.MapFrom(s => s.Risks))
                .ForMember(dest => dest.Opportunities, opt => opt.MapFrom(s => s.Opportunities));

            Mapper.CreateMap<OpportunityModel, Opportunity>()
                    .ForMember(dest => dest.Customer, opt => opt.NullSubstitute(null));
            Mapper.CreateMap<RiskModel, Risk>()
                    .ForMember(dest => dest.Customer, opt => opt.NullSubstitute(null));
            Mapper.CreateMap<CustomerModel, Customer>()
                .ForMember(dest => dest.Risks, opt => opt.MapFrom(s => s.Risks))
                .ForMember(dest => dest.Opportunities, opt => opt.MapFrom(s => s.Opportunities));
        }
    }
}