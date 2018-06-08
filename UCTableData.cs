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
    public partial class UCTableData : UserControl
    {
        private List<UCAdvancedOptions> _listAO;
        private TextBox _column, _row;

        public UCTableData()
        {
            InitializeComponent();
            _listAO = new List<UCAdvancedOptions>();

            _column =new TextBox();
            _column.Location = TBColumn.Location;
            _column.Size = TBColumn.Size;
            _column.Enabled = false;
            _column.Parent = this;

            _row =new TextBox();
            _row.Location = TBRow.Location;
            _row.Size = TBRow.Size;
            _row.Enabled = false;
            _row.Parent = this;
            
            _row.Visible = false;
            _column.Visible = false;
        }

        private void ADvancedOptionButton(object sender, EventArgs e)
        {
            Button button = sender as Button;
            switch (button.Text)
            {
                case "+":
                    AddAObutton();
                    break;
                case "-":
                    if (_listAO.Count > 0)
                    {
                        _listAO[_listAO.Count-1].Dispose();
                        _listAO.Remove(_listAO[_listAO.Count - 1]);
                    }
                    break;
            }
            CheckTableSizeLock();
        }

        private void AddAObutton()
        {
            UCAdvancedOptions ucAO=new UCAdvancedOptions(TBColumn.Value,TBRow.Value);
            if (_listAO.Count != 0)
            {
                ucAO.Size = new Size(260, 90);
                ucAO.Location = new System.Drawing.Point(_listAO[_listAO.Count - 1].Location.X,
                    _listAO[_listAO.Count - 1].Location.Y + ucAO.Size.Height);
                ucAO.Parent = this;
                _listAO.Add(ucAO);
            }
            else
            {
                ucAO.Size = new Size(260, 90);
                ucAO.Location=new System.Drawing.Point(41,60);
                ucAO.Parent = this;
                _listAO.Add(ucAO);

            }
        }

        private void CheckTableSizeLock()
        {
            if (_listAO.Count <= 0)
            {
                TBColumn.Visible = true;
                TBRow.Visible = true;
            }
            else
            {
                TBColumn.Visible = false;
                TBRow.Visible = false;
                _row.Text = TBRow.Value.ToString();
                _column.Text = TBColumn.Value.ToString();
                _row.Visible = true;
                _column.Visible = true;

            }
        }

        public List<DataMergeVariables> GetMergeVars()
        {
            List<DataMergeVariables> data=new List<DataMergeVariables>();
            foreach (var objectAO in _listAO)
            {
                data.Add(objectAO.GetData());
            }
            
            return data;
        }

        public int GetColumnAmount => Int32.Parse(TBColumn.Value.ToString());

        public int GetRowAmount => Int32.Parse(TBRow.Value.ToString());
    }
}
