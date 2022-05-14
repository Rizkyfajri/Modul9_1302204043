namespace MatematikaLibraries
{
    public class Class1
    {
        static int FPB(int input1, int input2)
        {
            while (input2 != 0)
            {
                int temp = input2;
                input2 = input1 % input2;
                input1 = temp;
            }
            return input1;
        }
        static int KPK(int input1, int input2)
        {
            return input1 / FPB(input1, input2) * input2; ;
        }
        static void Turunan(int[] persamaan)
        {

        }
        static void Integral(int[] persamaan)
        {

        }
    }
}