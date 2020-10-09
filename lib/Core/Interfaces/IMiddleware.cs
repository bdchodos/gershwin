using Core.Types;

namespace Core.Interfaces
{
	public interface IMiddleware
	{
		Return Filter(IInvoker invoker, params object[] args);
	}

	public interface IMiddleware<TOut>
	{
		Return<TOut> Filter(IInvoker<TOut> invoker);
	}

	public interface IMiddleware<TIn, TOut>
	{
		Return<TOut> Filter(IInvoker<TIn, TOut> invoker, TIn arg);
	}

	public interface IMiddleware<TIn1, TIn2, TOut>
	{
		Return<TOut> Filter(IInvoker<TIn1, TIn2, TOut> invoker, TIn1 arg1, TIn2 arg2);
	}
}
