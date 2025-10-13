using System;

namespace Homework
{
    public class GetRandomRating
    {
        private int Rating;
        private string Comment;

        public GetRandomRating(int rating, string comment)
        {
            Rating = rating;
            Comment = comment;
        }

        public void GetRating(Chovek person)
        {
            Random random = new Random();
            Rating = random.Next(1, 6);
            if (Rating == 1)
            {
                Comment = "Very Bad";
            }
            else if (Rating == 2)
            {
                Comment = "Bad";
            }
            else if (Rating == 3)
            {
                Comment = "Average";
            }
            else if (Rating == 4)
            {
                Comment = "Good";
            }
            else if (Rating == 5)
            {
                Comment = "Excellent";
            }
            person.GetRating();
            Console.WriteLine($"Rating: {Rating}, Comment: {Comment}");

        }
        

    }
    public class Chovek
    {
        private string Name;
        private int Age;

        public Chovek(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void GetRating()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Chovek person = new Chovek("Sasho", 25);
            GetRandomRating rating = new GetRandomRating(0, "");
            rating.GetRating(person);
            
        }
    }
}