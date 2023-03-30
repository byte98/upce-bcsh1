using SemestralProject.Data;
using SemestralProject.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemestralProject.Forms.InformationSystems
{
    /// <summary>
    /// Class representing dialog which shows information
    /// about information system
    /// </summary>
    internal class FormISInfo: FormDialog
    {
        /// <summary>
        /// Creates new dialog which shows information about information system
        /// </summary>
        /// <param name="system">System which will be shown</param>
        /// <param name="context">Wrapper of all programs resources</param>
        public FormISInfo(InformationSystem system, Context context): base("Informace o informačním systému", "Detail informačního systému", SemestralProject.Resources.is_info, context)
        {
            ControlDataView content = new ControlDataView(
                system.Name, system.Description, new Bitmap(system.Icon.GetImage()), system.Created, system.Updated.Date, context);
            this.AddControl(content);
            this.HideCancelButton();
        }
    }
}
