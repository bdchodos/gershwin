using Core.Internal;
using Core.Types;

namespace Core.Interfaces
{
	public interface IInvoker
	{
		Return Invoke(params object[] args);
	}

	public interface IInvoker<TOut> : IInvoker
	{
		Return<TOut> Invoke();

		Return IInvoker.Invoke(params object[] args)
			=> ArgValidator.ValidateArgs(args);
	}

	public interface IInvoker<TIn, TOut> : IInvoker
	{
		Return<TOut> Invoke(TIn arg);

		Return IInvoker.Invoke(params object[] args)
			=> ArgValidator.ValidateArgs<TIn>(args);
	}

	public interface IInvoker<TIn1, TIn2, TOut> : IInvoker
	{
		Return<TOut> Invoke(TIn1 arg1, TIn2 arg2);

		Return IInvoker.Invoke(params object[] args)
			=> ArgValidator.ValidateArgs<TIn1, TIn2>(args);
	}
}
