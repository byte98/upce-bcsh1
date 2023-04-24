using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SemestralProject.Utils
{
    /// <summary>
    /// Class which holds utility functions to work with files
    /// </summary>
    internal static class FileUtils
    {
        /// <summary>
        /// Generates checksum of file
        /// </summary>
        /// <returns>String representation of checksum of file</returns>
        public static string GenerateChecksum(string path)
        {
            string reti = string.Empty;
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(path))
                {
                    var hash = md5.ComputeHash(stream);
                    reti = BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                }
            }
            return reti;
        }
    }
}
