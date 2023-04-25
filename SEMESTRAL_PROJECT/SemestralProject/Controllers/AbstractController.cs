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
    abstract internal class AbstractController<T>
    {
        /// <summary>
        /// Minimal length of all identifiers in system
        /// </summary>
        public const uint IdMinLength = 8;

        /// <summary>
        /// Maximal length of all identifiers in system
        /// </summary>
        public const uint IdMaxLength = 16;

        /// <summary>
        /// String containing allowed characters for generating identifiers
        /// </summary>
        public const string IdAlphabet = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ*";

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
            reti += StringUtils.Random(AbstractController<T>.IdAlphabet, AbstractController<T>.IdMinLength, AbstractController<T>.IdMaxLength);
            return reti;
        }

        /// <summary>
        /// Creates new data item
        /// </summary>
        public abstract void Create();

        /// <summary>
        /// Shows information about data item
        /// </summary>
        /// <param name="id">Identifier of data item</param>
        public abstract void Info(string id);

        /// <summary>
        /// Edits data item
        /// </summary>
        /// <param name="id">Identifier of data item</param>
        public abstract void Edit(string id);

        /// <summary>
        /// Removes data item
        /// </summary>
        /// <param name="id">Identifier of data item</param>
        public abstract void Remove(string id);

        /// <summary>
        /// Deletes all data items
        /// </summary>
        public abstract void Delete();

        /// <summary>
        /// Searches data
        /// </summary>
        /// <param name="phrase">Phrase which will be searched</param>
        /// <returns>List of items which matches phrase</returns>
        public abstract List<T> Search(string phrase);
    }
}
