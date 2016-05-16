﻿using Acme.Domain;
using AutoMapper;

namespace ConsoleApplication1.Model
{
    public class MapBuilder
    {
        public static void ToViewModelMap()
        {
            Mapper.CreateMap<Opportunity, OpportunityModel>()
                    .ForMember(dest => dest.CustomerId, opt => opt.MapFrom(s => s.Customer.Id));
            Mapper.CreateMap<Risk, RiskModel>()
                .ForMember(dest => dest.CustomerId, opt => opt.MapFrom(s => s.Customer.Id));
            Mapper.CreateMap<Customer, CustomerModel>()
                .ForMember(dest => dest.Risks, opt => opt.MapFrom(s => s.Risks))
                .ForMember(dest => dest.Opportunities, opt => opt.MapFrom(s => s.Opportunities));
        }
        public static void FromViewModelMap()
        {
            Mapper.CreateMap<OpportunityModel, Opportunity>()
                    .ForMember(dest => dest.Customer, opt => opt.NullSubstitute(null));
            Mapper.CreateMap<RiskModel,Risk>()
                    .ForMember(dest => dest.Customer, opt => opt.NullSubstitute(null));
            Mapper.CreateMap<CustomerModel,Customer>()
                .ForMember(dest => dest.Risks, opt => opt.MapFrom(s => s.Risks))
                .ForMember(dest => dest.Opportunities, opt => opt.MapFrom(s => s.Opportunities));
        }
    }
}
