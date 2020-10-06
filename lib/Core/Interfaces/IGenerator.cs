using Core.Types;

namespace Core.Interfaces
{
	public interface IGenerator<T> : IInvoker
	{
		T Generate();

		object IInvoker.Invoke(params object[] args)
		{
			if (args.Length > 0)
				return new Error();

			return Generate();
		}
	}
}
