using Core.Types;
namespace Core.Internal
{
	internal static class ArgValidator
	{
		internal static Return<object> ValidateArgs(object[] args)
		{
			if (args.Length != 0)
				return new Error();

			return new object();
		}

		internal static Return<T> ValidateArgs<T>(object[] args)
		{
			if (args.Length != 1)
				return new Error();

			if (!(args[0] is T arg1))
				return new Error();

			return arg1;
		}

		internal static Return<(T1, T2)> ValidateArgs<T1, T2>(object[] args)
		{
			if (args.Length != 2)
				return new Error();

			if (!(args[0] is T1 arg1))
				return new Error();

			if (!(args[1] is T2 arg2))
				return new Error();

			return (arg1, arg2);
		}
	}
}
