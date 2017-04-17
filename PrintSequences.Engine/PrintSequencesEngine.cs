using System.Collections.Generic;
using System.Linq;
using PrintSequences.Model;

namespace PrintSequences.Engine
{
	public class PrintSequencesEngine : IPrintSequencesEngine
	{
		private readonly int _pagesPerPage;
		private readonly int _totalPages;
		private readonly List<Pair<int>> _oddSequence = new List<Pair<int>>();
		private List<Pair<int>> _evenSequence = new List<Pair<int>>();
		private bool _processed = false;

		public PrintSequencesEngine(int pagesPerPage, int totalPages)
		{
			_pagesPerPage = pagesPerPage;
			_totalPages = totalPages;
		}

		private void Process()
		{
			var upperBound = _totalPages;
			var lowerBound = 1;

			var workingList = _oddSequence;

			for (var i = 0; i < _totalPages/2; i++)
			{
				workingList.Add(new Pair<int> { First = upperBound, Second = lowerBound });
				upperBound = upperBound - 2;
				lowerBound = lowerBound + 2;
				if (upperBound + 1 == lowerBound || lowerBound + 1 == upperBound)
				{
					workingList = _evenSequence;
				}
			}

			var swapLength = _pagesPerPage/2;
			if (swapLength == 1) return;
			var accummulator = new List<Pair<int>>();
			var sublists = _evenSequence.Chunk(swapLength);

			foreach (var sublist in sublists)
			{
				var chunk = sublist.Chunk(swapLength/2).ToArray();
				accummulator.AddRange(chunk.ElementAt(1));
				accummulator.AddRange(chunk.ElementAt(0));
			}

			_evenSequence = accummulator;
			_processed = true;
		}


		public PrintSequence ComputeEvenPrintSequence()
		{
			if (!_processed) Process();
			return new PrintSequence
			{
				PrintSequenceType = PrintSequenceType.Even,
				Values = _evenSequence.SelectMany(i => new[] {i.First, i.Second})
			};
		}

		public PrintSequence ComputeOddPrintSequence()
		{
			if (!_processed) Process();
			return new PrintSequence
			{
				PrintSequenceType = PrintSequenceType.Odd,
				Values = _oddSequence.SelectMany(i => new[] { i.First, i.Second })
			};
		}
	}
}