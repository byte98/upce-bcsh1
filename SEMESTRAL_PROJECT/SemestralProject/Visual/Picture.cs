using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemestralProject.Visual
{
    /// <summary>
    /// Class representing picture (used for maps and vehicles)
    /// </summary>
    internal class Picture
    {
        /// <summary>
        /// Name of picture
        /// </summary>
        public string Name { get; init; }

        /// <summary>
        /// Bitmap containing picture
        /// </summary>
        private Bitmap data;

        /// <summary>
        /// Creates new picture
        /// </summary>
        /// <param name="path">Path to file with picture</param>
        public Picture(string path)
        {
            FileInfo fi = new FileInfo(path);
            this.Name = Path.GetFileNameWithoutExtension(fi.FullName);
            using (Stream stream = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                this.data = new Bitmap(stream);
            }
        }

        /// <summary>
        /// Creates new picture
        /// </summary>
        /// <param name="path">Path to file with picture</param>
        /// <param name="name">Name of picture</param>
        public Picture (string path, string name)
        {
            using (Stream stream = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                this.data = new Bitmap(stream);
            }
            this.Name = name;
        }

        /// <summary>
        /// Gets system image representation
        /// </summary>
        /// <returns></returns>
        public System.Drawing.Image GetImage()
        {
            return (System.Drawing.Image)this.data;
        }
    }
}
