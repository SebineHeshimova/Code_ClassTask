namespace WebApplication4.Models
{
    public class Image
    {
        public int Id { get; set; }
        public string Url {  get; set; }
        public int WorkId {  get; set; }
        public Work Work { get; set; }
    }
}
