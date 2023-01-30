using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPDemo
{
    interface IPrintasks
    {
        bool PrintContent(string content);
        bool ScanContent(string content);       
        bool PhotocopyContent(string content);        
    }

    interface IFaxContent
    {
        bool FaxContent(string content);
    }

    interface IDuplexContent
    {
        bool DuplexContent(string content);
    }
}
