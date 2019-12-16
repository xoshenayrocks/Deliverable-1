using System;

namespace Deliverable_1
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("What type of vacation would you like to have; musical, tropical, or adventurous?");
                string vacationType = Console.ReadLine();

                Console.WriteLine("How many people are in your group?");
                int groupSize = int.Parse(Console.ReadLine());

                string destination1 = "New Orleans";
                string destination2 = "a beach vacation in Mexico";
                string destination3 = "white water rafting in the Grand Canyon";
                string suggestion1 = "first class";
                string suggestion2 = "helicopter";
                string suggestion3 = "charter flight";

                if (vacationType == "musical" && groupSize > 0 && groupSize <= 2)
                {
                    string result = $"Since you are a group of {groupSize} and you would like a {vacationType} vacation, you should travel by {suggestion1} to {destination1}!";

                    Console.WriteLine(result);
                }

                else if (vacationType == "musical" && groupSize >= 3 && groupSize <= 5)
                {
                    string result = $"Since you are a group of {groupSize} and you would like a {vacationType} vacation, you should travel by {suggestion2} to {destination1}!";
                    Console.WriteLine(result);
                }
                else if (vacationType == "musical" && groupSize >= 6)
                {
                    string result = $"Since you are a group of {groupSize} and you would like a {vacationType} vacation, you should travel by {suggestion3} to {destination1}!";
                    Console.WriteLine(result);
                }

                if (vacationType == "tropical" && groupSize > 0 && groupSize <= 2)
                {
                    string result = $"Since you are a group of {groupSize} and you would like a {vacationType} vacation, you should travel by {suggestion1} to {destination2}!";
                    Console.WriteLine(result);
                }
                else if (vacationType == "tropical" && groupSize >= 3 && groupSize <= 5)
                {
                    string result = $"Since you are a group of {groupSize} and you would like a {vacationType} vacation, you should travel by {suggestion2} to {destination2}!";
                    Console.WriteLine(result);
                }
                else if (vacationType == "tropical" && groupSize >= 6)
                {
                    string result = $"Since you are a group of {groupSize} and you would like a {vacationType} vacation, you should travel by {suggestion3} to {destination2}!";
                    Console.WriteLine(result);
                }

                if (vacationType == "adventurous" && groupSize > 0 && groupSize <= 2)
                {
                    string result = $"Since you are a group of {groupSize} and you would like an {vacationType} vacation, you should travel by {suggestion1} to {destination3}!";
                    Console.WriteLine(result);
                }
                else if (vacationType == "adventurous" && groupSize >= 3 && groupSize <= 5)
                {
                    string result = $"Since you are a group of {groupSize} and you would like an {vacationType} vacation, you should travel by {suggestion2} to {destination3}!";
                    Console.WriteLine(result);
                }
                else if (vacationType == "adventurous" && groupSize >= 6)
                {
                    string result = $"Since you are a group of {groupSize} and you would like an {vacationType} vacation, you should travel by {suggestion3} to {destination3}!";
                    Console.WriteLine(result);
                }
            }
        }
    } 
