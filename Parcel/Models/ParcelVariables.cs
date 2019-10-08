
namespace Parcel.Models
{
    public class ParcelVariables
    {
        private float Height { get; set; }
        private float Width { get; set; }
        private float Length { get; set; }
        private float Weight { get; set; }

        public ParcelVariables(float height, float width, float length, float weight)
        {
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