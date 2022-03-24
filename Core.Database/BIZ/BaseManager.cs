using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Database.BIZ
{
    public class BaseManager
    {
        ResponseMessage _response;

        public AuthorizeData auth;

        public BaseManager()
        {
            auth = new AuthorizeData
            {
                actor = AuthorizeViewModel.actor,
                resource_name = AuthorizeViewModel.resource_name,
                station = AuthorizeViewModel.station
            };
        }

        public ResponseMessage response
        {
            get
            {
                if (_response == null)
                    _response = new ResponseMessage();
                return _response;
            }
        }
    }

    public class AuthorizeData
    {
        public string actor { get; set; }
        public string resource_name { get; set; }
        public string station { get; set; }
    }

    public static class AuthorizeViewModel
    {
        public static string actor { get; set; }
        public static string resource_name { get; set; }
        public static string station { get; set; }
    }

    [Serializable]
    public class ResponseMessage
    {
        public bool OK { get; set; }
        public object DATA { get; set; }
        public string MESSAGE_INFO { get; set; }
        public string ERROR_CODE { get; set; }
        public bool ERROR_SYSTEM
        {
            get
            {
                return (!string.IsNullOrEmpty(ERROR_MESSAGE)) ? true : false;
            }
        }
        public string ERROR_MESSAGE { get; set; }

        public string NODE_PROCESS { get; set; }
    }

    [Serializable]
    public class RequestMessage
    {
        public string SERVICE_NAME { get; set; }
        public string METHOD { get; set; }
        public string CONTROLLER_NAME { get; set; }
        public string ACTION_NAME { get; set; }
        public string DATA_POST { get; set; }
        public string HEADER { get; set; }
    }
}
