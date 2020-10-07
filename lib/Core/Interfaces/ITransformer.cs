using Core.Types;

namespace Core.Interfaces
{
	public interface ITransformer<TIn, TOut> : IInvoker<TIn, TOut>
	{
		Return<TOut> Transform(TIn arg);

		Return<TOut> IInvoker<TIn, TOut>.Invoke(TIn arg)
			=> Transform(arg);
	}
}
