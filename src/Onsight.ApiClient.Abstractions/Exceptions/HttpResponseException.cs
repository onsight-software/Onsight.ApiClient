using System;
using System.Net;
using System.Net.Http;

namespace Onsight.ApiClient.Abstractions.Exceptions
{
    public class HttpResponseException : Exception
    {
        public HttpResponseException(HttpStatusCode statusCode,  string method, string uri, string content) 
            : base($"{statusCode}: {content}")
        {
            StatusCode = statusCode;
            Method = method;
            Uri = uri;
        }

        public HttpStatusCode StatusCode { get; }
        public string Method { get; }
        public string Uri { get; }
    }
}