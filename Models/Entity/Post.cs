using Ders21.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace ders21.Models.Entity
{
    public class Post
    {
        public int ıd { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string ConverImageUrl { get; set; }

        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }

        [ForeignKey("CreatedBy")]
        public virtual User CreatedByUser { get; set; }
    }
}
