using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatexTableGenerator
{
    class Controller
    {
        private readonly Model _model;
        private readonly MainWindow _view;

        public Controller(ref Model model,ref MainWindow view)
        {
            _model = model;
            _view = view;
        }

    }
}
