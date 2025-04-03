namespace StringLibrary;

public class Utilities
{
    public static bool StartsWithUpper(string? s)
    {
        if (string.IsNullOrWhiteSpace(s))
            return false;

        char ch = s[0];
        return char.IsUpper(ch);
    }
}
