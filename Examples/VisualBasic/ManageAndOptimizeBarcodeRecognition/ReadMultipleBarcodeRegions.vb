﻿Imports System.Drawing
Imports Aspose.BarCode.BarCodeRecognition

'
' This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
' When the project is build. Please check http://docs.nuget.org/consume/nuget-faq for more information. 
' If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
' Install it and then add its reference to this project. For any issues, questions or suggestions 
' Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.BarCode.Examples.VisualBasic.ManageAndOptimizeBarCodeRecognition
    Class ReadMultipleBarcodeRegions
        Public Shared Sub Run()
            'ExStart:ReadMultipleBarcodeRegions
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManageAndOptimizeBarcodeRecognition()

            ' Initialize the Bitmap object            
            Dim bitmap As New Bitmap(dataDir & Convert.ToString("Region.png"))
            Dim areas As Rectangle() = New Rectangle(2) {}
            areas(0) = New Rectangle(50, 50, 300, 300)
            areas(1) = New Rectangle(400, 40, 350, 350)
            areas(2) = New Rectangle(40, 500, 700, 150)

            ' Initialize the BarCodeReader object and load bitmap object       
            Using reader As New BarCodeReader(bitmap, areas, DecodeType.Code39Standard)
                While reader.Read()
                    Console.WriteLine("GetCodeType" & reader.GetCodeType().ToString() + "GetCodeText: " + reader.GetCodeText().ToString())
                End While
            End Using
            'ExEnd:ReadMultipleBarcodeRegions
        End Sub
    End Class
End Namespace
