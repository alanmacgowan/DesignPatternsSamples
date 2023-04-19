namespace Specification_2
{
    public class PremiumSpecification<T> : CompositeSpecification<T>
    {
        private int cost;
        public PremiumSpecification(int cost)
        {
            this.cost = cost;
        }

        public override bool IsSatisfiedBy(T o)
        {
            return (o as Mobile).Cost >= this.cost;
        }
    }
}
