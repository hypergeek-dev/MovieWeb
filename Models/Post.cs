using System.Numerics;
using System.Reflection;

namespace MovieWeb.Models
{
    public class Post
    {
     
        public int Id { get; set; }
        public string Title { get; set; }

        public string Description { get; set; }

        public string Status { get; set; }

        public DateTime CreatedAt { get; set; }

        public string PostImage {  get; set; }
    }
}
