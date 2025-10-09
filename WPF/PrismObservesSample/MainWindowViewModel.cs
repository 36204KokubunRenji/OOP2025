using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismObservesSample {
    internal class MainWindowViewModel : BindableBase{
        private string _input1 = "";
        public string Input1 {
            get =>_input1;
            set;
        }

        private string _input2 = "";
        public string Input2 {
            get => _input2;
            set;
        }
        
        private string _result = "";
        public string Result {
            get => _result;
            set;
        }
        //コンストラクタ
        public MainWindowViewModel() {
            SumCommand = 
        }
        public DelegateCommand SumCommand { get; }

    }
}
