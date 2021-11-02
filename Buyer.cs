using System;
using System.Collections.Generic;
using System.Text;

namespace EstateAgency
{
    class Buyer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public int MaxPrice { get; set; }
        public int MinSize { get; set; }
        
        private static int nextId = 1;

        public Buyer(int id, string name, string address, string phone, string email, int maxPrice, int minSize)
        {
            Id = id;
            Name = name;
            Address = address;
            Phone = phone;
            Email = email;
            MaxPrice = maxPrice;
            MinSize = minSize;
        }
        
    }
}
