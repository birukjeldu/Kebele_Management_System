using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kebele_Management_System
{
    public class UserCertInfo
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string PlaceofBirth { get; set; }
        public string GGFatherName { get; set; }
        public string FullMotherName { get; set; }
        public string FatherNationality { get; set; }
        public string MotherNationality { get; set; }
        public string DateofIssue { get; set; }

        public UserCertInfo(int id, int userId, string placeofBirth, string GFatherName, string fullMotherName, string fatherNationality, string motherNationality, string dateofIssue)
        {
            Id = id;
            UserId = userId;
            PlaceofBirth = placeofBirth;
            GGFatherName = GFatherName;
            FullMotherName = fullMotherName;
            FatherNationality = fatherNationality;
            MotherNationality = motherNationality;
            DateofIssue = dateofIssue;

        }
    }
}
