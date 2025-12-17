// class with properties and methods
class GiftSuggestion
{
    public string FriendName { get; set; }
    public string InterestKey { get; set; }
    public string SuggestedGift { get; private set; }

    private static readonly Random random = new Random();

    public GiftSuggestion(string friendName, string interestKey)
    {
        FriendName = friendName;
        InterestKey = interestKey;
        SuggestedGift = "a gift card, for when you panic";
    }

    public void PickGift()
    {
        if (InterestKey == "marvel")
        {
            string[] movies =
            {
                "a used Blu-ray of Avengers: Age of Ultron (2015)",
                "a gently scratched copy of Captain America: Civil War (2016)",
                "the DVD of Thor: Ragnarok (2017) with the pizza grease smudge on the cover",
                "a used Black Panther (2018) disc with a slightly cracked case that won't close right",
                "a very dramatic Avengers: Endgame (2019) Blu-ray. Did you already give this to them last year?",
                "a Spider-Man: No Way Home (2021) disc that may or may not be in the right box",
                "a Guardians of the Galaxy Vol. 3 (2023) DVD you found in the discount bin"
            };

            int index = random.Next(movies.Length);
            SuggestedGift = movies[index];
        }
        else if (InterestKey == "coding")
        {
            SuggestedGift = "a big bottle of ibuprofen and a half-used bag of coffee";
        }
        else if (InterestKey == "gamer")
        {
            SuggestedGift = "a tiny Raspberry Pi running RetroPie and way too many retro game. We won't talk about where you downloaded the ROMs from";
        }
        else if (InterestKey == "books")
        {
            SuggestedGift = "yet another worn paperback set of The Lord of the Rings";
        }
        else if (InterestKey == "animals")
        {
            string[] animals =
            {
                "a donation to the shelter in the name of the loudest dog there",
                "a visit pass to meet the grumpiest shelter cat",
                "a small sponsorship for the rabbit that keeps chewing the sign",
                "a photo of the shelter lizard that refuses to pose for photos"
            };

            int index = random.Next(animals.Length);
            SuggestedGift = animals[index];
        }
        else
        {
            SuggestedGift = "a safe mystery board game you can both pretend to understand";
        }
    }

    public string GetSummary()
    {
        return $"For {FriendName}, you could bring {SuggestedGift}";
    }
}
