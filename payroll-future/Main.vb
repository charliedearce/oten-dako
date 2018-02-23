
Imports System.ComponentModel
Imports System.Text
Imports AutoUpdaterDotNET

Partial Public Class Main
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm
    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()
    End Sub
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AutoUpdater.Start("http://top.app/update.xml")
        AutoUpdater.Mandatory = True
        AutoUpdater.AppTitle = "Payroll Updater"
    End Sub
End Class
