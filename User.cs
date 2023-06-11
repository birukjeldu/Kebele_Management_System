

namespace Kebele_Management_System.Users
{
    public class RegisteredUser
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string FatherName { get; set; }
        public string GrandFatherName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Sex { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
        public string BloodType { get; set; }
        public string Nationality { get; set; }
        public string Occupation { get; set; }
        public string DateOfBirth { get; set; }
        public string MaritalStatus { get; set; }
        public string ApprovedDate { get; set; }
        public string ExpireDate { get; set; }
        public string Region { get; set; }
        public string Zone { get; set; }
        public string Woreda { get; set; }
        public string Kebele { get; set; }
        public int HouseNumber { get; set; }
        public byte[] Image { get; set; }


        public RegisteredUser(int id, string firstName, string fatherName, string grandFatherName, string email, string phone, string sex, string password, int age, string bloodType, string nationality, string occupation, string dateOfBirth, string maritalStatus, string approvedDate, string expireDate, string region, string zone, string woreda, string kebele, int houseNumber, byte[] image)
        {
            Id = id;
            FirstName = firstName;
            FatherName = fatherName;
            GrandFatherName = grandFatherName;
            Email = email;
            Phone = phone;
            Sex = sex;
            Password = password;
            Age = age;
            BloodType = bloodType;
            Nationality = nationality;
            Occupation = occupation;
            DateOfBirth = dateOfBirth;
            MaritalStatus = maritalStatus;
            ApprovedDate = approvedDate;
            ExpireDate = expireDate;
            Region = region;
            Zone = zone;
            Woreda = woreda;
            Kebele = kebele;
            HouseNumber = houseNumber;
            Image = image;
        }
    }
}
