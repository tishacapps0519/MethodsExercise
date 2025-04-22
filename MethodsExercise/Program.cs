namespace MethodsExercise
{
    public class Program
    {
        

        public static int Add(int numOne, int numTwo)
        {
            return numOne + numTwo;
        }

        public static int Subtract(int numOne, int numTwo)
        {
            return numOne - numTwo;
        }

        public static int Multiply(int numOne, int NumTwo)
        {
            return numOne * NumTwo;
        }

        public static int Divide(int numOne, int numTwo)
        {
            return numOne / numTwo;
        }
        static void Main(string[] args)
        {
           Console.WriteLine(Add(numOne:2, numTwo:2));
           //int addedNums = Add(numOne: 2, numTwo: 2);
           //Console.WriteLine(addedNums);
           //Console.WriteLine(Subtract(numOne:2, numTwo:2));
           //Console.WriteLine(Multiply(numOne:2, NumTwo:2));
           Console.WriteLine(Divide(numOne:2, numTwo:2));

        }
    }
}
