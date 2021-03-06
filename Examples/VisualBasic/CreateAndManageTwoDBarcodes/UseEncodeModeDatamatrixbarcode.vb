﻿Imports Aspose.BarCode.Generation

'
' This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
' When the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
' If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
' Install it and then add its reference to this project. For any issues, questions or suggestions 
' Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'


Namespace Aspose.BarCode.Examples.VisualBasic.CreateAndManageTwoDBarcodes
    Class UseEncodeModeDatamatrixbarcode
        Public Shared Sub Run()
            'ExStart:UseEncodeModeDatamatrixbarcode
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_CreateAndManage2DBarCodes()
            Dim gtin As String = "898978777776665655"
            Dim uid As String = "121212121212121212"
            Dim batch As String = "GH768"
            Dim expDate As String = "150923"

            Dim textToEncode As String = Convert.ToString(Convert.ToString(gtin & uid) & batch) & expDate
            ' Or  "(01)"+ gtin + "(..)"+ uid + ...
            Dim textToDisplay As String = Convert.ToString((Convert.ToString((Convert.ToString((Convert.ToString("GTIN:") & gtin) + vbLf & "UID:") & uid) + vbLf & "Batch:") & batch) + vbLf & "Exp.Date:") & expDate

            ' Instantiate barcode object            
            Dim builder As New BarCodeBuilder("textToEncode", EncodeTypes.DataMatrix)

            ' N order to avoid including all the names into the codetext, the property called "Display2DText" should be used.
            builder.Display2DText = textToDisplay
            builder.CodeLocation = CodeLocation.Right
            builder.Margins = New MarginsF(0, 0, 0, 0)

            ' Builder.CodeTextSpace = 0 // not recommended small space

            ' Save the Barcode image
            builder.Save(dataDir & Convert.ToString("codetextRightDisplay_out.png"), BarCodeImageFormat.Png)
            'ExEnd:UseEncodeModeDatamatrixbarcode
        End Sub
    End Class
End Namespace
