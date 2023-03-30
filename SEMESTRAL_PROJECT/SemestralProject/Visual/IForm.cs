using SemestralProject.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemestralProject.Visual
{
    /// <summary>
    /// Interface which declares context availability for every form
    /// </summary>
    internal interface IForm
    {
        protected Context Context { get; init; }
    }
}
