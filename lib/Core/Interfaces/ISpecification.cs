using Core.Types;

namespace Core.Interfaces
{
	public interface ISpecification<T> : ITransformer<T, bool>
	{
		Return<bool> IsSatisfiedBy(T arg);

		Return<bool> ITransformer<T, bool>.Transform(T arg)
			=> IsSatisfiedBy(arg);
	}
}
