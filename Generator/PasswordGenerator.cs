using System.Text;
using DemoDotnetCli.Extension;

namespace DemoDotnetCli.Generator
{
    public class PasswordGenerator : IPasswordGenerator
    {
        private static readonly int PASSWORD_LENGTH = 16;
        private static readonly String UPPERCASE_CHARACTERS = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private static readonly String LOWERCASE_CHARACTERS = "abcdefghijklmnopqrstuvwxyz";
        private static readonly String DIGIT_CHARACTERS = "0123456789";
        private static readonly String SPECIAL_CHARACTERS = "~`!@#$%^&*()-_=+[{]}\\|;:\'\",<.>/?";
        private static readonly String UNION_OF_ALLOWED_CHARACTERS = UPPERCASE_CHARACTERS +
                LOWERCASE_CHARACTERS +
                DIGIT_CHARACTERS +
                SPECIAL_CHARACTERS;

        /// <summary>
        /// Generate random password
        /// Generated password length is 16
        /// Generated password contains at least one uppercase character
        /// Generated password contains at least one lowercase character
        /// Generated password contains at least one digit character
        /// Generated password contains at least one special character
        /// </summary>
        /// <returns>Generated password</returns>
        public String Generate()
        {
            var stringBuilder = new StringBuilder();

            // generate at least one uppercase character
            stringBuilder.Append(UPPERCASE_CHARACTERS.GetRandomCharacter());

            // generate at least one lowercase character
            stringBuilder.Append(LOWERCASE_CHARACTERS.GetRandomCharacter());

            // generate at least one digit character
            stringBuilder.Append(DIGIT_CHARACTERS.GetRandomCharacter());

            // generate at least one special character
            stringBuilder.Append(SPECIAL_CHARACTERS.GetRandomCharacter());

            for (int i = 4; i < PASSWORD_LENGTH; i++)
            {
                // generate random character from union of allowed characters
                stringBuilder.Append(UNION_OF_ALLOWED_CHARACTERS.GetRandomCharacter());
            }

            // return shuffled generated characters
            return stringBuilder.ToString().Shuffle();
        }
    }
}