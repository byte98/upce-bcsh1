using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SemestralProject.Utils
{
    /// <summary>
    /// Class which contains some string utility functions
    /// </summary>
    internal static class StringUtils
    {
        /// <summary>
        /// Generates random string
        /// </summary>
        /// <param name="alphabet">Alphabet used to generate string</param>
        /// <param name="length">Desired length of string</param>
        /// <returns>Pseudo-randomly generated string</returns>
        public static string Random(string alphabet, int length)
        {
            StringBuilder reti = new StringBuilder();
            Random random = new Random();
            for (int i = 0; i < length; i++)
            {
                reti.Append(alphabet[random.Next(0, alphabet.Length)]);
            }
            return reti.ToString();
        }

        /// <summary>
        /// Generates random string
        /// </summary>
        /// <param name="alphabet">Alphabet used to generate string</param>
        /// <param name="minLength">Minimal length of string</param>
        /// <param name="maxLength">Maximal length of string</param>
        /// <returns>Pseudo-randomly generated string</returns>
        public static string Random(string alphabet, int minLength, int maxLength)
        {
            Random random = new Random();
            return StringUtils.Random(alphabet, random.Next(minLength, maxLength + 1));
        }
    }
}
