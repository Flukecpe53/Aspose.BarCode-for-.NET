﻿Imports Aspose.BarCode.BarCodeRecognition

'
' This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
' When the project is build. Please check http://docs.nuget.org/consume/nuget-faq for more information. 
' If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
' Install it and then add its reference to this project. For any issues, questions or suggestions 
' Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.BarCode.Examples.VisualBasic.ManageAndOptimizeBarCodeRecognition
    Class DetectUnreadableBarcode
        Public Shared Sub Run()
            'ExStart:DetectUnreadableBarcode
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManageAndOptimizeBarcodeRecognition()

            ' Initialize the BarCodeReader object
            Using reader As New BarCodeReader(dataDir & Convert.ToString("code39.png"), DecodeType.Code39Standard)

                ' Set RecognitionMode
                reader.RecognitionMode = RecognitionMode.MaxBarCodes
                While reader.Read()
                    Console.WriteLine(reader.GetCodeType())
                    Console.WriteLine(reader.GetCodeType())
                    Console.WriteLine("IsDeniable: " & reader.GetIsDeniable().ToString())
                End While
            End Using
            'ExEnd:DetectUnreadableBarcode
        End Sub
    End Class
End Namespace
