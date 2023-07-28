//To find the volume (centimeters cubed) of a cuboid you use the formula:
//volume = Length * Width * Height
//But someone forgot to use proper record keeping, so we only have the volume, and the length of a single side!

namespace Find_out_whether_the_shape_is_a_cube
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the volume of the cuboid: ");
            double volume = double.Parse(Console.ReadLine());

            Console.Write("Enter the length of a single side of the cuboid: ");
            double side = double.Parse(Console.ReadLine());

            CubeChecker cubeChecker = new CubeChecker();
            Console.WriteLine($"Is it a cube? {cubeChecker.IsCube(volume, side)}");
        }
    }
    public class CubeChecker
    {
        public bool IsCube(double volume, double side)
        {
            if (volume <= 0 || side <= 0) { return false; }
            //O tamanho dos outros lado é igual à raiz cúbica do volume.
            return side == Math.Pow(volume, 1.0 / 3.0) ? true : false;
        }
    }
}