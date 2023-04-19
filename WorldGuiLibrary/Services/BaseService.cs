using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldGuiLibrary.Services
{
    public abstract class BaseService
    {
        protected Action<string>? _logMessage;

        public BaseService()
        {            
        }

        public BaseService(Action<string> logMessage)
        {
            _logMessage = logMessage;
        }
        protected void LogMessage(string message)
        {
            if (_logMessage != null)
            {
                _logMessage(message);
                return;
            }
            Console.WriteLine(message);        
            
        }

    }
}
