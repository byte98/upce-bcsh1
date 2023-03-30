using SemestralProject.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemestralProject.Visual
{
    /// <summary>
    /// Interface which declares context availability for every control
    /// </summary>
    internal interface IControl
    {
        protected Context Context {get; init; }
    }
}
