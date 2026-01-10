using System.Text.Json;

Console.WriteLine("3D Printer Filament Inventory Tracker");

string filePath = Path.Combine(AppContext.BaseDirectory, "reading-list.json");
string json = File.ReadAllText(filePath);

var options = new JsonSerializerOptions
{
    PropertyNameCaseInsensitive = true
};

List<FilamentSpool> spools = JsonSerializer.Deserialize<List<FilamentSpool>>(json, options) ?? new List<FilamentSpool>();

Console.WriteLine($"Found {spools.Count} spools in your filament inventory:\n");

int index = 1;
foreach (FilamentSpool spool in spools)
{
    PrintSpoolSummary(spool, index);
    index++;
}

static void PrintSpoolSummary(FilamentSpool spool, int index)
{
    Console.WriteLine($"Spool #{index}:");
    Console.WriteLine($"  Brand     : {spool.Brand}");
    Console.WriteLine($"  Item No   : {spool.ItemNumber}");
    Console.WriteLine($"  Color      : {spool.Color}");
    Console.WriteLine($"  Material   : {spool.Material}");
    Console.WriteLine($"  Diameter   : {spool.DiameterMm} mm");
    Console.WriteLine($"  Weight     : {spool.WeightGrams} g");
    Console.WriteLine($"  Remaining  : {spool.RemainingPercentage}%");

    Console.WriteLine();
}

record FilamentSpool(string Brand, string ItemNumber, string Color, string Material, double DiameterMm, int WeightGrams, int RemainingPercentage);
