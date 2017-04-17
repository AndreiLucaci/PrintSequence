using System.Collections.Generic;

namespace PrintSequences.Engine
{
	public class PrintSequence
	{
		public PrintSequenceType PrintSequenceType { get; set; }
		public IEnumerable<int> Values { get; set; } = new List<int>();
	}
}