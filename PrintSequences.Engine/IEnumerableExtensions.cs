using System.Collections.Generic;
using System.Linq;

namespace PrintSequences.Engine
{
	public static class IEnumerableExtensions
	{
		public static IEnumerable<IEnumerable<T>> Chunk<T>(this IEnumerable<T> source, int chunksize)
		{
			while (source.Any())
			{
				yield return source.Take(chunksize);
				source = source.Skip(chunksize);
			}
		}
	}
}