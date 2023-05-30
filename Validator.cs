using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kebele_Management_System
{
    internal class Validator
    {
        //isValidName
        internal bool isValidName(string name)
        {
            return true;
        }
        //isEmptyText
        internal bool isEmptyText(string text) { 
            if(text == null || text == "") return true;
            else return false;
        }
        //isValidPhoneNumber
        internal bool isValidPhoneNumber(string phoneNumber)
        {
            return true;
        }
        //isValidEmail
        internal bool isValidEmail(string email)
        {
            return true;
        }
        //isEmptyComboBox
        internal bool isEmptyComboBox(string CB)
        {
            return true;
        }
    }
}
