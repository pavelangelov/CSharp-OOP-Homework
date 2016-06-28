namespace StudentClass.Models
{
    using System;
    using System.Text;

    using Contracts;
    using UniversityEnumerations;

    public class Student : IStudent, ICloneable, IComparable
    {
        public Student(string firstName, string middleName, string lastName, Address addres, UniversityType university, FacultyType faculty, SpecialtyType specialty, CourseType course)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.PermanentAddress = addres;
            this.University = university;
            this.Faculty = faculty;
            this.Specialty = specialty;
            this.Course = course;
        }
        public Student(string firstName, string middleName, string lastName, Address addres, UniversityType university, FacultyType faculty, SpecialtyType specialty, CourseType course, int ssn, string email)
            : this(firstName, middleName, lastName, addres, university, faculty, specialty, course)
        {
            this.SSN = ssn;
            this.Email = email;
        }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string FullName
        {
            get
            {
                return this.FirstName + " " + this.MiddleName + " " + this.LastName;
            }
        }

        public int SSN { get; set; }

        public Address PermanentAddress { get; set; }

        public string MobilePhone { get; set; }

        public string Email { get; set; }

        public UniversityType University { get; set; }

        public FacultyType Faculty { get; set; }

        public SpecialtyType Specialty { get; set; }

        public CourseType Course { get; set; }

        public override string ToString()
        {
            string separator = new string('-', 40);
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(separator);
            sb.AppendLine($"Name: {this.FullName}");
            sb.AppendLine($"Social Security Number: {this.SSN}");
            sb.AppendLine($"Permanent address: {this.PermanentAddress}");
            sb.AppendLine($"Phone: {this.MobilePhone ?? "<unknown>"}");
            sb.AppendLine($"Email: {this.Email ?? "<unknown>"}");
            sb.AppendLine($"University: {this.University}");
            sb.AppendLine($"Specialty: {this.Specialty}");
            sb.AppendLine($"Course: {this.Course}");
            sb.AppendLine(separator);

            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            var otherSt = obj as Student;
            if (this.FullName != otherSt.FullName)
            {
                return false;
            }
            if (!this.PermanentAddress.Equals(otherSt.PermanentAddress))
            {
                return false;
            }
            if (this.SSN != otherSt.SSN)
            {
                return false;
            }

            return true;
        }

        public override int GetHashCode()
        {
            return (this.FullName.GetHashCode() / RandomNumber.randomNum.Next(200)) * RandomNumber.randomNum.Next(2000);
        }

        public object Clone()
        {
            var addresCloning = this.PermanentAddress.Clone() as Address;

            return new Student(this.FirstName, this.MiddleName, this.LastName, addresCloning, this.University, this.Faculty, this.Specialty, this.Course);
        }

        public int CompareTo(object obj)
        {
            var otherSt = obj as Student;
            int nameCompares = this.FullName.CompareTo(otherSt.FullName);

            if (nameCompares != 0)
            {
                return nameCompares;
            }
            else
            {
                return this.SSN.CompareTo(otherSt.SSN);
            }
        }

        public static bool operator ==(Student first, Student second)
        {
            return first.Equals(second);
        }

        public static bool operator !=(Student first, Student second)
        {
            return !(first.Equals(second));
        }

    }
}
