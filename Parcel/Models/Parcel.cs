using System.Collections.Generic;
using System;

namespace Parcel.Models
{
    public class Package
    {
        public string Recipient { get; set; }
        public float Height { get; set; }
        public float Width { get; set; }
        public float Length { get; set; }
        public float Weight { get; set; }
        public int ID { get; }
        public static int idAssigner { get; set;}
        public static List<Package> PackageList = new List<Package> { };


        public Package(string recipient, float height, float width, float length, float weight)
        {
            Recipient = recipient;
            Height = height;
            Width = width;
            Length = length;
            Weight = weight;
            idAssigner++;
            ID = idAssigner;
            PackageList.Add(this);
        }

        public float Volume()
        {
            float volume = Height * Width * Length;
            return volume;
        }

        public float CostToShip()
        {
            float cost = (Volume()*Weight)*(float)0.1 + 5;
            return cost;
        }

        public static void DeletePackage(int id)
        {
            foreach(Package package in PackageList)
            {
                if (package.ID == id)
                {
                    PackageList.Remove(package);
                }
            }
        }
    }
}