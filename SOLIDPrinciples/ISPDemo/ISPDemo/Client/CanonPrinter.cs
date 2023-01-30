using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPDemo.Client
{
    public class CanonPrinter : IPrintasks
    {
        public bool PhotocopyContent(string content)
        {
            throw new NotImplementedException();
        }

        public bool PrintContent(string content)
        {
            throw new NotImplementedException();
        }

        public bool ScanContent(string content)
        {
            throw new NotImplementedException();
        }
    }
}
