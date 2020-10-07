using Core.Types;

namespace Core.Interfaces
{
	public interface IGenerator<T> : IInvoker<T>
	{
		Return<T> Generate();

		Return<T> IInvoker<T>.Invoke()
			=> Generate();
	}
}
