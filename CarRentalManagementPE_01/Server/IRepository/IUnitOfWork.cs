using CarRentalManagementPE_01.Shared.Domain;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace CarRentalManagementPE_01.Server.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        Task Save(HttpContext httpContext);
        IGenericRepository<Make> Makes { get; }
        IGenericRepository<Model> Models { get; }
        IGenericRepository<Vehicle> Vehicles { get; }
        IGenericRepository<Colors> Colors { get; }
        IGenericRepository<Booking> Bookings { get; }
        IGenericRepository<Customer> Customers { get; }
    }
}