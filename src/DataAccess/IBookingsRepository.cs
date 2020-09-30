using System;
using System.Linq;
using System.Threading.Tasks;
using Example.Abstractions;

namespace Example.DataAccess
{
    public interface IBookingsRepository
    {
        Task<Booking>? GetBookingAsync(Guid userId);

        IQueryable<Booking> GetBookings();

        Task<Booking> UpsertBookingAsync(Booking user);
    }
}
