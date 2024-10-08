﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace BookStoreApp.Api.Models
{
    [Index(nameof(DisplayName), IsUnique = true)]
    public class Author
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("author_id")]
        public int AuthorID { get; set; }

        [Required]
        [StringLength(100)]
        [Column("name")]
        public string Name { get; set; }

        [Required]
        [StringLength(100)]
        [Column("display_name")]
        public string DisplayName { get; set; }

       
        [StringLength(1000)]
        [Column("biography")]
        public  string? Biography { get; set; }

        [JsonIgnore]
        public IEnumerable<Book> Books { get; set; } = new List<Book>();

    }
}
