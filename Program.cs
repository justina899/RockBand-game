using System;
using System.Collections.Generic;

namespace RockBand
{
    public class Program
    {
        static void Main(string[] args)
        {
            RockBandCreation OurBandCreation = new RockBandCreation();
            Band OurBand = new Band();
            string adjective;
            string noun;
            string userChoice;
            string[] members = new string[4];
            string answer;
            Console.WriteLine("Hello! This program generates rock band's and it's members' names.");
            do
            {
                Console.WriteLine("Choose generation type: ");
                Console.WriteLine("1 - By choosing adjective and noun from given below ");
                Console.WriteLine("2 - With your own words");
                Console.WriteLine("3 - By random");
                do
                {
                    Console.WriteLine("Enter numbers 1, 2 or 3: ");
                    userChoice = Console.ReadLine();
                } while (userChoice != "1" && userChoice != "2" && userChoice != "3");
                if (userChoice == "1")
                {
                    Console.WriteLine("First lets choose bands name.");
                    Console.WriteLine($"Here are " + OurBandCreation.CountAdjectivesInDatabase() + " adjectives: ");
                    OurBandCreation.AdjectivesPreview();
                    string index1;
                    string index2;
                    do
                    {
                        Console.WriteLine($"Choose number 1 to " + OurBandCreation.CountAdjectivesInDatabase() + ": ");
                        index1 = Console.ReadLine();
                    } while (index1 != "1" && index1 != "2" && index1 != "3" && index1 != "4" && index1 != "5" && index1 != "6" && index1 != "7" && index1 != "8" && index1 != "9" && index1 != "10");
                    Console.WriteLine($"Here are " + OurBandCreation.CountNounsInDatabase() + " nouns: ");
                    OurBandCreation.NounsPreview();
                    do
                    {
                        Console.WriteLine($"Choose number from 1 to " + OurBandCreation.CountNounsInDatabase());
                        index2 = Console.ReadLine();
                    } while (index2 != "1" && index2 != "2" && index2 != "3" && index2 != "4" && index2 != "5" && index2 != "6" && index2 != "7" && index2 != "8" && index2 != "9" && index2 != "10");
                    adjective = OurBandCreation.GenerateAdjective(Int32.Parse(index1) - 1);
                    noun = OurBandCreation.GenerateNouns(Int32.Parse(index2) - 1);
                    OurBand.BandName = OurBandCreation.GenerateBandNameByUser(adjective, noun);

                }
                else if (userChoice == "2")
                {
                    Console.WriteLine("Please enter adjective: ");
                    adjective = Console.ReadLine();
                    Console.WriteLine("Please enter noun: ");
                    noun = Console.ReadLine();
                    OurBand.BandName = OurBandCreation.GenerateBandNameByUser(adjective, noun);
                }
                else if (userChoice == "3")
                {
                    OurBand.BandName = OurBandCreation.GenerateBandNameByRandom();
                }
                members = OurBandCreation.AssignNameToTheBandMember();
                OurBand.Vocalist = members[0];
                OurBand.Drummer = members[1];
                OurBand.BassGuitarist = members[2];
                OurBand.ElectricGuitarist = members[3];
                OurBand.BandPreview();
                Console.WriteLine("Would you like to try one more time? (y/n): ");
                answer = Console.ReadLine();
            } while (answer == "y");
        }
        
        
    }
}
