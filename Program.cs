namespace InventoryManagement1
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            string path = "J:\\240\\InventoryManagement1\\InventoryManagement1\\Inventory.json";

            ReadData readData = new ReadData();

            var Data = readData.Read(path);

            Console.WriteLine("Types of Rice");
            Console.WriteLine("-------------------");
            for (int i = 0; i < Data.typesOfRice.Count; i++)
            {
                Console.WriteLine(Data.typesOfRice[i].Name);
                Console.WriteLine(Data.typesOfRice[i].Kg);
                Console.WriteLine(Data.typesOfRice[i].Price);
                Console.WriteLine(Data.typesOfRice[i].Type);
                Console.WriteLine("-------------------");
                int val = Data.typesOfRice[i].Kg * Data.typesOfRice[i].Price;
                Console.WriteLine("The Price for " + Data.typesOfRice[i].Kg + "kg is " + val);
                Console.WriteLine("-------------------");
            }
            Console.WriteLine("-------------------");
            Console.WriteLine("Types of Pulses");
            Console.WriteLine("-----------------");
            for (int i = 0; i < Data.typesOfPulses.Count; i++)
            {
                Console.WriteLine(Data.typesOfPulses[i].Name);
                Console.WriteLine(Data.typesOfPulses[i].Kg);
                Console.WriteLine(Data.typesOfPulses[i].Price);
                Console.WriteLine(Data.typesOfPulses[i].Type);
                Console.WriteLine("-------------------");
                int val = Data.typesOfPulses[i].Kg * Data.typesOfPulses[i].Price;
                Console.WriteLine("The Price for " + Data.typesOfPulses[i].Kg + "kg is " + val );
                Console.WriteLine("-------------------");
            }
            Console.WriteLine("-------------------");
            Console.WriteLine("Types of Wheat");
            Console.WriteLine("-------------------");
            for (int i = 0; i < Data.typesOfWheat.Count; i++)
            {
                Console.WriteLine(Data.typesOfWheat[i].Name);
                Console.WriteLine(Data.typesOfWheat[i].Kg);
                Console.WriteLine(Data.typesOfWheat[i].Price);
                Console.WriteLine(Data.typesOfWheat[i].Type);
                Console.WriteLine("-------------------");
                int val = Data.typesOfWheat[i].Kg * Data.typesOfWheat[i].Price;
                Console.WriteLine("The Price for " + Data.typesOfWheat[i].Kg + "kg is " + val);
                Console.WriteLine("-------------------");
            }
        }
    }
}
