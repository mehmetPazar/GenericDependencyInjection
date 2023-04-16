using RestApi.Interfaces;

namespace RestApi
{
    public class Dog : IDog
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public string Bark()
        {
            return "Woof woof!";
        }

        public string Run()
        {
            return "I'm running!";
        }

        public string Fetch()
        {
            return "I'm fetching the ball!";
        }

        public string Eat()
        {
            return "I'm eating my food!";
        }

        public string Sleep()
        {
            return "I'm going to sleep now.";
        }
    }
}