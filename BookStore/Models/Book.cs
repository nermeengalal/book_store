using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class Book
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string AuthorName { get; set; }

        public string Image { get; set; }

        public int Price { get; set; }

        public string BookLink { get; set; }

        public int catId { get; set; }

        [JsonIgnore]
        [ForeignKey("catId")]
        public virtual Category category { get; set; }
    }
}
