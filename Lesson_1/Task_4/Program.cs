Console.Write("Enter first string: ");
string str1 = Console.ReadLine();

Console.Write("Enter second string: ");
string str2 = Console.ReadLine();


if (str1.Length > str2.Length)
{
    Console.WriteLine("The first string has more symbols than sting two.\n" +
        $"Result: {str1 + str2}");
}

else if (str1.Length < str2.Length)
{
    string[] subs = str2.Split(str1[0]);
    foreach (var sub in subs)
    {
        Console.WriteLine($"Substring {0 + 1}: {sub}");
    }
}

else
{
    Console.WriteLine("The string are equal, so I return some void");
}