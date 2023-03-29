using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Icon = SemestralProject.Visual.Icon;

namespace SemestralProject.Data
{
    /// <summary>
    /// Class representing manufacturer of vehicles
    /// </summary>
    internal class Manufacturer : AbstractIconData
    {
        /// <summary>
        /// Creates new manufacturer of vehicles
        /// </summary>
        /// <param name="id">Identifier of manufacturer of vehicles</param>
        /// <param name="name">Name of manufacturer of vehicles</param>
        /// <param name="description">Description of manufacturer of vehicles</param>
        /// <param name="icon">Icon of manufacturer of vehicles</param>
        public Manufacturer(string id, string name, string description, Icon icon)
            : base(id, name, description, icon) { }

        /// <summary>
        /// Creates new manufacturer of vehicles
        /// </summary>
        /// <param name="id">Identifier of manufacturer of vehicles</param>
        /// <param name="name">Name of manufacturer of vehicles</param>
        /// <param name="description">Description of manufacturer of vehicles</param>
        /// <param name="icon">Icon of manufacturer of vehicles</param>
        /// <param name="created">Date and time of creation of manufacturer in system</param>
        /// <param name="updated">Date and time of last update of manufacturer in system</param>
        public Manufacturer(string id, string name, string description, Icon icon, DateTime created, DateTime updated)
            : base(id, name, description, icon, created, updated) { }
    }
}
