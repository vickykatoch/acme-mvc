using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using DataLayer.Interfaces;
using DomainClasses;

namespace DataLayer.Models
{
  public class AddressRepository : IAddressRepository
  {
    SalesContext context;

    public AddressRepository()
    {
      var uow = new SalesContextUnitOfWork();
      context = uow.Context;
    }

    public AddressRepository(SalesContextUnitOfWork uow)
    {
      context = uow.Context;
    }

    public IQueryable<Address> All
    {
      get { return context.Addresses; }
    }

    public IQueryable<Address> AllIncluding(params Expression<Func<Address, object>>[] includeProperties)
    {
      IQueryable<Address> query = context.Addresses;
      foreach (var includeProperty in includeProperties)
      {
        query = query.Include(includeProperty);
      }
      return query;
    }

    public Address Find(int id)
    {
      return context.Addresses.Find(id);
    }

    public void InsertGraph(Address address)
    {
      context.Addresses.Add(address);
    }

    public void InsertOrUpdate(Address address)
    {
      if (address.Id == default(int)) // New entity
      {
        context.Entry(address).State = EntityState.Added;
      }
      else        // Existing entity
      {
        context.Addresses.Add(address);
        context.Entry(address).State = EntityState.Modified;
      }
    }

    public void Delete(int id)
    {
      var address = context.Addresses.Find(id);
      context.Addresses.Remove(address);
    }

    public void Save()
    {
      context.SaveChanges();
    }

    public void Dispose()
    {
    //  context.Dispose();
    }




  }


}