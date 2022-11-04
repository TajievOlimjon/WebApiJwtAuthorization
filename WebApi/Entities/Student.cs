using WebApi.Data;
using WebApi.Enums;

namespace WebApi.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
        private string email;

        public Gender Gender { get; set; }

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                this.email=Email;
            }
            
        }

      

    }
}
