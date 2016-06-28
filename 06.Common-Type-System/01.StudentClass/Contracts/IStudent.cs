namespace StudentClass.Contracts
{
    using Models;
    using Models.UniversityEnumerations;

    public interface IStudent
    {
        string FirstName { get; set; }

        string MiddleName { get; set; }

        string LastName { get; set; }

        string FullName { get; }

        int SSN { get; set; }

        Address PermanentAddress { get; set; }

        string MobilePhone { get; set; }

        string Email { get; set; }

        UniversityType University { get; set; }

        FacultyType Faculty { get; set; }

        SpecialtyType Specialty { get; set; }

        CourseType Course { get; set; }
    }
}