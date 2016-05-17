using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using DataLayer.Interfaces;
using DomainClasses;

namespace DataLayer.Models
{
  public class CustomerRepository : ICustomerRepository
  {
    SalesContext context;

    public CustomerRepository()
    {
      var uow = new SalesContextUnitOfWork();
      context = uow.Context;
    }

    public CustomerRepository(SalesContextUnitOfWork uow)
    {
      context = uow.Context;
    }

    public IQueryable<Customer> All
    {
      get { return context.Customers; }
    }

    public IQueryable<Customer> AllIncluding(params Expression<Func<Customer, object>>[] includeProperties)
    {
      IQueryable<Customer> query = context.Customers;
      foreach (var includeProperty in includeProperties)
      {
        query = query.Include(includeProperty);
      }
      return query;
    }

    public Customer Find(int id)
    {
      return context.Customers.Find(id);
    }

    public void InsertGraph(Customer customer)
    {
      context.Customers.Add(customer);
    }

    public void InsertOrUpdate(Customer customer)
    {
      if (customer.Id == default(int)) // New entity
      {
        context.Customers.Add(customer);
        //context.Entry(customer).State = EntityState.Added;
      }
      else        // Existing entity
      {
        context.Customers.Add(customer);
        context.Entry(customer).State = EntityState.Modified;
      }
    }

    public void Delete(int id)
    {
      var customer = context.Customers.Find(id);
      context.Customers.Remove(customer);
    }

    public void Save()
    {
      context.SaveChanges();
    }

    public void Dispose()
    {
      //context.Dispose();
    }

 }

}