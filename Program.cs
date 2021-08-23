using System;

namespace getjsonsettings
{
    class Program
    {
        static void Main(string[] args)
        {
            //call the configuration builder
            ConfigBuild cnf = new ConfigBuild();

            //plase the settings in variables to set them
            var FTP_SETTING = cnf.GetFtpSettings();
            var FTP_SERVER = FTP_SETTING.FTP_SERVER;
            var FTP_USER = FTP_SETTING.FTP_USER;
            
            Console.Write(FTP_SERVER);
            Console.Write(FTP_USER);
 
        }
    }
}