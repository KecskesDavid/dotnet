using System.Net;

namespace Api.Data.Models.DTO
{
    public class PostResponse
    {
        private string v;

        public PostResponse(int id, DateTime currentTime, HttpStatusCode responseCode)
        {
            Id = id;
            CreationDate = currentTime;
            ResponseCode = responseCode;
        }

        public PostResponse(int id, DateTime currentTime, HttpStatusCode responseCode, string v) : this(id, currentTime, responseCode)
        {
            this.v = v;
        }

        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        public HttpStatusCode ResponseCode { get; set; }
        public string? Message { get; set; }
    }
}
