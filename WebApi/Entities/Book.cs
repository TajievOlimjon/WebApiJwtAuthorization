﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Entities
{
    public class Book
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Descrption { get; set; }
        public DateTimeOffset PublishedDate { get; set; }
        public int QuantityPublishedBook { get; set; }
        //public Guid PublisherId { get; set; }
        public string AddressPublisher { get; set; }
        public DateTimeOffset CreateDate { get; set; }
        public DateTimeOffset UpdateDate { get; set; }
        public List<BookAuthor>? Authors { get; set; }

    }
}
