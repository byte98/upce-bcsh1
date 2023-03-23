using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemestralProject.Data
{
    /// <summary>
    /// Class representing passenger information system
    /// </summary>
    internal class InformationSystem
    {
        /// <summary>
        /// Date and time when information system has been created
        /// </summary>
        public DateTime Created { get; private init; }

        /// <summary>
        /// Date and time when information system has been lastly updated
        /// </summary>
        public DateTime Updated { get; private set; }
        
        /// <summary>
        /// Icon of information system
        /// </summary>
        public Icon Icon { get; private set; }

        /// <summary>
        /// Name of information system
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Description of information system
        /// </summary>
        public string Description { get; private set; }
    }
}
