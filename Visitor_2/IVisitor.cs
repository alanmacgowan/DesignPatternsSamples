public interface IVisitor
{
    public decimal Visit(ProductSoldByQuantity product);
    public decimal Visit(ProductSoldByWeight product);
    public string GetName();
}