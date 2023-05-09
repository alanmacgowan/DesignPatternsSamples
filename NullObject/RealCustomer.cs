public class RealCustomer : AbstractCustomer
{

    public RealCustomer(String name)
    {
        this.Name = name;
    }

    public override string GetName()
    {
        return Name;
    }

    public override bool IsNull()
    {
        return false;
    }
}