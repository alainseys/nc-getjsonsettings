using System.IO;
using Microsoft.Extensions.Configuration;
namespace getjsonsettings
{
    public class ConfigBuild
    {
        private readonly IConfiguration _configuration;

        public ConfigBuild()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            _configuration = builder.Build();
        }

        public FtpSettings GetFtpSettings()
        {
            return GetSection<FtpSettings>(FtpSettings.SECTION_NAME);
        }

        public class FtpSettings
        {
            public static readonly string SECTION_NAME = "FtpSettings";
            public string FTP_SERVER { get; set; }
        }

        public T GetSection<T>(string sectionname)
            where T : class, new()
        {
            return _configuration.GetSection(sectionname).Get<T>();
        }
        
    }
}