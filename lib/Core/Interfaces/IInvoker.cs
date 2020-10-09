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
		{
			if (args.Length != 0)
				return new Error();

			return Invoke();
		}
	}

	public interface IInvoker<TIn, TOut> : IInvoker
	{
		Return<TOut> Invoke(TIn arg);

		Return IInvoker.Invoke(params object[] args)
		{
			if (args.Length != 1)
				return new Error();

			if (!(args[0] is TIn arg))
				return new Error();

			return Invoke(arg);
		}
	}

	public interface IInvoker<TIn1, TIn2, TOut> : IInvoker
	{
		Return<TOut> Invoke(TIn1 arg1, TIn2 arg2);

		Return IInvoker.Invoke(params object[] args)
		{
			if (args.Length != 2)
				return new Error();

			if (!(args[0] is TIn1 arg1))
				return new Error();

			if (!(args[1] is TIn2 arg2))
				return new Error();

			return Invoke(arg1, arg2);
		}
	}
}
