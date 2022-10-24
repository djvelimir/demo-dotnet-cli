namespace DemoDotnetCli.Extension
{
    public static class ShuffleExtension
    {
        private static Random rng = new Random();

        private static void Shuffle<T>(IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        public static string Shuffle(this string stringToShuffle)
        {
            IList<String> list = stringToShuffle.Split("").ToList();
            Shuffle(list);

            return string.Join("", list);
        }
    }
}