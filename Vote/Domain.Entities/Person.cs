using System.ComponentModel.DataAnnotations;

namespace Vote.Domain.Entities
{
    public class Person
    {
        public Guid Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        [Required]
        public string Surname { get; set; }

        public string SecondSurname { get; set; }

        public DateTime BirthDate { get; set; }

        public string Gender { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public string Nationality { get; set; }

        public string MaritalStatus { get; set; }

        public string Occupation { get; set; }

        public string EducationLevel { get; set; }

        public string Photo { get; set; }
    }
}