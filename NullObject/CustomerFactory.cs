public class CustomerFactory
{

    public static String[] names = { "Rob", "Joe", "Julie" };

    public static AbstractCustomer GetCustomer(String name)
    {
        for (int i = 0; i < names.Length; i++)
        {
            if (names[i].Equals(name))
            {
                return new RealCustomer(name);
            }
        }

        return new NullCustomer();
    }

}