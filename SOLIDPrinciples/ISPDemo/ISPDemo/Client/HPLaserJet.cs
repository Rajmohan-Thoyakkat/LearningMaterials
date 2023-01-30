using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPDemo.Client
{
    public class HPLaserJet : IPrintasks,IFaxContent,IDuplexContent
    {
        public bool DuplexContent(string content)
        {
            Console.WriteLine("Duplex content Done");
            return true;
        }

        public bool FaxContent(string content)
        {
            Console.WriteLine("Fax Done");
            return true;
        }

        public bool PhotocopyContent(string content)
        {
            Console.WriteLine("PhotoCopy Done");
            return true;
        }

        public bool PrintContent(string content)
        {
            Console.WriteLine("Print Done");
            return true;
        }

        public bool ScanContent(string content)
        {
            Console.WriteLine("Scan Done");
            return true;
        }
    }
}
