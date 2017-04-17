using PrintSequences.Model;

namespace PrintSequences.Engine
{
	public interface IPrintSequencesEngine
	{
		PrintSequence ComputeEvenPrintSequence();
		PrintSequence ComputeOddPrintSequence();
	}
}