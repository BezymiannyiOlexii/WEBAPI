using NUnit.Framework;
using System;
using RestSharp;

namespace Web_api
{
    [TestFixture()]
    class Task_3: Initilize
    {
        [Test()]
        public void Delete()
        {
            RestClient restClient = new RestClient("https://api.dropboxapi.com/2/files/delete_v2\n");

            RestRequest restRequest = Initilize.Create_New_and_Format();
            Initilize.AddHeader_AddJsonBody();

            var response = restClient.Execute(restRequest);
            Assert.IsTrue(response.Content != null);
        }
    }
}
