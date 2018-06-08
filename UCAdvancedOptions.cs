using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HTMLTableGenerator
{
    public partial class UCAdvancedOptions : UserControl
    {
        public UCAdvancedOptions(decimal column,decimal row)
        {
            InitializeComponent();
            columnStart.Maximum = column;
            rowStart.Maximum = row;
            UpdateMaximumSpan(null,null);
            columnStart.ValueChanged+=new EventHandler(UpdateMaximumSpan);
            rowStart.ValueChanged+=new EventHandler(UpdateMaximumSpan);
        }

        private void UpdateMaximumSpan(object s, EventArgs e)
        {
            columnSpan.Maximum = columnStart.Maximum - columnStart.Value + 1;
            rowSpan.Maximum = rowStart.Maximum - rowStart.Value + 1;
        }

        public DataMergeVariables GetData()
        {
            int column = Int32.Parse(columnStart.Value.ToString());
            int row= Int32.Parse(rowStart.Value.ToString());
            int columnSpan= Int32.Parse(this.columnSpan.Value.ToString());
            int rowSpan= Int32.Parse(this.rowSpan.Value.ToString());

            return new DataMergeVariables(column,row,columnSpan,rowSpan);
        }
    }
}
