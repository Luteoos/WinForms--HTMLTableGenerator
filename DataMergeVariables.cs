using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HTMLTableGenerator
{
    public class DataMergeVariables
    {
        private readonly int _column, _row, _columnSpan, _rowSpan;

#region Getters
        public int Column
        {
            get => _column;
        }

        public int Row
        {
            get => _row;
        }

        public int ColumnSpan
        {
            get => _columnSpan;
        }

        public int RowSpan
        {
            get => _rowSpan;
        }
#endregion

        public DataMergeVariables(int c, int r, int cSpan, int rSpan)
        {
            _column = c;
            _row = r;
            _columnSpan = cSpan;
            _rowSpan = rSpan;
        }
    }
}
