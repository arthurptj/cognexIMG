using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Yuzhang.Net20.Core.Abstracts;

namespace Fhcmi.Automation.Cognex_Test.net48
{
    class Class1 : CyclicDataContextBase
    {
        private string _myString;

        public string MyString
        {
            get => GetObservableValue(ref _myString);
            set => SetObservableValue(ref _myString, value);
        }

        public override void Update(ElapsedEventArgs e)
        {
            
        }
    }
}
