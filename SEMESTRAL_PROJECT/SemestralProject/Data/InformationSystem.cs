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
        public Icon Icon { get; private set; } = FileStorage.Instance.GetIcon(FileStorage.DefaultIconType.IS);

        /// <summary>
        /// Name of information system
        /// </summary>
        public string Name { get; private set; } = string.Empty;

        /// <summary>
        /// Description of information system
        /// </summary>
        public string Description { get; private set; } = string.Empty;

        /// <summary>
        /// Identifier of information system
        /// </summary>
        public string ID { get; private init; }

        /// <summary>
        /// Creates new information system
        /// </summary>
        /// <param name="id">Identifier of informations system</param>
        public InformationSystem(string id) : this(id, DateTime.Now, DateTime.Now, FileStorage.Instance.GetIcon(FileStorage.DefaultIconType.IS), string.Empty, string.Empty) { }

        /// <summary>
        /// Creates new information system
        /// </summary>
        /// <param name="id">Identifier of information system</param>
        /// <param name="icon">Icon of information system</param>
        /// <param name="name">Name of information system</param>
        /// <param name="description">Description of information system</param>
        public InformationSystem(string id, Icon icon, string name, string description): this(id, DateTime.Now, DateTime.Now, icon, name, description) { }

        /// <summary>
        /// Creates new information system
        /// </summary>
        /// <param name="id">Identifier of information system</param>
        /// <param name="created">Date and time of creation of information system</param>
        /// <param name="icon">Icon of information system</param>
        /// <param name="name">Name of information system</param>
        /// <param name="description">Description of information system</param>
        public InformationSystem(string id, DateTime created, Icon icon, string name, string description): this(id, created, DateTime.Now, icon, name, description) { }
        
        /// <summary>
        /// Creates new information system
        /// </summary>
        /// <param name="id">Identifier of information system</param>
        /// <param name="created">Date and time of creation of information system</param>
        /// <param name="updated">Date and time of last modification of information system</param>
        /// <param name="icon">Icon of information system</param>
        /// <param name="name">Name of information system</param>
        /// <param name="description">Description of information system</param>
        public InformationSystem(string id, DateTime created, DateTime updated, Icon icon, string name, string description)
        {
            this.ID = id;
            this.Created = created;
            this.Updated = updated;
            this.Icon = icon;
            this.Name = name;
            this.Description = description;
        }
    }
}
