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
    /// 图像分析
    /// </summary>
    public static class Analyze
    {
        /// <summary>
        /// 图像分析
        /// </summary>
        /// <param name="client"></param>
        /// <param name="imageStream"></param>
        public static async Task<ImageAnalysis> AnalyzeStream(IComputerVisionClient client, Stream imageStream)
        {
            // Creating a list that defines the features to be extracted from the image. 
            var features = new List<VisualFeatureTypes?>
            {
                VisualFeatureTypes.Categories, VisualFeatureTypes.Description,
                VisualFeatureTypes.Faces, VisualFeatureTypes.ImageType,
                VisualFeatureTypes.Tags, VisualFeatureTypes.Adult,
                VisualFeatureTypes.Color, VisualFeatureTypes.Brands,
                VisualFeatureTypes.Objects
            };
            // Analyze the image 
            var results = await client.AnalyzeImageInStreamAsync(imageStream, features);
            
            return results;
        }
    }
}