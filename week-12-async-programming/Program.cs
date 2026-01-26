using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Week12AsyncProgramming
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("⢀⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
            Console.WriteLine("⢻⣿⡗⢶⣤⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣠⣄");
            Console.WriteLine("⠀⢻⣇⠀⠈⠙⠳⣦⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣤⠶⠛⠋⣹⣿⡿");
            Console.WriteLine("⠀⠀⠹⣆⠀⠀⠀⠀⠙⢷⣄⣀⣀⣀⣤⣤⣤⣄⣀⣴⠞⠋⠉⠀⠀⠀⢀⣿⡟⠁");
            Console.WriteLine("⠀⠀⠀⠙⢷⡀⠀⠀⠀⠀⠉⠉⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⡾⠋⠀⠀");
            Console.WriteLine("⠀⠀⠀⠀⠈⠻⡶⠂⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⣠⡾⠋⠀⠀⠀⠀");
            Console.WriteLine("⠀⠀⠀⠀⠀⣼⠃⠀⢠⠒⣆⠀⠀⠀⠀⠀⠀⢠⢲⣄⠀⠀⠀⢻⣆⠀⠀⠀⠀⠀");
            Console.WriteLine("⠀⠀⠀⠀⢰⡏⠀⠀⠈⠛⠋⠀⢀⣀⡀⠀⠀⠘⠛⠃⠀⠀⠀⠈⣿⡀⠀⠀⠀⠀");
            Console.WriteLine("⠀⠀⠀⠀⣾⡟⠛⢳⠀⠀⠀⠀⠀⣉⣀⠀⠀⠀⠀⣰⢛⠙⣶⠀⢹⣇⠀⠀⠀⠀");
            Console.WriteLine("⠀⠀⠀⠀⢿⡗⠛⠋⠀⠀⠀⠀⣾⠋⠀⢱⠀⠀⠀⠘⠲⠗⠋⠀⠈⣿⠀⠀⠀⠀");
            Console.WriteLine("⠀⠀⠀⠀⠘⢷⡀⠀⠀⠀⠀⠀⠈⠓⠒⠋⠀⠀⠀⠀⠀⠀⠀⠀⠀⢻⡇⠀⠀⠀");
            Console.WriteLine("⠀⠀⠀⠀⠀⠈⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣧⠀⠀⠀");
            Console.WriteLine("⠀⠀⠀⠀⠀⠈⠉⠉⠉⠉⠉⠉⠉⠉⠉⠉⠉⠉⠉⠉⠉⠉⠉⠉⠉⠉⠁⠀⠀⠀");
            Console.WriteLine();
            Console.WriteLine("========= Random Pokemon Facts ========\n");

            using (HttpClient client = new HttpClient())
            {
                Random random = new Random();

                Console.WriteLine("Fetching 10 random Pokemon from PokeAPI...\n");

                for (int i = 1; i <= 10; i++)
                {
                    int randomId = random.Next(1, 151);
                    string url = $"https://pokeapi.co/api/v2/pokemon/{randomId}";
                    PokemonDetails details = await LoadPokemonDetailsAsync(client, url);
                    PrintPokemonSummary(details, i);
                }
            }
        }

        public static async Task<PokemonDetails> LoadPokemonDetailsAsync(HttpClient client, string url)
        {
            string json = await client.GetStringAsync(url);

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            var details = JsonSerializer.Deserialize<PokemonDetails>(json, options);

            return details;
        }

        static void PrintPokemonSummary(PokemonDetails pokemon, int number)
        {
            Console.WriteLine($"#{number} - {pokemon.Name.ToUpper()}");
            Console.WriteLine($"  Height: {pokemon.Height} decimeters");
            Console.WriteLine($"  Weight: {pokemon.Weight} hectograms");

            string typeNames = "";
            for (int i = 0; i < pokemon.Types.Count; i++)
            {
                typeNames += pokemon.Types[i].Type.Name;
                if (i < pokemon.Types.Count - 1)
                {
                    typeNames += ", ";
                }
            }
            Console.WriteLine($"  Types: {typeNames}");
            Console.WriteLine();
        }
    }

    public class PokemonDetails
    {
        public string Name { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public List<TypeSlot> Types { get; set; }
    }

    public class TypeSlot
    {
        public int Slot { get; set; }
        public TypeInfo Type { get; set; }
    }

    public class TypeInfo
    {
        public string Name { get; set; }
    }
}