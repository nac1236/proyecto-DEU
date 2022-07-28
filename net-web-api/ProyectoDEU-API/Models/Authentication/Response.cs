namespace ProyectoDEU_API.Models.Authentication
{
    public class Response
    {
        public string Status { get; set; }
        public string Message { get; set; }
        public List<string> Errors { get; set; }
    }
}
