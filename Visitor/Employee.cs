public class Employee : Element
{
    private string name;
    private double income;
    private int vacationDays;
    // Constructor
    public Employee(string name, double income,
        int vacationDays)
    {
        this.name = name;
        this.income = income;
        this.vacationDays = vacationDays;
    }
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public double Income
    {
        get { return income; }
        set { income = value; }
    }
    public int VacationDays
    {
        get { return vacationDays; }
        set { vacationDays = value; }
    }
    public override void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}