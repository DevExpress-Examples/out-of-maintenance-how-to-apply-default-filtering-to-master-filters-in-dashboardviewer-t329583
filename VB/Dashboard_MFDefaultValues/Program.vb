Imports System
Imports System.Windows.Forms
Imports DevExpress.Skins
Imports DevExpress.LookAndFeel

Namespace Dashboard_MFDefaultValues

    Friend Module Program

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread>
        Sub Main()
            Call Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Call SkinManager.EnableFormSkins()
            UserLookAndFeel.Default.SetSkinStyle("DevExpress Style")
            Call Application.Run(New Form1())
        End Sub
    End Module
End Namespace
