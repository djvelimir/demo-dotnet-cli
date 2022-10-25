namespace DemoDotnetCli.Shuffler
{
    public class StringShuffler : IStringShuffler
    {
        private Random rng = new Random();

        public string Shuffle(string characters)
        {
            IList<string> list = characters.Split("").ToList();
            int n = list.Count;

            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                string value = list[k];
                list[k] = list[n];
                list[n] = value;
            }

            return string.Join("", list);
        }
    }
}