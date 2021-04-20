using System;
using System.Collections.Generic;
using System.Text;

namespace RockBand
{
    public class Band
    {
        private string bandName;
        private string vocalist;
        private string drummer;
        private string bassGuitarist;
        private string electricGuitarist;

        public string BandName
        {
            get { return bandName; }
            set { bandName = value; }
        }
         public string Vocalist
        {
            get { return vocalist; }
            set { vocalist = value; }
        }
        public string Drummer
        {
            get { return drummer; }
            set { drummer = value; }
        }
        public string BassGuitarist
        {
            get { return bassGuitarist; }
            set { bassGuitarist = value; }
        }
        public string ElectricGuitarist
        {
            get { return electricGuitarist; }
            set { electricGuitarist = value; }
        }

        public Band() { }

        public void BandPreview()
        {
            Console.WriteLine($"Band's name: " + bandName);
            Console.WriteLine($"Band's members: ");
            Console.Write($"vocalist " + vocalist);
            Console.Write($", drummer " + drummer); 
            Console.Write($", bass guitarist " + bassGuitarist); 
            Console.WriteLine($", electric guitarist " + electricGuitarist);
        }
    }
}
