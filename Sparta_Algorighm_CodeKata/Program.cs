namespace Sparta_Algorighm_CodeKata
{
    internal class Program
    {
        public static int soulution(int num1, int num2)
        {
            int answer = 0;
            answer = num1 - num2;
            return answer;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(soulution(2, 3));
        }
    }
}
