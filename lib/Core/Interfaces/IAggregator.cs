using Core.Types;

namespace Core.Interfaces
{
	public interface IAggregator<T> : IReducer<T, T, T>
	{
		Return<T> Aggregate(T arg1, T arg2);

		Return<T> IReducer<T, T, T>.Reduce(T arg1, T arg2)
			=> Aggregate(arg1, arg2);
	}
}
