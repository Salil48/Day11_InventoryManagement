using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement1
{
    public class InventoryDetails
    {
        public List<TypesOfRice> typesOfRice;
        public List<TypesOfPulses> typesOfPulses;
        public List<TypesOfWheat> typesOfWheat;
    }

    public class TypesOfRice
    {
        public string Name;
        public int Kg;
        public int Price;
        public string Type;
    }
    public class TypesOfPulses
    {
        public string Name;
        public int Kg;
        public int Price;
        public string Type;
    }
    public class TypesOfWheat
    {
        public string Name;
        public int Kg;
        public int Price;
        public string Type;
    }
}
