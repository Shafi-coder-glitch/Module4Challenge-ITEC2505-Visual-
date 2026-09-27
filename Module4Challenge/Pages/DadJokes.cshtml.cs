using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Module4Challenge.Pages
{
    public class DadJokesModel : PageModel
    {
        // This array stores twelve clean, G-rated dad jokes.
        public string[] DadJokes =
        {
            "Why don't eggs tell jokes? They might crack each other up.",
            "What do you call a fake noodle? An impasta.",
            "Why did the bicycle fall over? Because it was two-tired.",
            "What do you call cheese that isn't yours? Nacho cheese.",
            "Why can't a nose be 12 inches long? Because then it would be a foot.",
            "What did the ocean say to the beach? Nothing, it just waved.",
            "Why did the math book look sad? Because it had too many problems.",
            "What kind of tree fits in your hand? A palm tree.",
            "Why did the scarecrow win an award? Because he was outstanding in his field.",
            "What do you call a sleeping bull? A bulldozer.",
            "Why did the golfer bring two pairs of pants? In case he got a hole in one.",
            "What do you call a bear with no teeth? A gummy bear."
        };

        // This property stores the jokes that will currently be displayed.
        public List<string> CurrentJokes { get; set; } = new List<string>();

        // This property stores how many jokes should be displayed at once.
        public int NumberOfJokes { get; set; } = 2;

        public void OnGet()
        {
            // Select two random jokes when the page first loads.
            SelectRandomJokes();
        }

        public void OnPost()
        {
            // Select two new random jokes when the user clicks More Jokes.
            SelectRandomJokes();
        }

        private void SelectRandomJokes()
        {
            // Create a Random object to generate random numbers.
            Random rnd = new Random();

            // Keep selecting jokes until we have the required number.
            while (CurrentJokes.Count < NumberOfJokes)
            {
                int index = rnd.Next(DadJokes.Length);
                string joke = DadJokes[index];

                // Only add the joke if it has not already been selected.
                if (!CurrentJokes.Contains(joke))
                {
                    CurrentJokes.Add(joke);
                }
            }
        }
    }
}