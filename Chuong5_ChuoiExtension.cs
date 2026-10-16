public static class ChuoiExtensions
{
    public static string VietHoaChuCai(this string s)
    {
        if (string.IsNullOrEmpty(s)) return s;
        return char.ToUpper(s[0]) + s[1..];
    }
    public static bool LaEmailHopLe(this string s)
        => s.Contains('@') && s.Contains('.');

}