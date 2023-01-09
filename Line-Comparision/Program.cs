namespace Line_Comparision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation");
            Console.WriteLine("Choose Option\n 1.Length Of A Line\t 2.Equality of two lines\t 3.CompareLength\n4.using oops concept");
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
                case 4:
                    UsingOOPs obj = new UsingOOPs();
                    obj.SetLength1(2, 4, 6, 8);
                    obj.GetLength1();
                    obj.SetLength2(2, 4, 6, 8);
                    obj.GetLength2();
                    obj.display1();
                    obj.display2();
                    break;
            }
        }
    }
}