namespace DotNetStandard.Specification
{
    public static class SpecificationExtensions
    {
        public static ISpecification<T> And<T>(this ISpecification<T> a, ISpecification<T> b)
        {
            return new AndSpecification<T>(a, b);
        }

        public static ISpecification<T> Or<T>(this ISpecification<T> a, ISpecification<T> b)
        {
            return new OrSpecification<T>(a, b);
        }

        public static ISpecification<T> Xor<T>(this ISpecification<T> a, ISpecification<T> b)
        {
            return new XOrSpecification<T>(a, b);
        }

        public static ISpecification<T> Not<T>(this ISpecification<T> specification)
        {
            return new NotSpecification<T>(specification);
        }

        public static ISpecification<T> AndNot<T>(this ISpecification<T> a, ISpecification<T> b)
        {
            return a.And(b.Not());
        }
    }
}