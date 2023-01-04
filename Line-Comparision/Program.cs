namespace Line_Comparision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation");
            Console.WriteLine("Choose Option\n 1.Length Of A Line\t 2.Equality of two lines\t 3.CompareLength");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    LengthCalculation.CalculateLength();
                    break;
                case 2:
                    EqulitiyOfLines.Equality();
                    break;
                case 3:
                    CompareLengthOFTwoLines.CompareLength();
                    break;
                default:
                    Console.WriteLine("Entered Wrong Choice");
                    break;
            }
        }
    }
}