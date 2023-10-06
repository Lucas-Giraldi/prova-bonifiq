namespace ProvaPub.Services
{
	public class RandomService
	{
		int seed;
		public RandomService()
		{
			
		}
		public int GetRandom()
		{
            seed = Guid.NewGuid().GetHashCode();
            return new Random(seed).Next(100);
		}

	}
}
