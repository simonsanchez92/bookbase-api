﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Bookbase.Domain.Models
{
    [Table("genres")]
    public class Genre
    {
        [Column("genre_id")]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        //Navigation property
        public ICollection<BookGenre> BookGenres { get; set; } = new List<BookGenre>(); //many-to-many with Book
    }
}
