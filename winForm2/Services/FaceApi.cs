﻿using Microsoft.ProjectOxford.Face;
using Microsoft.ProjectOxford.Face.Contract;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Emotions
{
    class FaceApi
    {

        ///// <summary>
        ///// Subscription Key azure
        ///// </summary>
        //private static String SubscriptionKey = "";

        ////FaceService Client

        //private static FaceServiceClient clientface;
        //public static FaceServiceClient ClientFace
        //{
        //    get
        //    {
        //        if (clientface == null)
        //            clientface = new FaceServiceClient(SubscriptionKey);
        //        return clientface;
        //    }
        //}

        ///// <summary>
        ///// Vymaže všetky skupiny na Azure
        ///// </summary>
        //public static async void DeleteGroups(int countGroup)
        //{
        //    for (int i = 0; i < countGroup; i++)
        //    {
        //        var client = new HttpClient();
        //        client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", SubscriptionKey);
        //        var uri = $"https://westus.api.cognitive.microsoft.com/face/v1.0/persongroups/{i}"; // + queryString;
        //        try
        //        {
        //            var response = await ClientFace.DetectAsync(uri);

        //        }
        //        catch 
        //        {
        //            break;
        //        }

        //    }
        //}

        //public static async Task AddFaceToApi(Person person)
        //{
        //    String personGroupId = person.GroupId + "";

        //    String groupImages = Application.StartupPath + @"\FaceGroups\" + personGroupId;

        //    Task tCreate = ClientFace.CreatePersonGroupAsync(person.GroupId+"", personGroupId);
        //    tCreate.Wait();

        //    foreach (string imagePath in Directory.GetFiles(groupImages, "*.jpg"))
        //    {
        //        using (Stream s = File.OpenRead(imagePath))
        //        {
        //            await ClientFace.AddPersonFaceAsync(personGroupId, person.FaceID, s);
        //        }
        //    }

        //    var t = ClientFace.TrainPersonGroupAsync(personGroupId);
        //    //t.Wait();

        //    await Task.Delay(1000);
        //}

        public static async Task<List<Face>> MakeFaceRequest(Image image, string subscriptionKey)
        {
            var client = new HttpClient();

            // Request headers - replace this example key with your valid key.
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", subscriptionKey);

            // Request parameters and URI string.
            string queryString = "returnFaceId=true&returnFaceLandmarks=true&returnFaceAttributes=age,emotion,gender";
            //string queryString = "returnFaceId=true&returnFaceLandmarks=false&returnFaceAttributes=age,emotion,gender";
            string uri = "https://westus.api.cognitive.microsoft.com/face/v1.0/detect?" + queryString;

            HttpResponseMessage response;
            string responseContent;
            byte[] byteData = GetImageAsByteArray(image);

            using (var content = new ByteArrayContent(byteData))
            {
                // This example uses content type "application/octet-stream".
                // The other content types you can use are "application/json" and "multipart/form-data".
                content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
                response = await client.PostAsync(uri, content);
                responseContent = response.Content.ReadAsStringAsync().Result;
            }

            //A peak at the JSON response.
            Console.WriteLine(responseContent);

            List<Face> faces = new List<Face>();
            try
            {
                faces = JsonConvert.DeserializeObject<List<Face>>(responseContent);

            }
            catch (Exception)
            {

                Console.WriteLine("Exception");
            }

            return faces;
        }

        public static byte[] GetImageAsByteArray(Image image)
        {
            int quality = 60;
            MemoryStream memoryStream = new MemoryStream();
            new ImageProcessor.ImageFactory().Load(image)
                                             .Format(new ImageProcessor.Imaging.Formats.JpegFormat() { Quality = quality })
                                             .Save(memoryStream);
            BinaryReader binaryReader = new BinaryReader(memoryStream);
            return binaryReader.ReadBytes((int)memoryStream.Length);
        }
    }
}
