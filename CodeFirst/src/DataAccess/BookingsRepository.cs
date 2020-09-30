using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Example.Abstractions;
using System.Threading.Tasks;

namespace Example.DataAccess
{
    public class BookingsRepository : IBookingsRepository
    {
        public Dictionary<Guid, Booking> _bookings = new Booking[] {
            new Booking(
                Guid.Parse("c8b6226c-246c-4f98-8154-b526ee337221"),
                Guid.Parse("1a04e0c4-858e-486b-aa56-1e251bce454b"),
                DateTime.Now.AddDays(1)),
            new Booking(
                Guid.Parse("92d175b7-7b1d-4869-b9c0-eb67b48234bb"),
                Guid.Parse("46c2a5f5-cb76-43e7-89a3-f33b690e9c40"),
                DateTime.Now),
            new Booking(
                Guid.Parse("da306369-c139-499f-94d4-7f4d21e94ba3"),
                Guid.Parse("738160ae-4c67-48e5-a64f-66199c3afe7b"),
                DateTime.Now.AddDays(-1)),
        }.ToDictionary(x => x.Id);

        public IQueryable<Booking> GetBookings() => _bookings.Values.AsQueryable();

        public Task<Booking> UpsertBookingAsync(Booking user)
        {
            _bookings[user.Id] = user;
            return Task.FromResult(user);
        }

        public Task<Booking?> GetBookingAsync(Guid userId)
        {
            if (_bookings.TryGetValue(userId, out Booking? user))
            {
                return Task.FromResult<Booking?>(user);
            }
            return Task.FromResult<Booking?>(null);
        }
    }
}
