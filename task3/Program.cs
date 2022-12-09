string s = ("1 2 3 4 5 6 7");
string[] nums = s.Split(' ');
foreach (var num in nums)
{
    Console.WriteLine($"Значение: {num}");
}
int[] n = nums.Select(Int32.Parse).ToArray();
foreach (var i in n)
{
    Console.Write($"{i} ");
}