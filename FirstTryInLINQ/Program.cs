int[] Numbers = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

var query =
    from num in Numbers
    where num > 5
    select num;

foreach (int n in query)
{
    Console.WriteLine(n);
}