namespace DotNetStandard.Specification
{
    public interface ISpecification<in T>
    {
        bool IsSatisfiedBy(T o);
    }
}
