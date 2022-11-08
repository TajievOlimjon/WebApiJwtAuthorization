namespace WebApi.Entities.EntitieDtos
{
    public class GetBookAuthorDto
    {
        public Guid AuthorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public DateTimeOffset BirthDate { get; set; }
        public string Address { get; set; }
        public Guid BookId { get; set; }
        public string Name { get; set; }
        public string Descrption { get; set; }
        public DateTimeOffset PublishedDate { get; set; }
        public int QuantityPublishedBook { get; set; }
        public string AddressPublisher { get; set; }
    }
}
