namespace Core.Interfaces
{
	public interface IReducer<TIn1, TIn2, TOut> : ITransformer<(TIn1, TIn2), TOut>
	{
		TOut Reduce(TIn1 arg1, TIn2 arg2);

		TOut ITransformer<(TIn1, TIn2), TOut>.Transform((TIn1, TIn2) arg)
			=> Reduce(arg.Item1, arg.Item2);
	}
}
