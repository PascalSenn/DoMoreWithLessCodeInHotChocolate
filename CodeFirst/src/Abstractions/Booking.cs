using System;

namespace Example.Abstractions
{
    public class Booking
    {
        public Booking(
            Guid id,
            Guid userId,
            DateTime date)
        {
            Id = id;
            UserId = userId;
            Date = date;
        }

        public Guid Id { get; }

        public Guid UserId { get; }

        public DateTime Date { get; }
    }
}
