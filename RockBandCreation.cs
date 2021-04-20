using System;
using System.Collections.Generic;
using System.Text;

namespace RockBand
{
    public class RockBandCreation
    {
        
        private List<string> names = new List<string>() {"Bodrum Salvador", "Hilary Ouse", "Indigo Violet", "Hans Down", "Shequondolisa Bivouac", "Ingredia Nutrisha", "Fig Nelson", "Benjamin Evalent", "Gustav Purpleson", "Elon Gated" };
        private List<string> nouns = new List<string>() {"Compass", "Banana", "Geek", "Sausage", "Fairy", "Melons", "Buffalo", "Programmers", "Mustangs", "Joysticks" };
        private List<string> adjectives = new List<string>() {"Stunning", "Delightful", "Wild", "Useless", "Great", "Drunken", "Crazy", "Quiet", "Bright", "Scrumptious"};
        private List<string> musicians = new List<string>() {"vocalist", "drummer", "bass guitarist", "electric guitarist"};

        public RockBandCreation() { }

        private int GetRandomIndex(List<string> list)
        {
            var random = new Random();
            int index = random.Next(list.Count);
            return index;
        }


        public string GenerateAdjective(int index)
        {
            return adjectives[index];
        }
        public string GenerateNouns(int index)
        {
            return nouns[index];
        }

        public string GeneratePerformerName()
        {
            int index = GetRandomIndex(names);
            string name = names[index];
            return name;
        }

        public string[] AssignNameToTheBandMember()
        {
            string[] arrayOfNames = new string[4];
            int index = 0;
            List<string> usedNames = new List<string>();
            string generatedPerformersName;
            bool isUsed;
            foreach (string element in musicians)
            {
                generatedPerformersName = GeneratePerformerName();
                isUsed = CheckIfNameIsUsed(usedNames, generatedPerformersName);
                if (isUsed)
                {
                    generatedPerformersName = GeneratePerformerName();
                    isUsed = CheckIfNameIsUsed(usedNames, generatedPerformersName);
                }
                else if (isUsed == false)
                {
                    usedNames.Add(generatedPerformersName);
                    
                    arrayOfNames[index] = generatedPerformersName;
                    index++;
                }
            }
            return arrayOfNames;
        }
        private bool CheckIfNameIsUsed(List<string> list, string item)
        {
            bool isUsed = list.Contains(item);
            return isUsed;
        }

        public void Preview(List<string> list)
        {
            int number = 1;
            foreach (string element in list)
            {
                Console.WriteLine(number + ". " + list[number - 1]);
                number++;
            }
        }

        public string ChooseElementFromList(List<string> list, int index)
        {
            string element = list[index];
            return element;
        }

        public string GenerateBandNameByUser(string adjective, string noun)
        {
            string bandName = adjective + " " + noun;
            return bandName;
        }

        public string GenerateBandNameByRandom()
        {
            int index1 = GetRandomIndex(adjectives);
            string adjective = GenerateAdjective(index1);
            int index2 = GetRandomIndex(nouns);
            string noun = GenerateAdjective(index2);
            string bandName = GenerateBandNameByUser(adjective, noun);
            return bandName;
        }
        public void AdjectivesPreview()
        {
            int count = 1;
            foreach (string element in adjectives)
            {
                Console.WriteLine($"Element {count}: {element}");
                count++;
            }
        }
        public void NounsPreview()
        {
            int count = 1;
            foreach (string element in nouns)
            {
                Console.WriteLine($"Element {count}: {element}");
                count++;
            }
        }
        public int CountAdjectivesInDatabase()
        {
            return adjectives.Count;
        }
        public int CountNounsInDatabase()
        {
            return nouns.Count;
        }
    }
}
