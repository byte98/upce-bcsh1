using SemestralProject.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemestralProject.Visual
{
    /// <summary>
    /// Class which can view properties of mutable object
    /// </summary>
    public partial class MutableBox : UserControl
    {
        /// <summary>
        /// Object which will be viewed
        /// </summary>
        public IMutable Object 
        {
            get
            {
                return this.Object;
            }
            set
            {
                this.Object = value;
                this.Object.MutableObjectChanged += MutableObjectChanged;
                this.ShowObject();
            }
        }

        private void MutableObjectChanged(object sender, IMutable.MutableObjectChangedEventArgs args)
        {
            this.ShowObject();
        }

        public MutableBox()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Shows object properties
        /// </summary>
        private void ShowObject()
        {
            this.tableLayoutPanelContent.Controls.Clear();
            if (this.Object != null)
            {
                this.tableLayoutPanelContent.ColumnCount = 2;
                this.tableLayoutPanelContent.RowCount = this.Object.Properties.Length;
                int row = 0;
                foreach (string property in this.Object.Properties)
                {
                    Label propName = new Label();
                    propName.Text = property;
                    this.tableLayoutPanelContent.Controls.Add(propName, 0, row);
                    DataType? type = this.Object.GetDataType(property);
                    DataType.EDataType dtype = DataType.EDataType.String;
                    if (type != null)
                    {
                        dtype = type.Type;
                    }
                    Control propVal = new TextBox();
                    switch(dtype)
                    {
                        case DataType.EDataType.String:  propVal = this.CreateTextBox(property);       break;
                        case DataType.EDataType.Integer: propVal = this.CreateIntNumeric(property);    break;
                        case DataType.EDataType.Double:  propVal = this.CreateDoubleNumeric(property); break;
                    }
                }
            }
        }

        /// <summary>
        /// Creates text box for string property
        /// </summary>
        /// <param name="property">Name of property</param>
        /// <returns>Text box with initialized value of property</returns>
        private TextBox CreateTextBox(string property)
        {
            TextBox reti = new TextBox();
            reti.Text = this.Object.GetString(property);
            reti.TextChanged += delegate {
                this.Object.Set(property, reti.Text);
            };
            this.Object.MutableObjectChanged += delegate
            {
                this.Object.GetString(property);
            };
            return reti;
        }

        /// <summary>
        /// Creates numeric up & down control for integer property
        /// </summary>
        /// <param name="property">Name of property</param>
        /// <returns>Numeric up & down control with initialized value of property</returns>
        private NumericUpDown CreateIntNumeric(string property)
        {
            NumericUpDown reti = new NumericUpDown();
            reti.Value = this.Object.GetInt(property);
            DataType? type = this.Object.GetDataType(property);
            if (type != null && type.MinInt != null && type.MaxInt != null)
            {
                reti.Minimum = (decimal)type.MinInt;
                reti.Maximum = (decimal)type.MaxInt;
            }
            else
            {
                reti.Minimum = (decimal)int.MinValue;
                reti.Maximum = (decimal)int.MaxValue;
            }
            reti.ValueChanged += delegate
            {
                this.Object.Set(property, (int)reti.Value);
            };
            this.Object.MutableObjectChanged += delegate
            {
                reti.Value = this.Object.GetInt(property);
            };
            return reti;
        }

        /// <summary>
        /// Creates numeric up & down control for double precision number property
        /// </summary>
        /// <param name="property">Name of property</param>
        /// <returns>Numeric up & down control with initialized value of property</returns>
        private NumericUpDown CreateDoubleNumeric(string property)
        {
            NumericUpDown reti = new NumericUpDown();
            reti.Value = (decimal)this.Object.GetDouble(property);
            DataType? type = this.Object.GetDataType(property);
            if (type != null && type.MinDouble != null && type.MaxDouble != null)
            {
                reti.Minimum = (decimal)type.MinDouble;
                reti.Maximum = (decimal)type.MaxDouble;
            }
            else
            {
                reti.Minimum = decimal.MinValue;
                reti.Maximum = decimal.MaxValue;
            }
            reti.ValueChanged += delegate
            {
                this.Object.Set(property, (double)reti.Value);
            };
            this.Object.MutableObjectChanged += delegate
            {
                reti.Value = (decimal)this.Object.GetDouble(property);
            };
            return reti;
        }
    }
}
