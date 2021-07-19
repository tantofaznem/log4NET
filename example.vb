```
imports log4net

Public Class Form1
Dim log As log4net.ILog
Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
log = log4net.LogManager.GetLogger("MyApp")
log4net.Config.XmlConfigurator.Configure()
End Sub
  
Private Sub cmdDebug_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDebug.Click
    logger.Debug("'Debug' level message")
End Sub
Private Sub cmdInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdInfo.Click
log.Info("'Info' level message")
End Sub
 
Private Sub cmdWarn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdWarn.Click
log.Warn("'Warning' level message")
End Sub
 
Private Sub cmdError_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdError.Click
log.Error("'Error' level message")
End Sub
Private Sub cmdFatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFatal.Click
log.Fatal("'Fatal' level message")
End Sub
```
