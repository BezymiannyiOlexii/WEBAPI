using NUnit.Framework;
using System;
using RestSharp;

namespace Web_api
{
    [TestFixture()]
    public class Task_1: Initilize
    {
        [Test()]
        public void Upload()
        {
            RestClient restClient = new RestClient("https://content.dropboxapi.com/2/files/upload");

            byte[] image = System.IO.File.ReadAllBytes(Initilize.filename);

            RestRequest restRequest = Initilize.Create_New_and_Format();

            restRequest.AddHeader("Authorization", "Bearer " + Initilize.token);
            restRequest.AddHeader("Dropbox-API-Arg", "{\"path\":\"/folder/main.jpg\"}");
            restRequest.AddParameter("application/octet-stream", image, "application/octet-stream", ParameterType.RequestBody);
            restRequest.AddHeader("Content-Type", "application/octet-stream");
            //restRequest.AddJsonBody()

            var response = restClient.Execute(restRequest);
            Assert.IsTrue(response.Content != null);
        }

    }

}
