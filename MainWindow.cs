using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace HTMLTableGenerator
{
    public partial class MainWindow : Form
    {
        public Action<int, int, List<DataMergeVariables>> DataGeneratedAction;
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void GenerateTableButtonDown(object sender, EventArgs e)
        {
            DataGeneratedAction(ucTableData.GetColumnAmount
                , ucTableData.GetRowAmount
                , ucTableData.GetMergeVars());
        }
    }
}
