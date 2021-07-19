# log4NET
How to use Log4Net for VB.net or C#.net

1. Download log4Net from https://logging.apache.org/log4net/download_log4net.html or Nuget from https://www.nuget.org/packages/log4net/
2. Add lognet to your project (If you installed using Nuget just add "Imports lognet") If you downloaded the zip file, just add to your project reference log4net.dll
3. 3. Config using the following code to app.config under the tab

```
<configSections>
        <section name="log4net" type="log4net.Config.Log4NetConfigurationSectionHandler, log4net" />
    </configSections>
    <log4net>
        <!--Root Logger is for all logger-->
        <!--<root>
            <level value="ALL" />
            <appender-ref ref="FileAppender" />
        </root> -->
        <logger name="FileAppender">
            <level value="ALL" /> Check all the level
            <appender-ref ref=" FileAppender " />
        </logger>
        <appender name=" FileAppender " type="log4net.Appender.RollingFileAppender">
            <file value="C:/Myapp.log" />
            <appendToFile value="true" />
            <rollingStyle value="Composite" />
            <datePattern value="yyyyMMdd" />
            <maxSizeRollBackups value="10" />
            <maximumFileSize value="200K" />
            <layout type="log4net.Layout.PatternLayout">
                <conversionPattern value="%date [%thread] - [%logger] %message%newline" />
            </layout>
        </appender>
    </log4net>
```
FileAppender is the name of the logger class, all logger with the name FileAppender will follow this configuration. *file value set the store path of the log file.


4. Creating a Logger class (VB.NET)

```
Imports log4net
 
Public Class Logger
    Private Shared logger As ILog = LogManager.GetLogger("FileAppender")
 
    Public Shared Sub LogInfo(ByVal str As String)
        logger.Info(str)
    End Sub
 
    Public Shared Sub LogError(ByVal str As String)
        logger.Error(str)
    End Sub
 
    Public Shared Sub LogFatal(ByVal str As String)
        logger.Fatal(str)
    End Sub
End Class
```

C#.NET
```
using log4net;
 
public class Logger
{   
private static ILog logger = LogManager.GetLogger("FileAppender");
    public static void LogInfo(string str)
    {
        logger.Info(str);
    }
 
    public static void LogError(string str)
    {
        logger.Error(str);
    }
 
    public static void LogFatal(string str)
    {
        logger.Fatal(str);
    }
}
```

5. Import the Logger class to your class and use it anywhere in your project:
```
1 Logger.LogInfo
2 Logger.LogError
3 Logger.LogFatal
4 Logger.LogDebug
5 Logger.LogWarn
```

6. See the Example.vb file
