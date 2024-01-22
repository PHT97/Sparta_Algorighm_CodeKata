namespace _18._문자열을_정수로_바꾸기
{
    internal class Program
    {
        public static int solution(string s)
        {
            int answer = 0;
            answer = int.Parse(s);
            return answer;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(solution("1234"));
        }
    }
}
