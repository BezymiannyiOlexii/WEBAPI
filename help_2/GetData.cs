using NUnit.Framework;
using System;
using RestSharp;

namespace Web_api
{
    [TestFixture()]
    class Task_2: Initilize
    {
        [Test()]
        public void GetMetaData()
        {
            RestClient restClient = new RestClient("https://api.dropboxapi.com/2/files/get_metadata");

            RestRequest restRequest = Initilize.Create_New_and_Format();
            Initilize.AddHeader_AddJsonBody();

            var response = restClient.Execute(restRequest);
            Assert.IsTrue(response.Content != null);
        }
    }
}
