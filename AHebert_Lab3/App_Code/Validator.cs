using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6___Form
{
    class Validator
    {

        //checks to make sure the user didnt use a bad word
        public static bool BadWords(string temp)
        {
            bool result = false;

            string[] strBadWords = { "POOP", "HOMEWORK", "CACA" };

            foreach (string strBW in strBadWords)
                if (temp.Contains(strBW))
                {
                    result = true;
                }
            return result;
        }

        //checks to make sure the user actually input something
        public static bool LengthNull(string temp)
        {
            bool result = false;

            if (temp.Length == 0)
            {
                result = true;
            }
            return result;

        }

        //checks to make sure the user input a valid zip code
        public static bool ZipCorrect(string temp)
        {
            bool result = false;
            int tempInt;

            if (Int32.TryParse(temp, out tempInt) == true)
            {

                if (temp.Length == 0 || temp.Length > 5)
                {
                    result = false;
                }
                else
                {
                    result = true;
                }

            }
            return result;

        }

        //checks to make sure the user input a valid state
        public static bool StateCorrect(string temp)
        {
            bool result = false;

            if (temp.All(Char.IsLetter) == true)
            {

                if (temp.Length == 0 || temp.Length > 2)
                {
                    result = false;
                }
                else
                {
                    result = true;
                }

            }
            return result;

        }

        //checks to make sure the user input a valid phone number. Copied shamelessly from http://www.java2s.com/Code/CSharp/Development-Class/ValidatePhoneNumber.htm
        public static bool PhoneCorrect(string temp)
        {
            return System.Text.RegularExpressions.Regex.Match(temp, @"^[1-9]\d{2}[1-9]\d{2}\d{4}$").Success;

        }

        //checks to make sure the user input a valid email
        public static bool EmailCorrect(string temp)
        {
            try
            {
                var emailCheck = new System.Net.Mail.MailAddress(temp);
                return emailCheck.Address == temp;
            }

            catch
            {
                return false;
            }

        }

        //checks to make sure the user input a valid DateTime for CustomerSince
        public static bool DateTimeCorrect(DateTime temp)
        {
            if (temp < DateTime.Now)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        //Checks to see if TotalPurchases is valid
        public static bool TotalPurchasesCorrect(Double temp)
        {
            if (temp >= 0)
            {
                return true;
            }

            else
            {
                return false;
            }

        }


        public static bool BoolCheck(string temp)
        {
            if (temp == "y" || temp == "Y" || temp == "yes" || temp == "Yes" || temp == "YES" || temp == "true" || temp == "True" || temp == "TRUE")
            {
                return true;
            }

            else
            {
                return false;
            }


        }

        //Checks to see if Discount Membership input is valid

        public static bool DiscMemCorrect(Boolean temp)
        {
            if (temp == true || temp == false)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        //Checks to see if Rewards Earned is correct
        public static bool RewEarnCorrect(Int32 temp)
        {
            if (temp >= 0)
            {
                return true;
            }

            else
            {
                return false;
            }

        }
    }
}
