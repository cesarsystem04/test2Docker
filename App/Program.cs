namespace DotNet.Docker
{
    class Program
    {
       public static async Task Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
           var counter = 0;
           var max = args.Length != 0 ? Convert.ToInt32(args[0]) : -1;
            while (max == -1 || counter < max)
            {
                Console.WriteLine($"Counter: {++counter}");
                await Task.Delay(TimeSpan.FromMilliseconds(1_000));
            }

        }
    }
}
