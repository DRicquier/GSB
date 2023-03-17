using System.Text.RegularExpressions;

namespace lesClasses {
    
    public class CheckUtils {

        private static readonly string TELEPHONE_REGEX = @"^(0|\+33)[1-9](\d{2}){4}$";
        private static readonly string EMAIL_REGEX = @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$";

        public static bool isValidNumber(string telephone) {
            return Regex.IsMatch(telephone, TELEPHONE_REGEX);
        }

        public static bool isValidEmail(string email) {
            return Regex.IsMatch(email, EMAIL_REGEX);
        }
    }
}