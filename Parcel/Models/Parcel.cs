
namespace Parcel.Models
{
    public class Package
    {
        public string Recipient { get; set; }
        public float Height { get; set; }
        public float Width { get; set; }
        public float Length { get; set; }
        public float Weight { get; set; }

        public Package(string recipient, float height, float width, float length, float weight)
        {
            Recipient = recipient;
            Height = height;
            Width = width;
            Length = length;
            Weight = weight;
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