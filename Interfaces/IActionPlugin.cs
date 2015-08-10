using PA.Plugin.Operations.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;

namespace PA.Plugin.Operations.Interfaces
{
    [InheritedExport]
    public interface IActionPlugin : IPlugin 
    {
        bool CanExecute(IDictionary<object, object> data);
        object Execute(IDictionary<object, object> data);
    }
}
