log4net SmtpAppender with SubjectLayout
=====================================
__NuGet:__ [https://nuget.org/packages/log4net.Appender.SmtpAppenderWithSubjectLayout](https://nuget.org/packages/log4net.Appender.SmtpAppenderWithSubjectLayout)

Subject layout example
=================
```csharp
XmlConfigurator.Configure();
ILog logger = LogManager.GetLogger("logger");
logger.Error("Some error");
```

```xml
<appender name="SMTPAppender" type="log4net.Appender.SmtpAppenderWithSubjectLayout, log4net.Appender.SmtpAppenderWithSubjectLayout">
  <!-- ... -->
  <subjectLayout>
    <conversionPattern value="Local // %p: %date [%c]" />
  </subjectLayout>
  <!-- ... -->
</appender>
```

Email subject: __Local // ERROR: 2013-05-14 23:58:05,847 [logger]__
