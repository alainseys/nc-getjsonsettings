using System.IO;
using System.Reflection;
using log4net;
using log4net.Config;

namespace getjsonsettings
{
    public class Log
    {
        public static void Init(string loglevel, string logmessage)
        {
            var logrepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
            XmlConfigurator.Configure(logrepository, new FileInfo("log4config"));
            var _log4net = log4net.LogManager.GetLogger(typeof(Log));
            if (loglevel == "INFO")
            {
                _log4net.Info(logmessage);
            }

            if (loglevel == "WARN")
            {
                _log4net.Error(logmessage);
            }

            if (loglevel == "ERROR")
            {
                _log4net.Error(logmessage);
            }
        }
    }
}