using System.Collections.Generic;

namespace PrintSequences.Model
{
	public class PrintSequence
	{
		public PrintSequenceType PrintSequenceType { get; set; }
		public IEnumerable<int> Values { get; set; } = new List<int>();
	}
}