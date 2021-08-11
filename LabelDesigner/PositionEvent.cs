using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabelDesigner
{
    public class PositionEvent : EventArgs
    {
        public string X { get; }
        public string Y { get; }

        public PositionEvent(string _X, string _Y)
        {
            X = _X;
            Y = _Y;
        }
    }
}
