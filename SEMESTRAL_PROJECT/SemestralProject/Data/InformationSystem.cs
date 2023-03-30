using SemestralProject.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Icon = SemestralProject.Visual.Icon;

namespace SemestralProject.Data
{
    /// <summary>
    /// Class representing passenger information system
    /// </summary>
    internal class InformationSystem : AbstractIconData
    {
        /// <summary>
        /// Creates new information system
        /// </summary>
        /// <param name="id">Identifier of information system</param>
        /// <param name="name">Name of information system</param>
        /// <param name="description">Description of information system</param>
        /// <param name="icon">Icon of information system</param>
        public InformationSystem(string id, string name, string description, Icon icon)
            : base(id, name, description, icon) { }

        /// <summary>
        /// Creates new information system
        /// </summary>
        /// <param name="id">Identifier of information system</param>
        /// <param name="name">Name of information system</param>
        /// <param name="description">Description of information system</param>
        /// <param name="icon">Icon of information system</param>
        /// <param name="created">Date and time of creation of information system</param>
        /// <param name="updated">ate and time of last update of information systems</param>
        public InformationSystem(string id, string name, string description, Icon icon, DateTime created, DateTime updated)
            : base(id, name, description, icon, created, updated) { }
    }
}
