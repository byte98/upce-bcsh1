using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemestralProject.Data
{
    /// <summary>
    /// Class abstracting all data items
    /// </summary>
    internal abstract class AbstractData
    {
        /// <summary>
        /// Flag, whether during searching description will be also checked (<c>TRUE</c>) or not (<c>FALSE</c>)
        /// </summary>
        private const bool CheckDescription = true;

        /// <summary>
        /// Identifier of data
        /// </summary>
        public string Id { get; init; }

        /// <summary>
        /// Name of data
        /// </summary>
        public string Name { get; protected set; }

        /// <summary>
        /// Description of data
        /// </summary>
        public string Description { get; protected set; }

        /// <summary>
        /// Date and time of creation of data
        /// </summary>
        public DateTime Created { get; init; }

        /// <summary>
        /// Date and time of last update of data
        /// </summary>
        public DateTime Updated { get; protected set;}

        /// <summary>
        /// Creates new data item
        /// </summary>
        /// <param name="id">Identifier of data</param>
        /// <param name="name">Name of data</param>
        /// <param name="description">Descripiton of data</param>
        public AbstractData(string id, string name, string description): this(id, name, description, DateTime.Now, DateTime.Now) { }

        /// <summary>
        /// Creates new data item
        /// </summary>
        /// <param name="id">Identifier of data</param>
        /// <param name="name">Name of data</param>
        /// <param name="description">Descripiton of data</param>
        /// <param name="created">Date and time of creation of data</param>
        /// <param name="updated">Date and time of last update of data</param>
        public AbstractData(string id, string name, string description, DateTime created, DateTime updated)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Created = created;
            this.Updated = updated;
        }

        /// <summary>
        /// Edits data
        /// </summary>
        /// <param name="name">New name of data</param>
        /// <param name="description">New description of data</param>
        public virtual void Edit(string name, string description)
        {
            this.Name = name;
            this.Description = description;
            this.Updated = DateTime.Now;
        }

        /// <summary>
        /// Checks, whether data matches searched phrase
        /// </summary>
        /// <param name="phrase">Searched phrase</param>
        /// <returns><c>TRUE</c>, if data matches searched phrase, <c>FALSE</c> otherwise</returns>
        public virtual bool Matches(string phrase)
        {
            bool reti = false;
            Func<string, string> transformString = new Func<string, string>((string input) =>
            {
                StringBuilder reti = new StringBuilder();
                input = input.Trim().ToLower();
                foreach(char c in input)
                {
                    if (char.IsPunctuation(c) == false && char.IsWhiteSpace(c) == false)
                    {
                        reti.Append(c);
                    }
                }
                return reti.ToString();
            });
            if (transformString(this.Name).Contains(transformString(phrase)))
            {
                reti = true;
            }
            else if (AbstractData.CheckDescription == true)
            {
                foreach(string word in this.Description.Split(" "))
                {
                    if (transformString(word).Contains(transformString(phrase)))
                    {
                        reti = true;
                        break;
                    }
                }
            }
            return reti;
        }
    }
}
