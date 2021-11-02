using System;
using System.Collections.Generic;
using System.Text;

namespace EstateAgency
{
    class Estate
    {
        public int Id { get; set; }
        public string EstateType { get; set; }
        public string Address { get; set; }
        public int Price { get; set; }
        public int Size { get; set; }
        public int Room { get; set; }
        public Seller Seller { get; set; }

        private static int nextId = 1;

        public Estate(string estateType, string address, int price, int size, int room, Seller seller)
        {
            Id = nextId++;
            EstateType = estateType;
            Address = address;
            Price = price;
            Size = size;
            Room = room;
            Seller = seller;
        }

        public override string ToString()
        {
            return $"Id: {Id}, EstateType: {EstateType}, Address: {Address}, Price: {Price}, Size: {Size}, Room: {Room}, Seller: {Seller}";
        }
    }
}
