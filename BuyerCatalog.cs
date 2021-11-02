using System;
using System.Collections.Generic;
using System.Text;

namespace EstateAgency
{
    class BuyerCatalog
    {
        private Dictionary<int,Buyer> buyerDictionary = new Dictionary<int, Buyer>();

        public void AddBuyer(Buyer buyer)
        {
            if (!buyerDictionary.ContainsKey(buyer.Id))
                buyerDictionary.Add(buyer.Id,buyer);
        }

        public bool RemoveBuyer(int buyerId)
        {
            if (buyerDictionary.ContainsKey(buyerId))
            {
                return buyerDictionary.Remove(buyerId);
            }
            return false;
        }

        public Buyer GetBuyerById(int id)
        {
            if (!buyerDictionary.ContainsKey(id))
                return buyerDictionary[id];
            return null;
        }

        public Buyer GetBuyerByPhone(string phone)
        {
            foreach (var buyerDictionaryKey in buyerDictionary.Keys)
            {
                if (buyerDictionary[buyerDictionaryKey].Phone.Equals(phone)) { }
                    return buyerDictionary[buyerDictionaryKey];
            }
            return null;
        }

        public List<Buyer> GetBuyersByName(string name)
        {
            List<Buyer> buyerList = new List<Buyer>();
            foreach (var buyerDictionaryKey in buyerDictionary.Keys)
            {
                if ((buyerDictionary[buyerDictionaryKey].Name).ToLower().Equals(name.ToLower())) { }
                    buyerList.Add(buyerDictionary[buyerDictionaryKey]);
            }
            return buyerList;
        }

    }
}
