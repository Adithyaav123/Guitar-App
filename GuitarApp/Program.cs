using GuitarApp.Model;

namespace GuitarApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();
            InitializeInventory(inventory);

            GuitarSpec whatErinLikes =
              new GuitarSpec(Builder.FENDER, "Stratocastor",
                             Model.Type.ELECTRIC, 6, Wood.ALDER, Wood.ALDER);
            List<Guitar> matchingGuitars = inventory.Search(whatErinLikes);
            if (matchingGuitars.Count > 0)
            {
                Console.WriteLine("Erin, you might like these guitars:");
                foreach (Guitar guitar in matchingGuitars)
                {
                    GuitarSpec spec = guitar.GetSpec();
                    Console.WriteLine($"  We have a {spec.Builder} {spec.Model} " +
                        $"{spec.Type} guitar:\n     {spec.BackWood} back and sides,\n     " +
                        $"{spec.TopWood} top.\n  You can have it for only ${guitar.GetPrice()}!\n  ----");
                }
            }
            else
            {
                Console.WriteLine("Sorry, Erin, we have nothing for you.");
            }
        }

        private static void InitializeInventory(Inventory inventory)
        {
            inventory.AddGuitar("11277", 3999.95,
              new GuitarSpec(Builder.COLLINGS, "CJ", Model.Type.ACOUSTIC, 6,
                             Wood.INDIAN_ROSEWOOD, Wood.SITKA));
            inventory.AddGuitar("V95693", 1499.95,
              new GuitarSpec(Builder.FENDER, "Stratocaster", Model.Type.ELECTRIC, 6,
                             Wood.ALDER, Wood.ALDER));
            inventory.AddGuitar("V9512", 1549.95,
              new GuitarSpec(Builder.FENDER, "Stratocastor", Model.Type.ELECTRIC, 6,
                             Wood.ALDER, Wood.ALDER));
            inventory.AddGuitar("122784", 5495.95,
              new GuitarSpec(Builder.MARTIN, "D-18", Model.Type.ACOUSTIC, 6,
                             Wood.MAHOGANY, Wood.ADIRONDACK));
            inventory.AddGuitar("76531", 6295.95,
              new GuitarSpec(Builder.MARTIN, "OM-28", Model.Type.ACOUSTIC, 6,
                             Wood.BRAZILIAN_ROSEWOOD, Wood.ADIRONDACK));
            inventory.AddGuitar("70108276", 2295.95,
              new GuitarSpec(Builder.GIBSON, "Les Paul", Model.Type.ELECTRIC, 6,
                             Wood.MAHOGANY, Wood.MAHOGANY));
            inventory.AddGuitar("82765501", 1890.95,
              new GuitarSpec(Builder.GIBSON, "SG '61 Reissue", Model.Type.ELECTRIC, 6,
                             Wood.MAHOGANY, Wood.MAHOGANY));
          
        }
    }
}