using System;
using System.Text.RegularExpressions;

namespace rcUtils
{
    public static class Validations
    {
        public static string ValidChars_Generic { get { return "Letras sem acentua��o; N�meros; Especiais _?!@#$%&*.=+-"; } }
        public static string ValidChars_KeyLogin { get { return "Letras sem acentua��o; N�meros; Especiais _-"; } }
        public static string ValidChars_Name { get { return "Letras; N�meros; Espa�o; Especiais _-"; } }
        public static string ValidChars_Password { get { return "Letras sem acentua��o; N�meros; Especiais _?!@#$%&*.=+-"; } }
        public static string ValidChars_Email { get { return "Letras sem acentua��o; N�meros; Especiais _-@."; } }

        public static bool ValidateChars_Generic(string text)
        {
            try {
                Regex regex = new Regex(@"^[A-Z0-9_?!@#$%&*.=+-]+$",
                    RegexOptions.IgnoreCase,
                    TimeSpan.FromMilliseconds(200));
                return regex.IsMatch(text);
            } catch (RegexMatchTimeoutException) {
                return false;
            }
        }

        public static bool ValidateChars_KeyLogin(string text)
        {
            try {
                Regex regex = new Regex(@"^[A-Z0-9_-]+$",
                    RegexOptions.IgnoreCase,
                    TimeSpan.FromMilliseconds(200));
                return regex.IsMatch(text);
            } catch (RegexMatchTimeoutException) {
                return false;
            }
        }

        public static bool ValidateChars_Name(string text)
        {
            try {
                Regex regex = new Regex(@"^[A-Z0-9�-�_\s-]+$",
                    RegexOptions.IgnoreCase,
                    TimeSpan.FromMilliseconds(200));
                return regex.IsMatch(text);
            } catch (RegexMatchTimeoutException) {
                return false;
            }
        }

        public static bool ValidateChars_Password(string text)
        {
            try {
                Regex regex = new Regex(@"^[A-Z0-9_?!@#$%&*.=+-]+$",
                    RegexOptions.IgnoreCase,
                    TimeSpan.FromMilliseconds(200));
                return regex.IsMatch(text);
            } catch (RegexMatchTimeoutException) {
                return false;
            }
        }

        public static bool ValidateChars_Email(string text)
        {
            try {
                Regex regex = new Regex(@"^[A-Z0-9_@.-]+$",
                    RegexOptions.IgnoreCase,
                    TimeSpan.FromMilliseconds(200));
                return regex.IsMatch(text);
            } catch (RegexMatchTimeoutException) {
                return false;
            }
        }
    }
}
