public class ProductSoldByQuantity : BaseProduct
{
    public int Quantity { get; set; }

    public override decimal Accept(IVisitor visitor)
    {
        return visitor.Visit(this);
    }
}