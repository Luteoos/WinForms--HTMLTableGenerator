using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLTableGenerator
{
    class Controller
    {
        private readonly Model _model;
        private readonly MainWindow _view;

        public Controller(ref Model model,ref MainWindow view)
        {
            _model = model;
            _view = view;
            _view.DataGeneratedAction += this.DataReceived;

        }

        private void DataReceived(int column, int row, List<DataMergeVariables> listDataMerge)
        {
            _model.GenerateHTML(column,row,listDataMerge);
            _model.SaveToFile();
        }
    }
}
