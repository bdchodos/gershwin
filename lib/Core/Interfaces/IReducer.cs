using Core.Types;

namespace Core.Interfaces
{
	public interface IReducer<TIn1, TIn2, TOut> : ITransformer<(TIn1, TIn2), TOut>, IInvoker<TIn1, TIn2, TOut>
	{
		Return<TOut> Reduce(TIn1 arg1, TIn2 arg2);

		Return<TOut> ITransformer<(TIn1, TIn2), TOut>.Transform((TIn1, TIn2) arg)
			=> Reduce(arg.Item1, arg.Item2);

		Return<TOut> IInvoker<TIn1, TIn2, TOut>.Invoke(TIn1 arg1, TIn2 arg2)
			=> Reduce(arg1, arg2);
	}
}
