using System;
using System.Collections.Generic;
using System.Text;

namespace EstateAgency
{
    class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        private static int nextId = 1;

        public Seller(string name, string address, string phone, string email)
        {
            Id = nextId++;
            Name = name;
            Address = address;
            Phone = phone;
            Email = email;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Address: {Address}, Phone: {Phone}, Email: {Email}";
        }
    }
}
