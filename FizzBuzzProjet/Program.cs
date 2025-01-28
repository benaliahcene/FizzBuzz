namespace FizzBuzzProjet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rules = new List<IFizzBuzzRule>
            {
                new FizzBuzzRule(),
                new FizzRule(),
                new BuzzRule(), //
                new DefaultRule()
            };

            var processor = new FizzBuzzProcessor(rules);

            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(processor.Process(i));
            }
        }
    }
}