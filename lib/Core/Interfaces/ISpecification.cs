namespace Core.Interfaces
{
	public interface ISpecification<T> : ITransformer<T, bool>
	{
		bool IsSatisfiedBy(T arg);

		bool ITransformer<T, bool>.Transform(T arg)
			=> IsSatisfiedBy(arg);
	}
}
