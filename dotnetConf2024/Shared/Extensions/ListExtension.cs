using System.Security.Cryptography;

namespace dotnetConf2024.Shared.Extensions
{
    public static class ListExtension
    {
        private static Random rng = new Random();

        public static IEnumerable<T> Shuffle<T>(this IList<T> list)
        {
            var n = list.Count;
            while (n > 1)
            {
                n--;
                var k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
            return list;
        }

        public static IEnumerable<T> BetterShuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                var box = new byte[1];
                do RandomNumberGenerator.GetBytes(1);
                while (!(box[0] < n * (byte.MaxValue / n)));
                var k = box[0] % n;
                n--;
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
            return list;
        }
    }
}
