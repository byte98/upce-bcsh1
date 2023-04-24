using SemestralProject.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SemestralProject.Persistence
{
    /// <summary>
    /// Structure which wraps information about file
    /// </summary>
    internal struct FileWrapper
    {
        /// <summary>
        /// Class which holds structure of XML in which information about file will be inserted into
        /// </summary>
        private static class XML
        {
            /// <summary>
            /// XML element holding name of file
            /// </summary>
            public const string Name = "NAME";
            
            /// <summary>
            /// XML element holding path to file
            /// </summary>
            public const string Path = "PATH";

            /// <summary>
            /// XML element holding checksum of file
            /// </summary>
            public const string Checksum = "CHECKSUM";
        }

        /// <summary>
        /// Name of file
        /// </summary>
        public string Name { get; init; }

        /// <summary>
        /// Path to file
        /// </summary>
        public string Path { get; init; }

        /// <summary>
        /// Path which will be written to any output
        /// </summary>
        public string SavePath { get; init; }

        /// <summary>
        /// Check sum of file
        /// </summary>
        public string Checksum { get; init; }

        /// <summary>
        /// Creates new wrapper of information about file
        /// </summary>
        /// <param name="name">Name of file</param>
        /// <param name="path">Path to file</param>
        /// <param name="savePath">Path which will be written to any output</param>
        public FileWrapper(string name, string path, string savePath)
        {
            this.Name = name;
            this.Path = path;
            this.Checksum = FileUtils.GenerateChecksum(this.Path);
            this.SavePath = savePath;
        }

        /// <summary>
        /// Generates XML representation of information about file
        /// </summary>
        /// <param name="document">XML document in which element will be created</param>
        /// <param name="element">Name of element in which information will be inserted into</param>
        /// <param name="parent">Element to which new element with information about file will be appended</param>
        public void ToXml(XmlDocument document, string element, XmlElement parent)
        {
            XmlElement elem = document.CreateElement(string.Empty, element, string.Empty);
            XmlElement name = document.CreateElement(string.Empty, FileWrapper.XML.Name, string.Empty);
            name.InnerText = this.Name;
            elem.AppendChild(name);
            XmlElement path = document.CreateElement(string.Empty, FileWrapper.XML.Path, string.Empty);
            path.InnerText = this.SavePath;
            elem.AppendChild(path);
            XmlElement checksum = document.CreateElement(string.Empty, FileWrapper.XML.Checksum, string.Empty);
            checksum.InnerText = this.Checksum;
            elem.AppendChild(checksum);
            parent.AppendChild(elem);
        }
    }
}
