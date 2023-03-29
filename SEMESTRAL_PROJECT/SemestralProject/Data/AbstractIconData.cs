using SemestralProject.Visual;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Web.AtomPub;
using Icon = SemestralProject.Visual.Icon;

namespace SemestralProject.Data
{
    /// <summary>
    /// Class which abstracts all data items which has icon
    /// </summary>
    internal abstract class AbstractIconData: AbstractData
    {
        /// <summary>
        /// Icon of data
        /// </summary>
        public Icon? Icon{ get; protected set; }

        /// <summary>
        /// Creates new data with icon
        /// </summary>
        /// <param name="id">Identifier of data</param>
        /// <param name="name">Name of data</param>
        /// <param name="description">Description of data</param>
        /// <param name="icon">Icon of data</param>
        public AbstractIconData(string id, string name, string description, Icon icon) : this(id, name, description, icon, DateTime.Now, DateTime.Now) { }

        /// <summary>
        /// Creates new data with icon
        /// </summary>
        /// <param name="id">Identifier of data</param>
        /// <param name="name">Name of data</param>
        /// <param name="description">Description of data</param>
        /// <param name="icon">Icon of data</param>
        /// <param name="created">Date and time of creation of data</param>
        /// <param name="updated">Date and time of last update of data</param>
        public AbstractIconData(string id, string name, string description, Icon icon, DateTime created, DateTime updated): base(id, name, description, created, updated)
        {
            this.Icon = icon;
        }

        /// <summary>
        /// Edits data with icon
        /// </summary>
        /// <param name="name">New name of data</param>
        /// <param name="description">New description of data</param>
        /// <param name="icon">New icon of data</param>
        public virtual void Edit(string name, string description, Icon icon)
        {
            base.Edit(name, description);
            this.Icon = icon;
        }
    }
}
