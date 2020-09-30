using System;

namespace Example.Abstractions
{
    public class User
    {
        public User(
            Guid id,
            string userName,
            string name,
            string surname)
        {
            Id = id;
            UserName = userName;
            Name = name;
            Surname = surname;
        }

        public Guid Id { get; }
        public string UserName { get; }
        public string Name { get; }
        public string Surname { get; }
    }
}
