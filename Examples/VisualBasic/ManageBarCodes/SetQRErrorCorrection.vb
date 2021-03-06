﻿Imports Aspose.BarCode.Generation

'
' This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
' When the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
' If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
' Install it and then add its reference to this project. For any issues, questions or suggestions 
' Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.BarCode.Examples.VisualBasic.ManageBarCodes
    Class SetQRErrorCorrection
        Public Shared Sub Run()
            'ExStart:SetQRErrorCorrection
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManageBarCodes()

            ' Create instance of BarCodeBuilder, specify codetext and symbology in the constructor
            Dim builder As New BarCodeBuilder("1234567890", EncodeTypes.QR)

            ' Set QRErrorLevel     
            builder.QRErrorLevel = QRErrorLevel.LevelH

            ' Save the file to disk
            builder.Save(dataDir & Convert.ToString("QR-error-correction_out.jpg"), BarCodeImageFormat.Jpeg)
            'ExEnd:SetQRErrorCorrection
        End Sub
    End Class
End Namespace