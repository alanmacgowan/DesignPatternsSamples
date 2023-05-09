public class NullCustomer : AbstractCustomer
{
    public override bool IsNull()
    {
        return true;
    }

    public override string GetName()
    {
        return "Not Available in Customer Database";
    }
}