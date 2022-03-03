using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutomaticClick.Models;
using Microsoft.Azure.CognitiveServices.Vision.ComputerVision;
using Microsoft.Azure.CognitiveServices.Vision.ComputerVision.Models;

namespace AutomaticClick.Utils
{
    /// <summary>
    /// Ocr识别
    /// </summary>
    public class Ocr
    {
        /// <summary>
        /// OCR分析
        /// </summary>
        /// <param name="client"></param>
        /// <param name="imageStream"></param>
        public static async Task<List<OcrItem>> AnalyzeStream(IComputerVisionClient client, Stream imageStream)
        {
            // var textHeaders = await client.ReadAsync(urlFile);
            var textHeaders = await client.ReadInStreamAsync(imageStream);
            // After the request, get the operation location (operation ID)
            var operationLocation = textHeaders.OperationLocation;

            // Retrieve the URI where the extracted text will be stored from the Operation-Location header.
            // We only need the ID and not the full URL
            const int numberOfCharsInOperationId = 36;
            var operationId = operationLocation[^numberOfCharsInOperationId..];

            // Extract the text
            ReadOperationResult results;
            do
            {
                results = await client.GetReadResultAsync(Guid.Parse(operationId));
            } while (results.Status is OperationStatusCodes.Running or OperationStatusCodes.NotStarted);

            // Display the found text.
            var list = new List<OcrItem>();
            var textUrlFileResults = results.AnalyzeResult.ReadResults;
            foreach (var page in textUrlFileResults)
            {
                list.AddRange(page.Lines.Select((line, index) => new OcrItem {Index = index, Item = line.Text}));
            }

            return list;
        }
    }
}