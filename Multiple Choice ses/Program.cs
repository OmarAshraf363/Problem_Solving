namespace MultibleChoice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var paper1 = new Testpaper("Ai", new string[] { "1A", "2B" }, "60");
            Student student = new Student();
            student.Taketest(paper1, new string[] { "1A" });
        }
    }
}
