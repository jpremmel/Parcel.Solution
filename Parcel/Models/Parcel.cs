using System.Collections.Generic;

namespace Parcel.Models
{
    public class Package
    {
        public string Recipient { get; set; }
        public float Height { get; set; }
        public float Width { get; set; }
        public float Length { get; set; }
        public float Weight { get; set; }
        public static List<Package> PackageList = new List<Package> { };


        public Package(string recipient, float height, float width, float length, float weight)
        {
            Recipient = recipient;
            Height = height;
            Width = width;
            Length = length;
            Weight = weight;
            PackageList.Add(this);
        }

        public float Volume()
        {
            float volume = Height * Width * Length;
            return volume;
        }

        public float CostToShip()
        {
            return (float)2.00;
        }

    }
}