namespace Assignment_6._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HouseLinkedList houses = MockData();
            houses.Display();

            if (args.Length > 0)
            {
                if (int.TryParse(args[0], out int houseNumber))
                    Console.WriteLine(houses.Search(houseNumber));
            }
            else
            {
                if (!houses.IsEmpty())
                {
                    Console.Write("Enter a house number to find: ");
                    int houseNumber;
                    while (!int.TryParse(Console.ReadLine(), out houseNumber))
                        Console.Write("Invalid input! Please try again: ");
                    Console.WriteLine(houses.Search(houseNumber));
                }
            }

            Console.WriteLine($"\nRemoveLast: {houses.RemoveLast()}");
            houses.Display();

            Console.WriteLine($"\nRemoveFirst: {houses.RemoveFirst()}");
            houses.Display();

            House house = new House() { number = 18, address = "A Street", houseType = HouseType.Ranch };
            Console.WriteLine($"\nAddFirst: {house}");
            houses.AddFirst(house);
            houses.Display();

            house = new House() { number = 21, address = "B Street", houseType = HouseType.Ranch };
            Console.WriteLine($"\nAddLast: {house}");
            houses.AddLast(house);
            houses.Display();
        }
        static HouseLinkedList MockData()
        {
            HouseLinkedList houses = new();
            for (int i = 5; i > 0; i--)
                houses.AddFirst(new House() { number = i * 3, address = "Main Street", houseType = (HouseType)(i % 2) });
            return houses;
        }
    }
}
