using System;
using System.Text;

namespace WebCore.Extension
{
    public static class StringExtentions
    {
        public static string MD5(string s)
        {
            using var provider = System.Security.Cryptography.MD5.Create();
            var builder = new StringBuilder();
            var bs = provider.ComputeHash(Encoding.UTF8.GetBytes(s));
            for (var i = 0; i < bs.Length; i++)
            {
                var b = bs[i];
                builder.Append(b.ToString("x2").ToLower());
            }
            return builder.ToString();
        }
        
        public static string ToTitleCase(this string str)
        {
            var tokens = str.Split(new[] { " ", "-" }, StringSplitOptions.RemoveEmptyEntries);
            for (var i = 0; i < tokens.Length; i++)
            {
                var token = tokens[i];
                tokens[i] = token == token.ToUpper()
                    ? token 
                    : token.Substring(0, 1).ToUpper() + token.Substring(1).ToLower();
            }
            return string.Join(" ", tokens);
        }
        
    }
}