using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LatexTableGenerator
{
    public partial class UCTableData : UserControl
    {
        private List<UCAdvancedOptions> _listAO;

        public UCTableData()
        {
            InitializeComponent();
            _listAO=new List<UCAdvancedOptions>();
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
                    break;
            }
        }

        private void AddAObutton()
        {
            UCAdvancedOptions ucAO=new UCAdvancedOptions();
            if (_listAO.Count != 0)
            {
                ucAO.Location = new System.Drawing.Point(_listAO[_listAO.Count - 1].Location.X,
                    _listAO[_listAO.Count - 1].Location.Y + ucAO.Size.Height + 5);
                _listAO.Add(ucAO);
                //here binding events
            }
            else
            {
                ucAO.Location=new System.Drawing.Point(41,60);

            }
        }
    }
}
