namespace ProvaPub.Services
{
	public class RandomService
	{
		public int GetRandom()
		{
            Random random = new Random();

            int seed = random.Next(1, 100);

            return seed;
		}

	}
}
