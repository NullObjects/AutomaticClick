using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using AutomaticClick.Models;
using Microsoft.Azure.CognitiveServices.Vision.ComputerVision.Models;
using Newtonsoft.Json;

namespace AutomaticClick.Utils
{
    /// <summary>
    /// 翻译
    /// </summary>
    public static class Translation
    {
        private static readonly string SubscriptionKey = Program.Configuration["System:TranslationSubscriptionKey"];
        private static readonly string Endpoint = Program.Configuration["System:TranslationEndpoint"];

        // Add your location, also known as region. The default is global.
        // This is required if using a Cognitive Services resource.
        private const string Location = "eastus";

        public static async Task<List<TranslationItem>> Translate(ImageAnalysis analysis)
        {
            // Output languages are defined as parameters, input language detected.
            const string route = "/translate?api-version=3.0&to=zh-Hans";
            var body = new List<object>();
            body.AddRange(analysis.Brands.Select(x => new {Text = x.Name}));
            body.AddRange(analysis.Objects.Select(x => new {Text = x.ObjectProperty}));
            body.AddRange(analysis.Faces.Select(x => new {Text = $"{x.Gender}-{x.Age}"}));
            var requestBody = JsonConvert.SerializeObject(body);

            using var client = new HttpClient();
            using var request = new HttpRequestMessage();
            // Build the request.
            request.Method = HttpMethod.Post;
            request.RequestUri = new Uri(Endpoint + route);
            request.Content = new StringContent(requestBody, Encoding.UTF8, "application/json");
            request.Headers.Add("Ocp-Apim-Subscription-Key", SubscriptionKey);
            request.Headers.Add("Ocp-Apim-Subscription-Region", Location);

            // Send the request and get response.
            var response = await client.SendAsync(request).ConfigureAwait(false);
            // Read response as a string.
            var resultString = await response.Content.ReadAsStringAsync();
            //获取翻译结果
            var result = JsonConvert.DeserializeObject<List<TranslationItem>>(resultString);
            foreach (var item in result.Skip(analysis.Brands.Count).Take(analysis.Objects.Count)) item.Group = 1;
            foreach (var item in result.Skip(analysis.Brands.Count).Skip(analysis.Objects.Count).Take(analysis.Faces.Count)) item.Group = 2;

            return result;
        }
    }
}