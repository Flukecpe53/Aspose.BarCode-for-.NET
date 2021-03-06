﻿using System.Text;
using Aspose.BarCode.Generation;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/
namespace Aspose.BarCode.Examples.CSharp.ManageBarCodes
{
    class CreatePdf417BarcodeWithChineseCharacters
    {
        public static void Run()
        {
            // ExStart:CreatePdf417BarcodeWithChineseCharacters
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageBarCodes();
            const string codetext = "被洪水困住的";

            // Generate the barcode
            BarCodeBuilder builder = new BarCodeBuilder(codetext, EncodeTypes.Pdf417);

            // Encode the code text and Set the display text   
            byte[] bytes = Encoding.GetEncoding(936).GetBytes(codetext);
            builder.SetBinaryCodeText(bytes);
            builder.Display2DText = codetext;
            builder.Save(dataDir + "CreatePdf417BarcodeWithChineseCharacters_out.png");
            // ExEnd:CreatePdf417BarcodeWithChineseCharacters
        }
    }
}