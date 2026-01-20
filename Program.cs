namespace SechenieObedinenieRazlika
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedi purvo mnojestvo: ");
            var set1 = Console.ReadLine().Split(' ').Select(int.Parse).ToHashSet() ?? new HashSet<int>();
            Console.WriteLine("Vuvedi vtoro mnojestvo: ");
            var set2 = Console.ReadLine().Split(' ').Select(int.Parse).ToHashSet() ?? new HashSet<int>();
            var intersection = set1.Intersect(set2).ToHashSet();
            var union = set1.Union(set2).ToHashSet();
            var difference = set1.Except(set2).ToHashSet();
            Console.WriteLine("Sechenie: " + string.Join(" ", intersection));
            Console.WriteLine("Obedinenie: " + string.Join(" ", union));
            Console.WriteLine("Razlika: " + string.Join(" ", difference));
        }
    }
}
