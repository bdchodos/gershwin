namespace Core.Interfaces
{
	public interface ITransformer<TIn, TOut>
	{
		TOut Transform(TIn arg);
	}
}
