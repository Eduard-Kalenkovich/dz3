static bool IsPalindrome(string s)
{
    for (int i = 0; i < s.Length / 2; ++i)
        if (s[i] != s[s.Length - 1 - i]) 
        return false;
    return true;
}
Console.WriteLine("Введите данные");
if (IsPalindrome(Console.ReadLine()))
Console.WriteLine("Полиндром");
else
Console.WriteLine("Не полиндром");