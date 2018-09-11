namespace DotNetStandard.Specification
{
    public sealed class AlwayTrueSpecification<T> : ISpecification<T>
    {
        public bool IsSatisfiedBy(T o)
        {
            return true;
        }
    }
}
