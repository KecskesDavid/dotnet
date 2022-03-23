using System.Net;

namespace Api.Controllers.Response
{
    public class Response
    {
        public Response(string title, DateTime creationDate, HttpStatusCode responseCode, string? message)
        {
            Title = title;
            CreationDate = creationDate;
            ResponseCode = responseCode;
            Message = message;
        }

        public string Title { get; set; }
        public DateTime CreationDate { get; set; }
        public HttpStatusCode ResponseCode { get; set; }
        public string? Message { get; set; }
    }
}
