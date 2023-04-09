using SemestralProject.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemestralProject.Controllers
{
    /// <summary>
    /// Class which abstracts all common properties of controller
    /// </summary>
    abstract internal class AbstractController
    {
        /// <summary>
        /// Minimal length of all identifiers in system
        /// </summary>
        protected const uint IdMinLength = 8;

        /// <summary>
        /// Maximal length of all identifiers in system
        /// </summary>
        protected const uint IdMaxLength = 16;

        /// <summary>
        /// String containing allowed characters for generating identifiers
        /// </summary>
        protected const string IdAlphabet = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ*";

        /// <summary>
        /// Wrapper of all system resources
        /// </summary>
        protected Context context;

        /// <summary>
        /// Creates new controller
        /// </summary>
        /// <param name="context">Wrapper of all system resources</param>
        public AbstractController(Context context)
        {
            this.context = context;
        }

        /// <summary>
        /// Generates identifier
        /// </summary>
        /// <param name="prefix">Prefix used in identifier</param>
        /// <returns>Pseudo-randomly generated string</returns>
        protected string GenerateIdentifier(string? prefix)
        {
            string reti = prefix ?? string.Empty;
            reti += StringUtils.Random(AbstractController.IdAlphabet, AbstractController.IdMinLength, AbstractController.IdMaxLength);
            return reti;
        }
    }
}
