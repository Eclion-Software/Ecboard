using System.Text;
using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Ecboard.Helpers
{
    public static class EcStringHelper
    {
        private static Random random = new Random();

        public static string NormalizeString(string input)
        {
            string normalized = input
                .Normalize(NormalizationForm.FormD);

            StringBuilder sb = new StringBuilder();
            foreach (char c in normalized)
            {
                UnicodeCategory uc = CharUnicodeInfo.GetUnicodeCategory(c);
                if (uc != UnicodeCategory.NonSpacingMark)
                {
                    sb.Append(c);
                }
            }

            string cleaned = Regex.Replace(sb.ToString(), @"[^a-zA-Z0-9\s]", "")
                .Replace(" ", "-")
                .ToLowerInvariant();

            return cleaned;
        }

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            StringBuilder result = new StringBuilder(length);

            for (int i = 0; i < length; i++)
            {
                result.Append(chars[random.Next(chars.Length)]);
            }

            return result.ToString();
        }
    }
}
