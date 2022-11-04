using System.Net;

namespace WebApi.Data.Wrapper
{
    public class Response
    {
        public string Message { get; set; }
        public HttpStatusCode StatusCode { get; set; }
        public string Token { get; set; }

    }
}
