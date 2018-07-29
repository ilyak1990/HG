using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;


namespace HealthGuardApp
{
    public class InputValidation
    {

        public static bool validatePassowrd(string password1, string password2)
        {
            bool check = true;

            if (password1.Equals(password2) ==false)
            {
                check = false;
            }
            return check;
        }

        public static bool validateEmail(string uemail)
        {
            bool check = true;

            var emailcheck = new EmailAddressAttribute();
            if (emailcheck.IsValid(uemail))
            {
                check = true;
            }
            else
            {
                check = false;
            }
            return check;

        }

        //public static bool validatePhoneNumber(string pnum)
        //{
        //    bool check = true;
        //    String phoneCheck = pnum;
        //    string NumberCheck = "^\\(?([0-9]{3})\\)?([0-9]{3})?([0-9]{4})$";
        //    if (phoneCheck.Contains("("))
        //    {
        //        phoneCheck = phoneCheck.Replace("(", "");
        //    }
        //    if (phoneCheck.Contains(")"))
        //    {
        //        phoneCheck = phoneCheck.Replace(")", "");
        //    }
        //    if (phoneCheck.Contains("-"))
        //    {
        //        phoneCheck = phoneCheck.Replace("-", "");
        //    }
        //    if (phoneCheck.Contains("."))
        //    {
        //        phoneCheck = phoneCheck.Replace(".", "");
        //    }
        //    if (phoneCheck.Contains(" "))
        //    {
        //        phoneCheck = phoneCheck.Replace(" ", "");
        //    }
        //    if (phoneCheck.Length == 10 && Regex.IsMatch(phoneCheck, NumberCheck))
        //    {
        //        check = true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //    return check;
        //}
        //public static bool validateEmail(string uemail)
        //{
        //    bool check = true;

        //    var emailcheck = new EmailAddressAttribute();
        //    if (emailcheck.IsValid(uemail))
        //    {
        //        check = true;
        //    }
        //    else
        //    {
        //        check = false;
        //    }
        //    return check;

        //}
    }
}