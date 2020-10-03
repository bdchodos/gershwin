namespace Core.Interfaces
{
	public interface IAggregator<TIn, TOut> : IReducer<TIn, TIn, TOut>
	{
	}
}
