# nc-getjsonsettings
With this solution you will be abble to loop troug a json settings file and call all the diferent key settings

##Clone the project
clone the project in github and open the project file (*.sln) , check if the nuget packages are present in the project if not you should add the following
```c#
Microsoft.Extensions.Configuration;
Micorosoft.Extension.Configuration.Binder;
Microsoft.Extionsion.Configuration.json;
```

##Adding keys
Add you setting keys in the appsettings.json file with master slave relations see the example bellow we have FtpSettings , with as slave FTP_SERVER , FTP_USER, FTP_PASS these values we will loop trough.
```json
 "FtpSettings": {
        "FTP_SERVER": "xyz",
        "FTP_USER": "ftp user",
        "FTP_PASS": "ftp pass"
    },
    "SmtpSettings": {
        "SMTP_SERVER": "smtp server setting",
        "SMTP_USER": "smtp user",
        "SMTP_PASS": "smtp pass"
    }
```
###Regristration of the key values
To allow the ussage of the key values you need to create a class in ConfigBuild.cs
```c#
public FtpSettings GetFtpSettings()
{
return GetSection<FtpSettings>(FtpSettings.SECTION_NAME);
}
```
and register all the possible values you want to call
````c#
public class FtpSettings
        {
            public static readonly string SECTION_NAME = "FtpSettings";
            public string FTP_SERVER { get; set; }
            public string FTP_USER { get; set; }
            public string FTP_PASS { get; set; }
        }
````
after you have done this now you are able to call these values bellow an example how to call these in a seperate class file.

````c#
//call the configuration builder
            ConfigBuild cnf = new ConfigBuild();

            //plase the settings in variables to set them
            var FTP_SETTING = cnf.GetFtpSettings();
            var FTP_SERVER = FTP_SETTING.FTP_SERVER;
            var FTP_USER = FTP_SETTING.FTP_USER;
            
            Console.Write(FTP_SERVER);
            Console.Write(FTP_USER);
````

