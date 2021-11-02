using System;
using System.Collections.Generic;
using System.Text;

namespace EstateAgency
{
    class EstateCatalog
    {
        private List<Estate> estateList = new List<Estate>();

        public void AddEstate(Estate estate)
        {
            estateList.Add(estate);
        }

        public bool RemoveEstate(int id)
        {
            foreach (Estate estate in estateList)
            {
                if (estate.Id == id)
                {
                    return estateList.Remove(estate);
                }
            }
            return false;
        }

        public Estate GetEstateById(int id)
        {
            foreach (Estate estate in estateList)
            {
                if (estate.Id == id)
                    return estate;
            }

            return null;
        }
    }
}
