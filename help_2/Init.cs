using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace Web_api
{
    public class Initilize
    {
        static public string filename = @"D:\study\С#\main.jpg"; //img from my PC
        static public string token = "J6uJoHF4FAUAAAAAAAAAAQZftSlLkrIDIyUWxa21UMl72raM-ON2dpIqzoFJ82NS"; //my_dropbox
        static RestRequest _restRequest;
        static public RestRequest Create_New_and_Format()
        {
            RestRequest restRequest = new RestRequest(Method.POST);
            restRequest.RequestFormat = DataFormat.Json;
            _restRequest = restRequest;
            return restRequest;
        }

        static public void AddHeader_AddJsonBody()
        {
            _restRequest.AddHeader("Authorization", "Bearer " + token);
            _restRequest.AddHeader("Content-Type", "application/json");
            _restRequest.AddJsonBody("{\"path\":\"/folder/main.jpg\"}");
        }

    }
}
