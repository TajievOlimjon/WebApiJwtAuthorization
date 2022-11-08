using System.ComponentModel.DataAnnotations;

namespace WebApi.Entities.EntitieDtos
{
    public class BookDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Descrption { get; set; }
        public DateTimeOffset PublishedDate { get; set; }
        public int QuantityPublishedBook { get; set; }
        public string AddressPublisher { get; set; }
        public DateTimeOffset CreateDate { get; set; }
        public DateTimeOffset UpdateDate { get; set; }
    }
}
