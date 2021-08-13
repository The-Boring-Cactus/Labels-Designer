using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabelDesigner
{
    public class SelectEvent : EventArgs
    {
        public string id { get; }
        public SelAction action { get; }

        public SelectEvent(string fileName, SelAction act)
        {
            id = fileName;
            action = act;
        }
    }
    public enum SelAction
    {
        Add,
        Remove
    }
}
