public class Solution {
    public bool StrongPasswordCheckerII(string password) {
        if (password.Length < 8) return false;

        bool hasLower = false, hasUpper = false, hasDigit = false, hasSpecial = false;
        string specialCharacters = "!@#$%^&*()-+";

        for (int i = 0; i < password.Length; i++) {
            char c = password[i];

            // Check for adjacent identical characters
            if (i > 0 && c == password[i - 1]) {
                return false;
            }

            // Check character types
            if (char.IsLower(c)) hasLower = true;
            else if (char.IsUpper(c)) hasUpper = true;
            else if (char.IsDigit(c)) hasDigit = true;
            else if (specialCharacters.Contains(c)) hasSpecial = true;
        }

        return hasLower && hasUpper && hasDigit && hasSpecial;
    }
}