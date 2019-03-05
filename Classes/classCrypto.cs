using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PTFLauncher
{
    class Crypto
    {
        public class Atom128
        {
            public string Name { get { return "Atom128"; } }

            public static string Decode(string input)
            {
                string key = "/128GhIoPQROSTeUbADfgHijKLM+n0pFWXY456xyzB7=39VaqrstJklmNuZvwcdEC";
                StringBuilder result = new StringBuilder();

                int[] indexes = new int[4];
                int[] chars = new int[3];
                int i = 0;

                do
                {
                    indexes[0] = key.IndexOf(input[i++]);
                    indexes[1] = key.IndexOf(input[i++]);
                    indexes[2] = key.IndexOf(input[i++]);
                    indexes[3] = key.IndexOf(input[i++]);

                    chars[0] = (indexes[0] << 2) | (indexes[1] >> 4);
                    chars[1] = (indexes[1] & 15) << 4 | (indexes[2] >> 2);
                    chars[2] = (indexes[2] & 3) << 6 | indexes[3];

                    result.Append((char)chars[0]);

                    if (indexes[2] != 64)
                        result.Append((char)chars[1]);

                    if (indexes[3] != 64)
                        result.Append((char)chars[2]);
                }
                while (i < input.Length);

                return result.ToString();
            }

            public static string Encode(string input)
            {
                string key = "/128GhIoPQROSTeUbADfgHijKLM+n0pFWXY456xyzB7=39VaqrstJklmNuZvwcdEC";
                StringBuilder result = new StringBuilder();

                int i = 0;
                int[] indexes = new int[4];
                int[] chars = new int[3];

                do
                {
                    chars[0] = i + 1 > input.Length ? 0 : (int)input[i++];
                    chars[1] = i + 2 > input.Length ? 0 : (int)input[i++];
                    chars[2] = i + 3 > input.Length ? 0 : (int)input[i++];

                    indexes[0] = chars[0] >> 2;
                    indexes[1] = ((chars[0] & 3) << 4) | (chars[1] >> 4);
                    indexes[2] = ((chars[1] & 15) << 2) | (chars[2] >> 6);
                    indexes[3] = chars[2] & 63;

                    if ((char)chars[1] == 0)
                    {
                        indexes[2] = 64;
                        indexes[3] = 64;
                    }
                    else if ((char)chars[2] == 0)
                    {
                        indexes[3] = 64;
                    }

                    foreach (int index in indexes)
                    {
                        result.Append(key[index]);
                    }
                }
                while (i < input.Length);

                return result.ToString();
            }
        }
        public class Base64
        {
            public string Name { get { return "Base64"; } }

            public static string Decode(string input)
            {
                return WebUtility.UrlDecode(Encoding.UTF8.GetString(Convert.FromBase64String(input)));
            }

            public static string Encode(string input)
            {
                return Convert.ToBase64String(Encoding.UTF8.GetBytes(WebUtility.UrlEncode(input)));
            }
        }
        public class Lambda
        {
            static Func<string, int, string>
            x = (f, n) => new string(f.Select<char, char>(c => (char)(c ^ n)).ToArray());

            public static string Encode(string input, int salt)
            {
                return x(input, salt);
            }
        }
        public class Reverse
        {
            public string Name { get { return "Reverse"; } }

            public static string Decode(string input)
            {
                return string.Concat(input.Reverse());
            }

            public static string Encode(string input)
            {
                return string.Concat(input.Reverse());
            }
        }
        public class ROT13
        {
            public string Name { get { return "ROT13"; } }

            public static string Decode(string input)
            {
                return Run(input);
            }

            public static string Encode(string input)
            {
                return Run(input);
            }

            private static string Run(string value)
            {
                char[] array = value.ToCharArray();
                for (int i = 0; i < array.Length; i++)
                {
                    int number = (int)array[i];

                    if (number >= 'a' && number <= 'z')
                    {
                        if (number > 'm')
                        {
                            number -= 13;
                        }
                        else
                        {
                            number += 13;
                        }
                    }
                    else if (number >= 'A' && number <= 'Z')
                    {
                        if (number > 'M')
                        {
                            number -= 13;
                        }
                        else
                        {
                            number += 13;
                        }
                    }
                    array[i] = (char)number;
                }
                return new string(array);
            }
        }

    }
    
}
