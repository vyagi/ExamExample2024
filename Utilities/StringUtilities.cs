namespace Utilities
{
    public static class StringUtilities
    {
        public static int ToWords(string input) => input.Split(" ").Length;

        public static string ToSentence(string input) => 
            input[0].ToString().ToUpper() + input[1..].ToLower();

        public static string ToCamelCase(this string input)
        {
            var split = input.Split();

            split[0] = split[0].ToLower();
            for (var i = 1; i < split.Length; i++)
                split[i] = ToSentence(split[i]);

            return string.Join("", split);
        }
    }
}
