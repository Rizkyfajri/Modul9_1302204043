namespace MatematikaLibraries
{
    public class Class1
    {
       public static int FPB(int input1, int input2)
        {
            while (input2 != 0)
            {
                int temp = input2;
                input2 = input1 % input2;
                input1 = temp;
            }
            return input1;
        }
        public static int KPK(int input1, int input2)
        {
            return input1 / FPB(input1, input2) * input2; ;
        }
        public static void Turunan(int[] persamaan)
        {

        }
        public static void Integral(int[] persamaan)
        {

        }
    }
}