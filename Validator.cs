using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Kebele_Management_System
{
    internal class Validator
    {
        //isValidName
        internal bool isValidName(string name)
        {
            Regex regex = new Regex(@"^[a-zA-Z\s]+$");
            if (regex.IsMatch(name)) return true;
            else return false;
        }
        //isEmptyText
        internal bool isEmptyText(string text) { 
            if(text == null || text == "") return true;
            else return false;
        }
        //isValidPhoneNumber
        internal bool isValidPhoneNumber(string phoneNumber)
        {
            Regex regex = new Regex(@"^+251[1-59]\d{8}$");
            if (regex.IsMatch(phoneNumber)) return true;
            else return false;
            
        }
        //isValidEmail
        internal bool isValidEmail(string email)
        {
            Regex regex = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
            if (regex.IsMatch(email)) return true;
            else return false;
        }
    }
}
