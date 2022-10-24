namespace DemoDotnetCli.Extension
{
    public static class RandomCharacterExtension
    {
        private static readonly Random random = new Random();

        public static char GetRandomCharacter(this String characters)
        {
            return characters.ElementAt(random.Next(characters.Length));
        }
    }
}