namespace DotNetStandard.Specification
{
    public sealed class NotSpecification<T> : ISpecification<T>
    {
        private readonly ISpecification<T> _specification;

        public NotSpecification(ISpecification<T> specification)
        {
            _specification = specification;
        }

        public bool IsSatisfiedBy(T o)
        {
            return !_specification.IsSatisfiedBy(o);
        }
    }
}