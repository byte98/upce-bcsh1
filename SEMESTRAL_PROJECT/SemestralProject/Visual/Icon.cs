using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemestralProject.Visual
{
    /// <summary>
    /// Class representing some kind of icon
    /// </summary>
    internal class Icon
    {
        /// <summary>
        /// Name of icon
        /// </summary>
        public string Name { get; init; }

        /// <summary>
        /// Image representation of icon
        /// </summary>
        private Bitmap image;

        /// <summary>
        /// Creates new icon
        /// </summary>
        /// <param name="name">Name of icon</param>
        /// <param name="image">Path to file with image representing icon</param>
        public Icon(string name, string image)
        {
            this.Name = name;
            this.image = new Bitmap(image);
        }

        /// <summary>
        /// Displays icon in picture box
        /// </summary>
        /// <param name="pictureBox">Picture box in which icon will be displayed</param>
        public void Display(PictureBox pictureBox)
        {
            pictureBox.Image = (Image)this.image;
        }
    }
}
