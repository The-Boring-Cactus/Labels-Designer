using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabelDesigner
{
    public  class RemoveEvent: EventArgs
    {
        public string id { get; }

        public RemoveEvent(string fileName)
        {
            id = fileName;
        }
    }
}
