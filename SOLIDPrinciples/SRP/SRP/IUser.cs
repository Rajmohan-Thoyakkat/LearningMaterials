using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    interface IUser
    {
        bool Login(string userName, string password);
        bool Register(string userName, string password, string email);
    }

    interface ILogger
    {
        void LogError(string error);
    }

    interface IEmail
    {
        bool SendMail(string emailContent);
    }
}
