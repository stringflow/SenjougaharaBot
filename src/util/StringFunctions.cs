public static class StringFunctions {

    public static string Until(this string str, string chars) {
        return str.Substring(0, str.IndexOf(chars));
    }

    public static string After(this string str, string chars) {
        return str.Substring(str.IndexOf(chars) + chars.Length);
    }
}