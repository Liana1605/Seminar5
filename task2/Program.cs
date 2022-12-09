string[] names = {"Bob", "Ann", "Liz", "Mike"};
int[] ages = {10, 17, 15, 21};
string s10 = string.Join(" ", names);
Console.WriteLine(s10);
string s11 = string.Join("---", ages);
Console.WriteLine(s11);